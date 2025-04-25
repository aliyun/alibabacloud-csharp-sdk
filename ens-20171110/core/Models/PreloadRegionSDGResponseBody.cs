// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class PreloadRegionSDGResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data object.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public PreloadRegionSDGResponseBodyData Data { get; set; }
        public class PreloadRegionSDGResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The message returned.</para>
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
            public PreloadRegionSDGResponseBodyDataResult Result { get; set; }
            public class PreloadRegionSDGResponseBodyDataResult : TeaModel {
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
                public List<PreloadRegionSDGResponseBodyDataResultFailedItems> FailedItems { get; set; }
                public class PreloadRegionSDGResponseBodyDataResultFailedItems : TeaModel {
                    /// <summary>
                    /// <para>The ID of the destination node.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-xxx</para>
                    /// </summary>
                    [NameInMap("DestinationRegionId")]
                    [Validation(Required=false)]
                    public string DestinationRegionId { get; set; }

                    /// <summary>
                    /// <para>The error message that is returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>region not found</para>
                    /// </summary>
                    [NameInMap("ErrorMessage")]
                    [Validation(Required=false)]
                    public string ErrorMessage { get; set; }

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
        /// <para>C0003E8B-B930-4F59-ADC0-0E209A9012A8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
