// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class DescribeEstackImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The array of base images.</para>
        /// </summary>
        [NameInMap("ImageList")]
        [Validation(Required=false)]
        public DescribeEstackImageResponseBodyImageList ImageList { get; set; }
        public class DescribeEstackImageResponseBodyImageList : TeaModel {
            [NameInMap("ImageListInfo")]
            [Validation(Required=false)]
            public List<DescribeEstackImageResponseBodyImageListImageListInfo> ImageListInfo { get; set; }
            public class DescribeEstackImageResponseBodyImageListImageListInfo : TeaModel {
                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>tensorflow-21.09-tf1-py3.sif</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The size of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>65535 GiB</para>
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public int? ImageSize { get; set; }

                /// <summary>
                /// <para>The type of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>singularity</para>
                /// </summary>
                [NameInMap("ImageType")]
                [Validation(Required=false)]
                public string ImageType { get; set; }

                /// <summary>
                /// <para>The download URL of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://xxxx.oss-cn-hangzhou.aliyuncs.com/eStackPackage/singularity/tensorflow-21.09-tf1-py3.sif">http://xxxx.oss-cn-hangzhou.aliyuncs.com/eStackPackage/singularity/tensorflow-21.09-tf1-py3.sif</a></para>
                /// </summary>
                [NameInMap("ImageUrl")]
                [Validation(Required=false)]
                public string ImageUrl { get; set; }

                /// <summary>
                /// <para>The time when the image was last modified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-05-05T07:10:55.000Z</para>
                /// </summary>
                [NameInMap("RecentUpdateTime")]
                [Validation(Required=false)]
                public string RecentUpdateTime { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number returned.</para>
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
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2D69A58F-345C-4FDE-88E4-BF518948xxxx</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
