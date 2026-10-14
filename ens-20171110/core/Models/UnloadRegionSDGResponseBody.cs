// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class UnloadRegionSDGResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned Data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public UnloadRegionSDGResponseBodyData Data { get; set; }
        public class UnloadRegionSDGResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response message. A value of success indicates a successful request.</para>
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
            public UnloadRegionSDGResponseBodyDataResult Result { get; set; }
            public class UnloadRegionSDGResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The total number of failed requests.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("FailedCount")]
                [Validation(Required=false)]
                public long? FailedCount { get; set; }

                /// <summary>
                /// <para>The list of failure details.</para>
                /// </summary>
                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<UnloadRegionSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class UnloadRegionSDGResponseBodyDataResultFailedItems : TeaModel {
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
                /// <para>The number of successes.</para>
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
            /// <item><description>true: All requests were successful.</description></item>
            /// <item><description>false: Some requests failed.</description></item>
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
        /// <para>125B04C7-3D0D-4245-AF96-14E3758E3F06</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
