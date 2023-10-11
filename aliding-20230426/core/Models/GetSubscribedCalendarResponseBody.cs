// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSubscribedCalendarResponseBody : TeaModel {
        [NameInMap("author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        [NameInMap("calendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("managers")]
        [Validation(Required=false)]
        public List<string> Managers { get; set; }

        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// requestId
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("subscribeScope")]
        [Validation(Required=false)]
        public GetSubscribedCalendarResponseBodySubscribeScope SubscribeScope { get; set; }
        public class GetSubscribedCalendarResponseBodySubscribeScope : TeaModel {
            [NameInMap("CorpIds")]
            [Validation(Required=false)]
            public List<string> CorpIds { get; set; }

            [NameInMap("OpenConversationIds")]
            [Validation(Required=false)]
            public List<string> OpenConversationIds { get; set; }

            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
