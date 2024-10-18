// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateSubscribedCalendarRequest : TeaModel {
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("Managers")]
        [Validation(Required=false)]
        public List<string> Managers { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubscribeScope")]
        [Validation(Required=false)]
        public CreateSubscribedCalendarRequestSubscribeScope SubscribeScope { get; set; }
        public class CreateSubscribedCalendarRequestSubscribeScope : TeaModel {
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
