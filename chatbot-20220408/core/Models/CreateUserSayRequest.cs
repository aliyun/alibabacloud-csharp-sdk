// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class CreateUserSayRequest : TeaModel {
        /// <summary>
        /// <para>The key of the business space. If you do not specify this parameter, the default business space is used. You can find the key on the Business Management page of your Alibaba Cloud account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The ID of the chatbot instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>chatbot-cn-yjzbyrEvqd</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The definition of the user say.</para>
        /// </summary>
        [NameInMap("UserSayDefinition")]
        [Validation(Required=false)]
        public CreateUserSayRequestUserSayDefinition UserSayDefinition { get; set; }
        public class CreateUserSayRequestUserSayDefinition : TeaModel {
            /// <summary>
            /// <para>The content of the user say.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>请问明天北京的天气</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the intent.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123232</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>An array of objects, each containing information about a slot.</para>
            /// </summary>
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<CreateUserSayRequestUserSayDefinitionSlotInfos> SlotInfos { get; set; }
            public class CreateUserSayRequestUserSayDefinitionSlotInfos : TeaModel {
                /// <summary>
                /// <para>The zero-based end index of the slot in the user say content. This index is exclusive.</para>
                /// 
                /// <b>Example:</b>
                /// <para>6</para>
                /// </summary>
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                /// <summary>
                /// <para>The ID of the slot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>fb34adf2fv43f2</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>The zero-based start index of the slot in the user say content.</para>
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
