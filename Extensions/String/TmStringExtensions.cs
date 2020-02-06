﻿using Telegram.Bot.Types;
using Telegram.Bot.Types.InputFiles;
using Telegram.Bot.Types.ReplyMarkups;

namespace ImportShopApi.Extensions.String
{
  public static partial class StringExtensions
  {
    public static KeyboardButton ToKeyboardButton(this string value) => new KeyboardButton(value);

    public static InlineKeyboardButton ToInlineKeyboardButton(this string text, string query) =>
      new InlineKeyboardButton
      {
        Text = text,
        CallbackData = query
      };

    public static InputOnlineFile ToInputMedia(this string value) => new InputOnlineFile(value);
  }
}