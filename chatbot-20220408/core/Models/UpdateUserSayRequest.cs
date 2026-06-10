// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Chatbot20220408.Models
{
    public class UpdateUserSayRequest : TeaModel {
        /// <summary>
        /// <para>The workspace key. If you omit this parameter, the default workspace is used. You can find this key on the Workspace Management page in your main account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac627989eb4f8a98ed05fd098bbae5_p_beebot_public</para>
        /// </summary>
        [NameInMap("AgentKey")]
        [Validation(Required=false)]
        public string AgentKey { get; set; }

        /// <summary>
        /// <para>The ID of the bot.</para>
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
        public UpdateUserSayRequestUserSayDefinition UserSayDefinition { get; set; }
        public class UpdateUserSayRequestUserSayDefinition : TeaModel {
            /// <summary>
            /// <para>The content of the user say.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>做核酸了吗您</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The ID of the intent.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public long? IntentId { get; set; }

            /// <summary>
            /// <para>An array that contains information for each slot.</para>
            /// </summary>
            [NameInMap("SlotInfos")]
            [Validation(Required=false)]
            public List<UpdateUserSayRequestUserSayDefinitionSlotInfos> SlotInfos { get; set; }
            public class UpdateUserSayRequestUserSayDefinitionSlotInfos : TeaModel {
                /// <summary>
                /// <para>The zero-based end index (exclusive) of the slot within the content of the user say.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("EndIndex")]
                [Validation(Required=false)]
                public int? EndIndex { get; set; }

                /// <summary>
                /// <para>The ID of the slot.</para>
                /// 
                /// <b>Example:</b>
                /// <para>346ffg3q23dv</para>
                /// </summary>
                [NameInMap("SlotId")]
                [Validation(Required=false)]
                public string SlotId { get; set; }

                /// <summary>
                /// <para>The zero-based start index of the slot within the content of the user say.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("StartIndex")]
                [Validation(Required=false)]
                public int? StartIndex { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the user say.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>34512323</para>
        /// </summary>
        [NameInMap("UserSayId")]
        [Validation(Required=false)]
        public long? UserSayId { get; set; }

    }

}
