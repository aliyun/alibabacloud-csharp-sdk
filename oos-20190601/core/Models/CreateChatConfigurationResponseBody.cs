// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateChatConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;: &quot;TestChatConfig-9be97b40&quot;, &quot;CreatedDate&quot;: &quot;2025-12-11T13:49:10+00:00&quot;, &quot;UpdatedDate&quot;: &quot;2025-12-11T13:59:02+00:00&quot;}</para>
        /// </summary>
        [NameInMap("ChatConfiguration")]
        [Validation(Required=false)]
        public CreateChatConfigurationResponseBodyChatConfiguration ChatConfiguration { get; set; }
        public class CreateChatConfigurationResponseBodyChatConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-11T13:49:10+00:00</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TestChatConfig-9be97b40</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-11T13:59:02+00:00</para>
            /// </summary>
            [NameInMap("UpdatedDate")]
            [Validation(Required=false)]
            public string UpdatedDate { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4DB0****1234</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
