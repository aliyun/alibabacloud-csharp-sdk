// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateUserSayRequest : TeaModel {
        /// <summary>
        /// <para>The business space key. If not specified, the default business space is accessed. You can obtain the key value from the business management page of the Alibaba Cloud account.</para>
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
        /// <para>The user utterance definition information.</para>
        /// </summary>
        [NameInMap("UserSayDefinition")]
        [Validation(Required=false)]
        public CreateUserSayRequestUserSayDefinition UserSayDefinition { get; set; }
        public class CreateUserSayRequestUserSayDefinition : TeaModel {
            /// <summary>
            /// <para>The user utterance.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>What is the weather in Beijing tomorrow?</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The intent ID.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123232</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>The slot information.</para>
            /// </summary>
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateUserSayRequestUserSayDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateUserSayRequestUserSayDefinitionSlotInfos : TeaModel {
                /// <summary>
                /// <para>The end index of the slot in the intent utterance (exclusive).</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                /// <summary>
                /// <para>The slot ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb34adf2fv43f2</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>The start index of the slot in the intent utterance.</para>
                /// 
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
