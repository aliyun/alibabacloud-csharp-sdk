// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned service code. 0 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The details of the images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodyImages Images { get; set; }
        public class DescribeAvailableResourceResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodyImagesImage> Image { get; set; }
            public class DescribeAvailableResourceResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_alibase_20171208</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_alibase_****</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request. This is a common parameter. Each request has a unique ID. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The specifications of resources that you can purchase.</para>
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceResponseBodySupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// <para>The size of the data disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>500</para>
                /// </summary>
                [NameInMap("DataDiskSize")]
                [Validation(Required=false)]
                public string DataDiskSize { get; set; }

                /// <summary>
                /// <para>The ID of the edge node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-cmcc</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The specifications of the resource plan.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ens.sn1.stiny</para>
                /// </summary>
                [NameInMap("InstanceSpec")]
                [Validation(Required=false)]
                public string InstanceSpec { get; set; }

                /// <summary>
                /// <para>The number of resources that you can purchase.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9</para>
                /// </summary>
                [NameInMap("SupportResourcesCount")]
                [Validation(Required=false)]
                public string SupportResourcesCount { get; set; }

                /// <summary>
                /// <para>The size of the system disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("SystemDiskSize")]
                [Validation(Required=false)]
                public string SystemDiskSize { get; set; }

            }

        }

    }

}
