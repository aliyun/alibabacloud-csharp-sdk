// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateSubscribedCalendarsRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>M5MjkxNDUxQHVzZXJzLmRpbmd0YWxrLmNv</para>
        /// </summary>
        [NameInMap("CalendarId")]
        [Validation(Required=false)]
        public string CalendarId { get; set; }

        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Managers")]
        [Validation(Required=false)]
        public List<string> Managers { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("SubscribeScope")]
        [Validation(Required=false)]
        public UpdateSubscribedCalendarsRequestSubscribeScope SubscribeScope { get; set; }
        public class UpdateSubscribedCalendarsRequestSubscribeScope : TeaModel {
            [NameInMap("UserIds")]
            [Validation(Required=false)]
            public List<string> UserIds { get; set; }

        }

    }

}
