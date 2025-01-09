// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class DescribeRCImageListResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<DescribeRCImageListResponseBodyImages> Images { get; set; }
        public class DescribeRCImageListResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The image architecture. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>x86_64</description></item>
            /// <item><description>arm64</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>x86_64</para>
            /// </summary>
            [NameInMap("Architecture")]
            [Validation(Required=false)]
            public string Architecture { get; set; }

            /// <summary>
            /// <para>The time when the image was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2024-04-25T02:17:40Z</para>
            /// </summary>
            [NameInMap("CreationTime")]
            [Validation(Required=false)]
            public string CreationTime { get; set; }

            /// <summary>
            /// <para>The description of the image.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>m-2oqiu973jwcxe****</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Created_from_i-2zeh17y17sz677x****</para>
            /// </summary>
            [NameInMap("ImageName")]
            [Validation(Required=false)]
            public string ImageName { get; set; }

            /// <summary>
            /// <para>The image version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            /// <summary>
            /// <para>Indicates whether the image is a public image. Public images include public images provided by Alibaba Cloud and custom images published as community images.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The image is a public image.</description></item>
            /// <item><description><b>false</b>: The image is not a public image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsPublic")]
            [Validation(Required=false)]
            public bool? IsPublic { get; set; }

            [NameInMap("IsSupportRdsCustom")]
            [Validation(Required=false)]
            public bool? IsSupportRdsCustom { get; set; }

            /// <summary>
            /// <para>The display name of the operating system in Chinese.</para>
            /// </summary>
            [NameInMap("OSName")]
            [Validation(Required=false)]
            public string OSName { get; set; }

            /// <summary>
            /// <para>The display name of the operating system in English.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Alibaba Cloud Linux  2.1903 LTS 64 bit Quick Boot</para>
            /// </summary>
            [NameInMap("OSNameEn")]
            [Validation(Required=false)]
            public string OSNameEn { get; set; }

            /// <summary>
            /// <para>The type of the operating system. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>windows</b></description></item>
            /// <item><description><b>linux</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>linux</para>
            /// </summary>
            [NameInMap("OSType")]
            [Validation(Required=false)]
            public string OSType { get; set; }

            [NameInMap("Platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The image size. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The image status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Unavailable</b></description></item>
            /// <item><description><b>Available</b></description></item>
            /// <item><description><b>Creating</b></description></item>
            /// <item><description><b>CreateFailed</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Available</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>Indicates whether the image is used by the RDS Custom instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>instance</b>: The image is used to create one or more RDS Custom instances.</description></item>
            /// <item><description><b>none</b>: The image is not used to create RDS Custom instances.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>instance</para>
            /// </summary>
            [NameInMap("Usage")]
            [Validation(Required=false)]
            public string Usage { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2553A660-E4EB-4AF4-A402-8AFF70A49143</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
