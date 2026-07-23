// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ShoppingAssistantResponseBody : TeaModel {
        /// <summary>
        /// <para>The citation information.</para>
        /// </summary>
        [NameInMap("Citation")]
        [Validation(Required=false)]
        public ShoppingAssistantResponseBodyCitation Citation { get; set; }
        public class ShoppingAssistantResponseBodyCitation : TeaModel {
            /// <summary>
            /// <para>The ID of the <c>item</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0005</para>
            /// </summary>
            [NameInMap("ItemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>The reference data type. Fixed value: <c>item</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The returned content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Here are some light-colored long-sleeve shirts I picked for you:\n.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The session ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e47cfae9-c0cc-42e1-91e2-e67cdb0e7b96</para>
        /// </summary>
        [NameInMap("ConversationId")]
        [Validation(Required=false)]
        public string ConversationId { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The event.</para>
        /// 
        /// <b>Example:</b>
        /// <para>analyze_requirement</para>
        /// </summary>
        [NameInMap("Event")]
        [Validation(Required=false)]
        public string Event { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>728C5E01-ABF6-5AA8-B9FC-B3BA05DECC77</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result details.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public ShoppingAssistantResponseBodyResult Result { get; set; }
        public class ShoppingAssistantResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The citation information.</para>
            /// </summary>
            [NameInMap("Citation")]
            [Validation(Required=false)]
            public ShoppingAssistantResponseBodyResultCitation Citation { get; set; }
            public class ShoppingAssistantResponseBodyResultCitation : TeaModel {
                /// <summary>
                /// <para>The ID of the item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>48</para>
                /// </summary>
                [NameInMap("ItemId")]
                [Validation(Required=false)]
                public string ItemId { get; set; }

                /// <summary>
                /// <para>The reference data type. Fixed value: item.</para>
                /// 
                /// <b>Example:</b>
                /// <para>item</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// <para>The returned content.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Here are some light-colored long-sleeve shirts I picked for you:\\n.</para>
            /// </summary>
            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            /// <summary>
            /// <para>The error message.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Success</para>
            /// </summary>
            [NameInMap("ErrorCode")]
            [Validation(Required=false)]
            public string ErrorCode { get; set; }

            /// <summary>
            /// <para>The step information.</para>
            /// </summary>
            [NameInMap("StepInfo")]
            [Validation(Required=false)]
            public ShoppingAssistantResponseBodyResultStepInfo StepInfo { get; set; }
            public class ShoppingAssistantResponseBodyResultStepInfo : TeaModel {
                /// <summary>
                /// <para>The step.</para>
                /// 
                /// <b>Example:</b>
                /// <para>analyze_requirement</para>
                /// </summary>
                [NameInMap("Step")]
                [Validation(Required=false)]
                public string Step { get; set; }

            }

            /// <summary>
            /// <para>The stop reason.</para>
            /// 
            /// <b>Example:</b>
            /// <para>stop</para>
            /// </summary>
            [NameInMap("StopReason")]
            [Validation(Required=false)]
            public string StopReason { get; set; }

        }

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
        /// <para>The stop reason.</para>
        /// 
        /// <b>Example:</b>
        /// <para>stop</para>
        /// </summary>
        [NameInMap("StopReason")]
        [Validation(Required=false)]
        public string StopReason { get; set; }

    }

}
