// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeleteSDGResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeleteSDGResponseBodyData Data { get; set; }
        public class DeleteSDGResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response message. Success is returned for a successful request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The execution result of the synchronization request.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public DeleteSDGResponseBodyDataResult Result { get; set; }
            public class DeleteSDGResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The number of failed tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <para>Details about the failed tasks.</para>
                /// </summary>
                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<DeleteSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class DeleteSDGResponseBodyDataResultFailedItems : TeaModel {
                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sdg not found</para>
                    /// </summary>
                    [NameInMap("ErrMessage")]
                    [Validation(Required=false)]
                    public string ErrMessage { get; set; }

                    /// <summary>
                    /// <para>Description</para>
                    /// </summary>
                    [NameInMap("Item")]
                    [Validation(Required=false)]
                    public DeleteSDGResponseBodyDataResultFailedItemsItem Item { get; set; }
                    public class DeleteSDGResponseBodyDataResultFailedItemsItem : TeaModel {
                        /// <summary>
                        /// <para>The ID of the shared data group (SDG).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>sdg-dfet5vvvgy</para>
                        /// </summary>
                        [NameInMap("SdgId")]
                        [Validation(Required=false)]
                        public string SdgId { get; set; }

                    }

                }

                /// <summary>
                /// <para>The number of successful tasks.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether all tasks are successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: All tasks are successful.</description></item>
            /// <item><description>false: Failed tasks exist.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Success")]
            [Validation(Required=false)]
            public bool? Success { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>86A6D421-A0C7-4C01-8648-47377CA6A2CE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
