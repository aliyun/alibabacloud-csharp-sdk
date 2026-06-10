// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateIntentRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If you do not specify this parameter, the default business space is used. You can get the key from the business management page of your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-yjzbyrEvqd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The intent definition.</para>
        /// </summary>
        [NameInMap("IntentDefinition")]
        [Validation(Required=false)]
        public CreateIntentRequestIntentDefinition IntentDefinition { get; set; }
        public class CreateIntentRequestIntentDefinition : TeaModel {
            /// <summary>
            /// <para>The intent alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>查天气意图</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The intent name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>查天气意图</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <para>An array of objects, each defining a slot for the intent.</para>
            /// </summary>
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateIntentRequestIntentDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateIntentRequestIntentDefinitionSlotInfos : TeaModel {
                /// <summary>
                /// <para>Specifies whether the slot can have multiple values.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                /// <summary>
                /// <para>Specifies whether to encrypt the slot value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Encrypt")]
                [Validation(Required=false)]
                public bool? Encrypt { get; set; }

                /// <summary>
                /// <para>Specifies whether the slot is interactive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Interactive")]
                [Validation(Required=false)]
                public bool? Interactive { get; set; }

                /// <summary>
                /// <para>The slot name.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>天气</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The slot ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fg452dfg3df23</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>The name of the associated entity.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>天气</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

    }

}
