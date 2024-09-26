// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateUserSayRequest : TeaModel {
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

        [NameInMap("UserSayDefinition")]
        [Validation(Required=false)]
        public CreateUserSayRequestUserSayDefinition UserSayDefinition { get; set; }
        public class CreateUserSayRequestUserSayDefinition : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123232</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateUserSayRequestUserSayDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateUserSayRequestUserSayDefinitionSlotInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fb34adf2fv43f2</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>4</para>
                /// </summary>
                [NameInMap("StartIndex")]
                [Validation(Required=false)]
                public int? StartIndex { get; set; }

            }

        }

    }

}
