using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;
using KickerBooking.Entities;

namespace KickerBooking
{
    public class BotAccessors
    {
        // The property accessor keys to use.
        public const string UserInfoAccessorName = "KickerBot.UserInfo";
        public const string DialogStateAccessorName = "KickerBot.DialogState";

        public BotAccessors(ConversationState conversationState, UserState userState)
        {
            ConversationState = conversationState ?? throw new ArgumentNullException(nameof(conversationState));
            UserState = userState ?? throw new ArgumentNullException(nameof(userState));
        }
        public IStatePropertyAccessor<DialogState> DialogStateAccessor { get; set; }
        public IStatePropertyAccessor<UserInfo> UserInfoAccessor { get; set; }
        public ConversationState ConversationState { get; }
        public UserState UserState { get; }
    }
}
