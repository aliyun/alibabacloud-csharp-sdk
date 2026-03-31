// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class UpdateChatConfigurationResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{&quot;Name&quot;: &quot;dingtalk&quot;, &quot;CreatedDate&quot;: &quot;2025-12-23T10:14:28+00:00&quot;, &quot;UpdatedDate&quot;: &quot;2025-12-23T10:16:37.178097&quot;}</para>
        /// </summary>
        [NameInMap("ChatConfiguration")]
        [Validation(Required=false)]
        public UpdateChatConfigurationResponseBodyChatConfiguration ChatConfiguration { get; set; }
        public class UpdateChatConfigurationResponseBodyChatConfiguration : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-23T10:14:28+00:00</para>
            /// </summary>
            [NameInMap("CreatedDate")]
            [Validation(Required=false)]
            public string CreatedDate { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingtalk</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2025-12-23T10:16:37.178097</para>
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
