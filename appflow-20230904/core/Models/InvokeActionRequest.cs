// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appflow20230904.Models
{
    public class InvokeActionRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>action-xxx</para>
        /// </summary>
        [NameInMap("ActionId")]
        [Validation(Required=false)]
        public string ActionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ActionVersion")]
        [Validation(Required=false)]
        public string ActionVersion { get; set; }

        [NameInMap("AuthConfig")]
        [Validation(Required=false)]
        public InvokeActionRequestAuthConfig AuthConfig { get; set; }
        public class InvokeActionRequestAuthConfig : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>raw</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;AppId&quot;:&quot;xxxx&quot;,&quot;AppSecret&quot;:&quot;sk-xxx&quot;}</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public object Value { get; set; }

        }

        [NameInMap("Body")]
        [Validation(Required=false)]
        public Dictionary<string, object> Body { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>connector-xxx</para>
        /// </summary>
        [NameInMap("ConnectorId")]
        [Validation(Required=false)]
        public string ConnectorId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ConnectorVersion")]
        [Validation(Required=false)]
        public string ConnectorVersion { get; set; }

        [NameInMap("Headers")]
        [Validation(Required=false)]
        public Dictionary<string, string> Headers { get; set; }

        [NameInMap("Path")]
        [Validation(Required=false)]
        public Dictionary<string, string> Path { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public Dictionary<string, string> Query { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Stream")]
        [Validation(Required=false)]
        public bool? Stream { get; set; }

    }

}
