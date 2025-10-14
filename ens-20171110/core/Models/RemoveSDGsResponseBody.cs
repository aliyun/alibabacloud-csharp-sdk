// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class RemoveSDGsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RemoveSDGsResponseBodyData Data { get; set; }
        public class RemoveSDGsResponseBodyData : TeaModel {
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
            public RemoveSDGsResponseBodyDataResult Result { get; set; }
            public class RemoveSDGsResponseBodyDataResult : TeaModel {
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
                /// <para>Details about failed tasks.</para>
                /// </summary>
                [NameInMap("FailedItems")]
                [Validation(Required=false)]
                public List<RemoveSDGsResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class RemoveSDGsResponseBodyDataResultFailedItems : TeaModel {
                    /// <summary>
                    /// <para>The error message returned if the call failed.</para>
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
            /// <item><description><b>true</b>: All tasks are successful.</description></item>
            /// <item><description><b>false</b>: Failed tasks exist.</description></item>
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
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>903819D9-D18B-5C59-8DFD-20D56FD2DAE4</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
