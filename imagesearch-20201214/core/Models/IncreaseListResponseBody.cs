// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ImageSearch20201214.Models
{
    public class IncreaseListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the batch task.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public IncreaseListResponseBodyData Data { get; set; }
        public class IncreaseListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>A list of batch tasks.</para>
            /// </summary>
            [NameInMap("Increments")]
            [Validation(Required=false)]
            public IncreaseListResponseBodyDataIncrements Increments { get; set; }
            public class IncreaseListResponseBodyDataIncrements : TeaModel {
                [NameInMap("Instance")]
                [Validation(Required=false)]
                public List<IncreaseListResponseBodyDataIncrementsInstance> Instance { get; set; }
                public class IncreaseListResponseBodyDataIncrementsInstance : TeaModel {
                    /// <summary>
                    /// <para>The name of the Object Storage Service (OSS) bucket.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>bucketName</para>
                    /// </summary>
                    [NameInMap("BucketName")]
                    [Validation(Required=false)]
                    public string BucketName { get; set; }

                    /// <summary>
                    /// <para>The callback address.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="http://xxxxx">http://xxxxx</a></para>
                    /// </summary>
                    [NameInMap("CallbackAddress")]
                    [Validation(Required=false)]
                    public string CallbackAddress { get; set; }

                    /// <summary>
                    /// <para>The error code returned.</para>
                    /// <list type="bullet">
                    /// <item><description>A value of 0 indicates that the operation is successful.</description></item>
                    /// <item><description>Values other than 0 indicate errors.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                    /// <summary>
                    /// <para>The address where you can download the result. The address is valid for 2 hours.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para><a href="https://imagesearchname.oss-cn-shanghai.aliyuncs.com/xxx">https://imagesearchname.oss-cn-shanghai.aliyuncs.com/xxx</a></para>
                    /// </summary>
                    [NameInMap("ErrorUrl")]
                    [Validation(Required=false)]
                    public string ErrorUrl { get; set; }

                    /// <summary>
                    /// <para>The ID of the task.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>500</para>
                    /// </summary>
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    /// <summary>
                    /// <para>The error message returned.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sucess</para>
                    /// </summary>
                    [NameInMap("Msg")]
                    [Validation(Required=false)]
                    public string Msg { get; set; }

                    /// <summary>
                    /// <para>The absolute path to the increment.meta file in the bucket. The path must start with a forward slash (/) and cannot end with a forward slash (/).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>/xx/xx</para>
                    /// </summary>
                    [NameInMap("Path")]
                    [Validation(Required=false)]
                    public string Path { get; set; }

                    /// <summary>
                    /// <para>The status of the batch task.</para>
                    /// <list type="bullet">
                    /// <item><description>PROCESSING: in progress</description></item>
                    /// <item><description>FAIL: failed</description></item>
                    /// <item><description>SUCCESS: successful</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>SUCCESS</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The time when the task was created. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1629095713000</para>
                    /// </summary>
                    [NameInMap("UtcCreate")]
                    [Validation(Required=false)]
                    public string UtcCreate { get; set; }

                    /// <summary>
                    /// <para>The time when the task was updated. Unit: milliseconds.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1629095760000</para>
                    /// </summary>
                    [NameInMap("UtcModified")]
                    [Validation(Required=false)]
                    public long? UtcModified { get; set; }

                }

            }

            /// <summary>
            /// <para>The number of the page to return.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// <para>The number of entries to return on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of tasks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B3137727-7D6E-488C-BA21-0E034C38A879</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
