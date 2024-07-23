// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaTasksResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned message. If the request was successful, a <c>success</c> is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Details about the image update task.</para>
        /// </summary>
        [NameInMap("FotaTasks")]
        [Validation(Required=false)]
        public List<DescribeFotaTasksResponseBodyFotaTasks> FotaTasks { get; set; }
        public class DescribeFotaTasksResponseBodyFotaTasks : TeaModel {
            /// <summary>
            /// <para>The image version. You can call the <a href="https://help.aliyun.com/document_detail/188895.html">DescribeImages</a> operation to obtain the value of this parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.0.1-D-20220513.143129</para>
            /// </summary>
            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            /// <summary>
            /// <remarks>
            /// <para> This parameter is not publicly available.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>To be hidden.</para>
            /// </summary>
            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            /// <summary>
            /// <para>The number of custom images that can be updated to this version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PendingCustomImageCount")]
            [Validation(Required=false)]
            public int? PendingCustomImageCount { get; set; }

            /// <summary>
            /// <para>The number of cloud computers whose images can be updated to this version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PendingDesktopCount")]
            [Validation(Required=false)]
            public int? PendingDesktopCount { get; set; }

            /// <summary>
            /// <para>The time when the image version available for update was published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-05-31T04:28:48Z</para>
            /// </summary>
            [NameInMap("PublishTime")]
            [Validation(Required=false)]
            public string PublishTime { get; set; }

            /// <summary>
            /// <para>The description of the image version available for update.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("ReleaseNote")]
            [Validation(Required=false)]
            public string ReleaseNote { get; set; }

            /// <summary>
            /// <para>The size of the update package. Unit: KB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>568533470</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>Indicates whether the image update task is automatically pushed.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Running: automatically pushes the image update task.</description></item>
            /// <item><description>Pending: does not automatically push the image update task.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>valid</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The ID of the image upgrade task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>aot-c4khwrp9ocml4****</para>
            /// </summary>
            [NameInMap("TaskUid")]
            [Validation(Required=false)]
            public string TaskUid { get; set; }

        }

        /// <summary>
        /// <para>The returned error message. This parameter is not returned if the Code value is a <c>success</c> message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6nmB7qrRFJ8vmttjxPL****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
