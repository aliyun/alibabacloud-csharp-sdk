// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateIntentRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If this parameter is not specified, the default business space is accessed. You can obtain the key value on the business management page of the Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The chatbot ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-yjzbyrEvqd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The intent definition struct.</para>
        /// </summary>
        [NameInMap("IntentDefinition")]
        [Validation(Required=false)]
        public UpdateIntentRequestIntentDefinition IntentDefinition { get; set; }
        public class UpdateIntentRequestIntentDefinition : TeaModel {
            /// <summary>
            /// <para>The intent alias.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CheckWeatherIntent</para>
            /// </summary>
            [NameInMap("AliasName")]
            [Validation(Required=false)]
            public string AliasName { get; set; }

            /// <summary>
            /// <para>The intent name.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CheckWeatherIntent</para>
            /// </summary>
            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            /// <summary>
            /// <para>The slot information.</para>
            /// </summary>
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<UpdateIntentRequestIntentDefinitionSlotInfos> SlotInfos { get; set; }
            public class UpdateIntentRequestIntentDefinitionSlotInfos : TeaModel {
                /// <summary>
                /// <para>Specifies whether the slot is an array.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Array")]
                [Validation(Required=false)]
                public bool? Array { get; set; }

                /// <summary>
                /// <para>Specifies whether the slot value is masked.</para>
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
                /// <para>Weather</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The slot ID.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>dgadf23dfg2f</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>The name of the associated entity.</para>
                /// <para>This parameter is required.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Weather</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// <para>The intent ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>234234234534</para>
        /// </summary>
        [NameInMap("IntentId")]
        [Validation(Required=false)]
        public long? IntentId { get; set; }

    }

}
