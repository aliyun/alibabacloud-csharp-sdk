// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DeployInstanceSDGResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned Data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DeployInstanceSDGResponseBodyData Data { get; set; }
        public class DeployInstanceSDGResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The response message. The value success is returned if the request is successful.</para>
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
            public DeployInstanceSDGResponseBodyDataResult Result { get; set; }
            public class DeployInstanceSDGResponseBodyDataResult : TeaModel {
                /// <summary>
                /// <para>The number of failures.</para>
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
                public List<DeployInstanceSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class DeployInstanceSDGResponseBodyDataResultFailedItems : TeaModel {
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
                    /// <para>The instance ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aic-xxxxx-0</para>
                    /// </summary>
                    [NameInMap("InstanceId")]
                    [Validation(Required=false)]
                    public string InstanceId { get; set; }

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
            /// <para>Indicates whether all requests are successful. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>true: All requests are successful.</description></item>
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
