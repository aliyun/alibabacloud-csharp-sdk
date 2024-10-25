// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeAvailableResourceInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the image.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeAvailableResourceInfoResponseBodyImages Images { get; set; }
        public class DescribeAvailableResourceInfoResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceInfoResponseBodyImagesImage> Image { get; set; }
            public class DescribeAvailableResourceInfoResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_a****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_a****</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The size of the image. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("ImageSize")]
                [Validation(Required=false)]
                public int? ImageSize { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8629F679-B51D-4194-A1CC-5D8F504C362B</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The specifications of resources that you can purchase.</para>
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeAvailableResourceInfoResponseBodySupportResources SupportResources { get; set; }
        public class DescribeAvailableResourceInfoResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// <para>Bandwidth billing method.</para>
                /// </summary>
                [NameInMap("BandwidthTypes")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceBandwidthTypes BandwidthTypes { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceBandwidthTypes : TeaModel {
                    [NameInMap("BandwidthType")]
                    [Validation(Required=false)]
                    public List<string> BandwidthType { get; set; }

                }

                /// <summary>
                /// <para>The maximum capacity of a data disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>200</para>
                /// </summary>
                [NameInMap("DataDiskMaxSize")]
                [Validation(Required=false)]
                public int? DataDiskMaxSize { get; set; }

                /// <summary>
                /// <para>The minimum data disk size. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("DataDiskMinSize")]
                [Validation(Required=false)]
                public int? DataDiskMinSize { get; set; }

                /// <summary>
                /// <para>node ID</para>
                /// </summary>
                [NameInMap("EnsRegionIds")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIds EnsRegionIds { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIds : TeaModel {
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=false)]
                    public List<string> EnsRegionId { get; set; }

                }

                /// <summary>
                /// <para>The supplementary information about the edge nodes.</para>
                /// </summary>
                [NameInMap("EnsRegionIdsExtends")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtends EnsRegionIdsExtends { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtends : TeaModel {
                    [NameInMap("EnsRegionId")]
                    [Validation(Required=false)]
                    public List<DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId> EnsRegionId { get; set; }
                    public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceEnsRegionIdsExtendsEnsRegionId : TeaModel {
                        /// <summary>
                        /// <para>The region.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EastChina</para>
                        /// </summary>
                        [NameInMap("Area")]
                        [Validation(Required=false)]
                        public string Area { get; set; }

                        /// <summary>
                        /// <para>The name. This parameter is empty by default.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>EnName</para>
                        /// </summary>
                        [NameInMap("EnName")]
                        [Validation(Required=false)]
                        public string EnName { get; set; }

                        /// <summary>
                        /// <para>The ID of the edge node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>cn-chengdu-telecom-4</para>
                        /// </summary>
                        [NameInMap("EnsRegionId")]
                        [Validation(Required=false)]
                        public string EnsRegionId { get; set; }

                        /// <summary>
                        /// <para>The information about the Internet service provider (ISP).</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>unicom</para>
                        /// </summary>
                        [NameInMap("Isp")]
                        [Validation(Required=false)]
                        public string Isp { get; set; }

                        /// <summary>
                        /// <para>The name of the edge node.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Taizhou Telecom, China Unicom, and China Mobile</para>
                        /// </summary>
                        [NameInMap("Name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        /// <summary>
                        /// <para>The province.</para>
                        /// 
                        /// <b>Example:</b>
                        /// <para>Zhejiang Province</para>
                        /// </summary>
                        [NameInMap("Province")]
                        [Validation(Required=false)]
                        public string Province { get; set; }

                    }

                }

                [NameInMap("InstanceSpeces")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceInstanceSpeces InstanceSpeces { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceInstanceSpeces : TeaModel {
                    [NameInMap("InstanceSpec")]
                    [Validation(Required=false)]
                    public List<string> InstanceSpec { get; set; }

                }

                /// <summary>
                /// <para>Operator</para>
                /// </summary>
                [NameInMap("Isp")]
                [Validation(Required=false)]
                public DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceIsp Isp { get; set; }
                public class DescribeAvailableResourceInfoResponseBodySupportResourcesSupportResourceIsp : TeaModel {
                    [NameInMap("Isp")]
                    [Validation(Required=false)]
                    public List<string> Isp { get; set; }

                }

                /// <summary>
                /// <para>The maximum size of the system disk. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("SystemDiskMaxSize")]
                [Validation(Required=false)]
                public int? SystemDiskMaxSize { get; set; }

                /// <summary>
                /// <para>The minimum capacity of a system disk. Unit: GB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>20</para>
                /// </summary>
                [NameInMap("SystemDiskMinSize")]
                [Validation(Required=false)]
                public int? SystemDiskMinSize { get; set; }

            }

        }

    }

}
