// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeImageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The objects that are returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeImageListResponseBodyData> Data { get; set; }
        public class DescribeImageListResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>117819727354****</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>description</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-01 10:56:36</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// <para>The time when the image was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-02-01 10:56:36</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// <para>The ID of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>imgc-075cllfeuazh****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The name of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>IMAGE</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The region where the image is distributed. The key is the region and the value is the distribution information.</para>
            /// </summary>
            [NameInMap("ImageRegionDistributeMap")]
            [Validation(Required=false)]
            public Dictionary<string, DataImageRegionDistributeMapValue> ImageRegionDistributeMap { get; set; }

            /// <summary>
            /// <para>The list of regions.</para>
            /// </summary>
            [NameInMap("ImageRegionList")]
            [Validation(Required=false)]
            public List<string> ImageRegionList { get; set; }

            /// <summary>
            /// <para>The type of the image.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>User: custom images.</description></item>
            /// <item><description>System: system images.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>System</para>
            /// </summary>
            [NameInMap("ImageType")]
            [Validation(Required=false)]
            public string ImageType { get; set; }

            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>The language of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>zh</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The time when the image was published.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-07-25 10:06:45</para>
            /// </summary>
            [NameInMap("ReleaseTime")]
            [Validation(Required=false)]
            public string ReleaseTime { get; set; }

            /// <summary>
            /// <para>The rendering type.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GPURemote</description></item>
            /// <item><description>CPU</description></item>
            /// <item><description>GPULocal</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>CPU</para>
            /// </summary>
            [NameInMap("RenderingType")]
            [Validation(Required=false)]
            public string RenderingType { get; set; }

            /// <summary>
            /// <para>The state of the image.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>AVAILABLE: The image is available.</description></item>
            /// <item><description>DELETE: The image is deleted.</description></item>
            /// <item><description>INIT: The image is being initialized.</description></item>
            /// <item><description>CREATE_FAILED: The image failed to be created.</description></item>
            /// <item><description>CREATING: The image is being created.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The OS type of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Android 12</para>
            /// </summary>
            [NameInMap("SystemType")]
            [Validation(Required=false)]
            public string SystemType { get; set; }

        }

        /// <summary>
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAV3MpHK1AP0pfERHZN5pu6l5V9uON****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>620740FF-492F-5956-B1BA-361E966C0269</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
