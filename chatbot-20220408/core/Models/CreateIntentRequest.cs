// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateIntentRequest : TeaModel {
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

        [NameInMap("IntentDefinition")]
        [Validation(Required=false)]
        public CreateIntentRequestIntentDefinition IntentDefinition { get; set; }
        public class CreateIntentRequestIntentDefinition : TeaModel {
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateIntentRequestIntentDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateIntentRequestIntentDefinitionSlotInfos : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public bool? Encrypt { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Interactive")]
                [Validation(Required=false)]
                public bool? Interactive { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fg452dfg3df23</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>This parameter is required.</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
