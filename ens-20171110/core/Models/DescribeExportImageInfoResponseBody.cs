// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeExportImageInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned result. For more information, see the Images parameter described in the JSON-formatted sample success response.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeExportImageInfoResponseBodyImages Images { get; set; }
        public class DescribeExportImageInfoResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeExportImageInfoResponseBodyImagesImage> Image { get; set; }
            public class DescribeExportImageInfoResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// <para>The architecture of the image. Example: <b>x86_64</b>.</para>
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
                /// <para>2017-12-08T12:10:03Z</para>
                /// </summary>
                [NameInMap("CreationTime")]
                [Validation(Required=false)]
                public string CreationTime { get; set; }

                /// <summary>
                /// <para>The URL of the exported image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://user_defined_bucket.oss-cn-beijing.aliyuncs.com/m-xxxxxxxxx1.qcow2">https://user_defined_bucket.oss-cn-beijing.aliyuncs.com/m-xxxxxxxxx1.qcow2</a></para>
                /// </summary>
                [NameInMap("ExportedImageURL")]
                [Validation(Required=false)]
                public string ExportedImageURL { get; set; }

                /// <summary>
                /// <para>The export status of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Exporting</description></item>
                /// <item><description>Exported</description></item>
                /// <item><description>ExportError</description></item>
                /// <item><description>Unexported</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Exported</para>
                /// </summary>
                [NameInMap("ImageExportStatus")]
                [Validation(Required=false)]
                public string ImageExportStatus { get; set; }

                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-xxxxxxxxx1</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-xxxxxxxxx1</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The source of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>system: public image</description></item>
                /// <item><description>self: custom image</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>system</para>
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// <para>The OS.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos</para>
                /// </summary>
                [NameInMap("Platform")]
                [Validation(Required=false)]
                public string Platform { get; set; }

            }

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
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>13</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
