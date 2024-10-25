// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class DescribeReservedResourceResponseBody : TeaModel {
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
        /// <para>The information about the image.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public DescribeReservedResourceResponseBodyImages Images { get; set; }
        public class DescribeReservedResourceResponseBodyImages : TeaModel {
            [NameInMap("Image")]
            [Validation(Required=false)]
            public List<DescribeReservedResourceResponseBodyImagesImage> Image { get; set; }
            public class DescribeReservedResourceResponseBodyImagesImage : TeaModel {
                /// <summary>
                /// <para>The ID of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>centos_6_08_64_20G_alibase_****</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6666C5A5-75ED-422E-A022-7121FA18C968</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The resources.</para>
        /// </summary>
        [NameInMap("SupportResources")]
        [Validation(Required=false)]
        public DescribeReservedResourceResponseBodySupportResources SupportResources { get; set; }
        public class DescribeReservedResourceResponseBodySupportResources : TeaModel {
            [NameInMap("SupportResource")]
            [Validation(Required=false)]
            public List<DescribeReservedResourceResponseBodySupportResourcesSupportResource> SupportResource { get; set; }
            public class DescribeReservedResourceResponseBodySupportResourcesSupportResource : TeaModel {
                /// <summary>
                /// <para>The sizes of data disks.</para>
                /// </summary>
                [NameInMap("DataDiskSizes")]
                [Validation(Required=false)]
                public DescribeReservedResourceResponseBodySupportResourcesSupportResourceDataDiskSizes DataDiskSizes { get; set; }
                public class DescribeReservedResourceResponseBodySupportResourcesSupportResourceDataDiskSizes : TeaModel {
                    [NameInMap("DataDiskSize")]
                    [Validation(Required=false)]
                    public List<string> DataDiskSize { get; set; }

                }

                /// <summary>
                /// <para>The ID of the node.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-beijing-cmcc</para>
                /// </summary>
                [NameInMap("EnsRegionId")]
                [Validation(Required=false)]
                public string EnsRegionId { get; set; }

                /// <summary>
                /// <para>The specifications of instances.</para>
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
                /// <para>The sizes of system disks.</para>
                /// </summary>
                [NameInMap("SystemDiskSizes")]
                [Validation(Required=false)]
                public DescribeReservedResourceResponseBodySupportResourcesSupportResourceSystemDiskSizes SystemDiskSizes { get; set; }
                public class DescribeReservedResourceResponseBodySupportResourcesSupportResourceSystemDiskSizes : TeaModel {
                    [NameInMap("SystemDiskSize")]
                    [Validation(Required=false)]
                    public List<string> SystemDiskSize { get; set; }

                }

            }

        }

    }

}
