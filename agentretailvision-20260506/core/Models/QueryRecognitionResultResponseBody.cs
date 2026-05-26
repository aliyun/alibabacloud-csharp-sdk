// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AgentRetailVision20260506.Models
{
    public class QueryRecognitionResultResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public QueryRecognitionResultResponseBodyData Data { get; set; }
        public class QueryRecognitionResultResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ORDER_001</para>
            /// </summary>
            [NameInMap("OrderUniqueId")]
            [Validation(Required=false)]
            public string OrderUniqueId { get; set; }

            [NameInMap("Result")]
            [Validation(Required=false)]
            public QueryRecognitionResultResponseBodyDataResult Result { get; set; }
            public class QueryRecognitionResultResponseBodyDataResult : TeaModel {
                [NameInMap("CheckoutInfo")]
                [Validation(Required=false)]
                public QueryRecognitionResultResponseBodyDataResultCheckoutInfo CheckoutInfo { get; set; }
                public class QueryRecognitionResultResponseBodyDataResultCheckoutInfo : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>TRUSTED</para>
                    /// </summary>
                    [NameInMap("CheckoutStatus")]
                    [Validation(Required=false)]
                    public string CheckoutStatus { get; set; }

                }

                [NameInMap("Items")]
                [Validation(Required=false)]
                public List<QueryRecognitionResultResponseBodyDataResultItems> Items { get; set; }
                public class QueryRecognitionResultResponseBodyDataResultItems : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>690234524880781</para>
                    /// </summary>
                    [NameInMap("ItemUniqueId")]
                    [Validation(Required=false)]
                    public string ItemUniqueId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>535c3daaee3b4b5382db4913413419bc2d</para>
                    /// </summary>
                    [NameInMap("PlatformItemId")]
                    [Validation(Required=false)]
                    public string PlatformItemId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Quantity")]
                    [Validation(Required=false)]
                    public int? Quantity { get; set; }

                }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>TASK_001</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public string TaskId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>COMPLETED</para>
            /// </summary>
            [NameInMap("TaskStatus")]
            [Validation(Required=false)]
            public string TaskStatus { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>E1AD60F1-BAC7-546B-9533-E7AD02B16E3F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
