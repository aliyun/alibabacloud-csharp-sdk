// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCommunityImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of custom images and shared images that are supported by the E-HPC.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListCommunityImagesResponseBodyImages Images { get; set; }
        public class ListCommunityImagesResponseBodyImages : TeaModel {
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public List<ListCommunityImagesResponseBodyImagesImageInfo> ImageInfo { get; set; }
            public class ListCommunityImagesResponseBodyImagesImageInfo : TeaModel {
                /// <summary>
                /// <para>The tag of the BOS image.</para>
                /// </summary>
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public ListCommunityImagesResponseBodyImagesImageInfoBaseOsTag BaseOsTag { get; set; }
                public class ListCommunityImagesResponseBodyImagesImageInfoBaseOsTag : TeaModel {
                    /// <summary>
                    /// <para>The architecture of the operating system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>i386</description></item>
                    /// <item><description>x86_64</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x86_64</para>
                    /// </summary>
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    /// <summary>
                    /// <para>The operating system tag of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CentOS_7.2_64</para>
                    /// </summary>
                    [NameInMap("OsTag")]
                    [Validation(Required=false)]
                    public string OsTag { get; set; }

                    /// <summary>
                    /// <para>The distribution of the operating system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CentOS</description></item>
                    /// <item><description>Ubuntu</description></item>
                    /// <item><description>SUSE</description></item>
                    /// <item><description>OpenSUSE</description></item>
                    /// <item><description>Debian</description></item>
                    /// <item><description>CoreOS</description></item>
                    /// <item><description>Aliyun</description></item>
                    /// <item><description>Windows Server 2003</description></item>
                    /// <item><description>Windows Server 2008</description></item>
                    /// <item><description>Windows Server 2012</description></item>
                    /// <item><description>Others Linux</description></item>
                    /// <item><description>Customized Linux</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CentOS</para>
                    /// </summary>
                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    /// <summary>
                    /// <para>The version of the operating system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7.2</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The description of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ExampleDescription</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The image ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>m-bp181x855551ww5yq****</para>
                /// </summary>
                [NameInMap("ImageId")]
                [Validation(Required=false)]
                public string ImageId { get; set; }

                /// <summary>
                /// <para>The image name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>linux_CentOS7.2_OceanBase_OBD_1ECS-3OB_3.0</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The image type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>self: custom image</description></item>
                /// <item><description>others: shared image</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>self</para>
                /// </summary>
                [NameInMap("ImageOwnerAlias")]
                [Validation(Required=false)]
                public string ImageOwnerAlias { get; set; }

                /// <summary>
                /// <para>An array of OS images that are supported by E-HPC.</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public ListCommunityImagesResponseBodyImagesImageInfoOsTag OsTag { get; set; }
                public class ListCommunityImagesResponseBodyImagesImageInfoOsTag : TeaModel {
                    /// <summary>
                    /// <para>The architecture of the operating system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>i386</description></item>
                    /// <item><description>x86_64</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>x86_64</para>
                    /// </summary>
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    /// <summary>
                    /// <para>The tag of the BOS image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CentOS_7.2_64</para>
                    /// </summary>
                    [NameInMap("BaseOsTag")]
                    [Validation(Required=false)]
                    public string BaseOsTag { get; set; }

                    /// <summary>
                    /// <para>The operating system tag of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CentOS_7.2_64</para>
                    /// </summary>
                    [NameInMap("OsTag")]
                    [Validation(Required=false)]
                    public string OsTag { get; set; }

                    /// <summary>
                    /// <para>The OS.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CentOS</para>
                    /// </summary>
                    [NameInMap("Platform")]
                    [Validation(Required=false)]
                    public string Platform { get; set; }

                    /// <summary>
                    /// <para>The version of the operating system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>7.2</para>
                    /// </summary>
                    [NameInMap("Version")]
                    [Validation(Required=false)]
                    public string Version { get; set; }

                }

                /// <summary>
                /// <para>The script that is run after the image is installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.sh</para>
                /// </summary>
                [NameInMap("PostInstallScript")]
                [Validation(Required=false)]
                public string PostInstallScript { get; set; }

                /// <summary>
                /// <para>The billing unit of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Hour</description></item>
                /// <item><description>Month</description></item>
                /// <item><description>Year</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("PricingCycle")]
                [Validation(Required=false)]
                public string PricingCycle { get; set; }

                /// <summary>
                /// <para>The product code in Alibaba Cloud Marketplace.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cmjj028279</para>
                /// </summary>
                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                /// <summary>
                /// <para>The size of the image. Unit: GiB.</para>
                /// 
                /// <b>Example:</b>
                /// <para>40</para>
                /// </summary>
                [NameInMap("Size")]
                [Validation(Required=false)]
                public int? Size { get; set; }

                /// <summary>
                /// <para>The stock keeping unit (SKU) of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ECS: pay-as-you-go</description></item>
                /// <item><description>package: subscription</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("SkuCode")]
                [Validation(Required=false)]
                public string SkuCode { get; set; }

                /// <summary>
                /// <para>The state of the image. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>UnAvailable</description></item>
                /// <item><description>Available</description></item>
                /// <item><description>Creating</description></item>
                /// <item><description>CreateFailed</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The owner of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>127****</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04F0F334-1335-436C-A1D7-6C044FE73368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
