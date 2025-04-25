// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeImageModifiedRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>Details about the image modification record.</para>
        /// </summary>
        [NameInMap("ImageModifiedRecords")]
        [Validation(Required=false)]
        public List<DescribeImageModifiedRecordsResponseBodyImageModifiedRecords> ImageModifiedRecords { get; set; }
        public class DescribeImageModifiedRecordsResponseBodyImageModifiedRecords : TeaModel {
            /// <summary>
            /// <para>The ID of the original image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-8rnz2imrpcfuh****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the original image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>win10-0307</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The ID of the new image after the image was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxNewImageID</para>
            /// </summary>
            [NameInMap("NewImageId")]
            [Validation(Required=false)]
            public string NewImageId { get; set; }

            /// <summary>
            /// <para>The name of the new image after the image was modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxImageID</para>
            /// </summary>
            [NameInMap("NewImageName")]
            [Validation(Required=false)]
            public string NewImageName { get; set; }

            [NameInMap("Reason")]
            [Validation(Required=false)]
            public string Reason { get; set; }

            /// <summary>
            /// <para>The status of the image modification.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>0: The image is being modified.</para>
            /// </description></item>
            /// <item><description><para>1: The image is successfully modified.</para>
            /// </description></item>
            /// <item><description><para>2: The image fails to be modified.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The time when the image was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-03-03T02:43:44.851Z</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public string UpdateTime { get; set; }

        }

        /// <summary>
        /// <para>If the NextToken parameter is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6koN7RqHg3d2z8LKmSoe821</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC40EE61-7E83-59ED-AEA6-7EE9C437F352</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of image modification records.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
