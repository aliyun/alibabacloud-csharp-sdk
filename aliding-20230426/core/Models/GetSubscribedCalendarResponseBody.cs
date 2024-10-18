// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class GetSubscribedCalendarResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>012345</para>
        /// </summary>
        [NameInMap("author")]
        [Validation(Required=false)]
        public string Author { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>M5MjkxNDUxQHVzZXJzLmRpbmd0YWxrLmNv</para>
        /// </summary>
        [NameInMap("calendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国传统日历</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("managers")]
        [Validation(Required=false)]
        public List<string> Managers { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中国传统日历</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
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
