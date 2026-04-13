// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PAICopilot20250731.Models
{
    public class ChatDetail : TeaModel {
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>Use the UTC time format: yyyy-MM-ddTHH:mm:ss.SSSZ</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ChatDetailUserInfo UserInfo { get; set; }
        public class ChatDetailUserInfo : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>to******</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>assistant</para>
            /// </summary>
            [NameInMap("Role")]
            [Validation(Required=false)]
            public string Role { get; set; }

        }

    }

}
