// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EHPC20180412.Models
{
    public class ListCustomImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of community images, including custom images and shared images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public ListCustomImagesResponseBodyImages Images { get; set; }
        public class ListCustomImagesResponseBodyImages : TeaModel {
            [NameInMap("ImageInfo")]
            [Validation(Required=false)]
            public List<ListCustomImagesResponseBodyImagesImageInfo> ImageInfo { get; set; }
            public class ListCustomImagesResponseBodyImagesImageInfo : TeaModel {
                /// <summary>
                /// <para>The image tag of the operating system.</para>
                /// </summary>
                [NameInMap("BaseOsTag")]
                [Validation(Required=false)]
                public ListCustomImagesResponseBodyImagesImageInfoBaseOsTag BaseOsTag { get; set; }
                public class ListCustomImagesResponseBodyImagesImageInfoBaseOsTag : TeaModel {
                    /// <summary>
                    /// <para>The architecture of the operating system. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>i386</description></item>
                    /// <item><description>x86_64</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>i386</para>
                    /// </summary>
                    [NameInMap("Architecture")]
                    [Validation(Required=false)]
                    public string Architecture { get; set; }

                    /// <summary>
                    /// <para>The tags of the image.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CentOS_7.2_64</para>
                    /// </summary>
                    [NameInMap("OsTag")]
                    [Validation(Required=false)]
                    public string OsTag { get; set; }

                    /// <summary>
                    /// <para>The OS. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description>CentOS</description></item>
                    /// <item><description>windows</description></item>
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
                /// <para>The name of the image.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CHESS5V5.0.27</para>
                /// </summary>
                [NameInMap("ImageName")]
                [Validation(Required=false)]
                public string ImageName { get; set; }

                /// <summary>
                /// <para>The type of the image. Valid values:</para>
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
                /// <para>An array of system images that are supported by E-HPC.</para>
                /// </summary>
                [NameInMap("OsTag")]
                [Validation(Required=false)]
                public ListCustomImagesResponseBodyImagesImageInfoOsTag OsTag { get; set; }
                public class ListCustomImagesResponseBodyImagesImageInfoOsTag : TeaModel {
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
                    /// <para>The image tag of the operating system.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>CentOS_7.2_64</para>
                    /// </summary>
                    [NameInMap("BaseOsTag")]
                    [Validation(Required=false)]
                    public string BaseOsTag { get; set; }

                    /// <summary>
                    /// <para>The tag of the image.</para>
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
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>example.sh</para>
                /// </summary>
                [NameInMap("PostInstallScript")]
                [Validation(Required=false)]
                public string PostInstallScript { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Month</para>
                /// </summary>
                [NameInMap("PricingCycle")]
                [Validation(Required=false)]
                public string PricingCycle { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
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
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>ECS</para>
                /// </summary>
                [NameInMap("SkuCode")]
                [Validation(Required=false)]
                public string SkuCode { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
                /// 
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <remarks>
                /// <para> This parameter is not publicly available.</para>
                /// </remarks>
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
