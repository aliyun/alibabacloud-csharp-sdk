// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ShoppingAssistantRequest : TeaModel {
        /// <summary>
        /// <para>The additional configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The contents.</para>
        /// </summary>
        [NameInMap("Contents")]
        [Validation(Required=false)]
        public ShoppingAssistantRequestContents Contents { get; set; }
        public class ShoppingAssistantRequestContents : TeaModel {
            /// <summary>
            /// <para>The message content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Recommend some light-colored long-sleeve shirts suitable for spring, budget under 300</para>
            /// </summary>
            [NameInMap("Text")]
            [Validation(Required=false)]
            public string Text { get; set; }

            /// <summary>
            /// <para>The message type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>text</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The conversation ID. This parameter is not yet effective.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e47cfae9-c0cc-42e1-91e2-e67cdb0e7b96</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para><b>The environment.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>Prod: productionPre: pre-release.</para>
        /// </summary>
        [NameInMap("Environment")]
        [Validation(Required=false)]
        public string Environment { get; set; }

        /// <summary>
        /// <para>The input message.</para>
        /// </summary>
        [NameInMap("InputMessage")]
        [Validation(Required=false)]
        public ShoppingAssistantRequestInputMessage InputMessage { get; set; }
        public class ShoppingAssistantRequestInputMessage : TeaModel {
            /// <summary>
            /// <para>The message content.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public List<ShoppingAssistantRequestInputMessageContent> Content { get; set; }
            public class ShoppingAssistantRequestInputMessageContent : TeaModel {
                /// <summary>
                /// <para>The message content.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Recommend some light-colored long-sleeve shirts suitable for spring, budget under 300</para>
                /// </summary>
                [NameInMap("Text")]
                [Validation(Required=false)]
                public string Text { get; set; }

                /// <summary>
                /// <para>The message type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>text</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para><b>The instance ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>learn-pairec-xxx</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh/en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para><b>The scene ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>ai_shopping</para>
        /// </summary>
        [NameInMap("SceneId")]
        [Validation(Required=false)]
        public string SceneId { get; set; }

        /// <summary>
        /// <para><b>The service ID.</b></para>
        /// 
        /// <b>Example:</b>
        /// <para>ServiceId.</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e47cfae9-c0cc-42e1-91e2-e67cdb0e7b96</para>
        /// </summary>
        [NameInMap("SessionId")]
        [Validation(Required=false)]
        public string SessionId { get; set; }

        /// <summary>
        /// <para>user id。</para>
        /// 
        /// <b>Example:</b>
        /// <para>0001</para>
        /// </summary>
        [NameInMap("Uid")]
        [Validation(Required=false)]
        public string Uid { get; set; }

    }

}
