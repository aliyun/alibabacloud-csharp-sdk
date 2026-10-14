// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CopySDGResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned Data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public CopySDGResponseBodyData Data { get; set; }
        public class CopySDGResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response message. The value success indicates a successful request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>success</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The execution result of the synchronous request.</para>
            /// </summary>
            [NameInMap("Result")]
            [Validation(Required=false)]
            public CopySDGResponseBodyDataResult Result { get; set; }
            public class CopySDGResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The number of failed edge zones.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <para>The list of failed edge zone details.</para>
                /// </summary>
                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<CopySDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class CopySDGResponseBodyDataResultFailedItems : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination edge zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-xxx</para>
                    /// </summary>
                    [NameInMap("DestinationRegionId")]
                    [Validation(Required=false)]
                    public string DestinationRegionId { get; set; }

                    /// <summary>
                    /// <para>The error message.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region not found</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

                }

                /// <summary>
                /// <para>The number of successful operations.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("SuccessCount")]
                [Validation(Required=false)]
                public long? SuccessCount { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether all requests were successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: All requests were successful.</description></item>
            /// <item><description><b>false</b>: Some tasks failed.</description></item>
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
        /// <para>XXX-XXX-XXX</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
