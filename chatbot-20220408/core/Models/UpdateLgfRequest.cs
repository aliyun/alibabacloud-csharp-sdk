// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateLgfRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-yjzbyrEvqd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("LgfDefinition")]
        [Validation(Required=false)]
        public UpdateLgfRequestLgfDefinition LgfDefinition { get; set; }
        public class UpdateLgfRequestLgfDefinition : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>23234523522</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("RuleText")]
            [Validation(Required=false)]
            public string RuleText { get; set; }

        }

        /// <summary>
        /// <para>LGF ID</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12121</para>
        /// </summary>
        [NameInMap("LgfId")]
        [Validation(Required=false)]
        public long? LgfId { get; set; }

    }

}
