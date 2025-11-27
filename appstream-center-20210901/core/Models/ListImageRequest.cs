// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListImageRequest : TeaModel {
        /// <summary>
        /// <para>The regions that are supported. The EDS images are centralized. Use this parameter to query the regions where the image is deployed.</para>
        /// </summary>
        [NameInMap("BizRegionIdList")]
        [Validation(Required=false)]
        public List<string> BizRegionIdList { get; set; }

        /// <summary>
        /// <para>The service type. This parameter is not available publicly.</para>
        /// <para>Valid value:</para>
        /// <list type="bullet">
        /// <item><description>1 (default)</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The list of all service types. It is not available publicly.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<int?> BizTypeList { get; set; }

        /// <summary>
        /// <para>The features supported by the image.</para>
        /// </summary>
        [NameInMap("FeatureList")]
        [Validation(Required=false)]
        public List<string> FeatureList { get; set; }

        /// <summary>
        /// <para>The image version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.0.3-xxxx</para>
        /// </summary>
        [NameInMap("FotaVersion")]
        [Validation(Required=false)]
        public string FotaVersion { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image name. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DemoImage</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>The type of the images.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>User: a custom image.</description></item>
        /// <item><description>Shared: a shared image.</description></item>
        /// <item><description>System: a system image.</description></item>
        /// <item><description>Community: a community image.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>en-US: English.</description></item>
        /// <item><description>zh-HK: Chinese, Traditional (Hong Kong, China).</description></item>
        /// <item><description>zh-CN: Simplified Chinese.</description></item>
        /// <item><description>ja-JP: Japanese.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("LanguageType")]
        [Validation(Required=false)]
        public string LanguageType { get; set; }

        /// <summary>
        /// <para>The OS type of the image.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Linux</description></item>
        /// <item><description>Unknown</description></item>
        /// <item><description>Windows</description></item>
        /// <item><description>Android</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The image encapsulation type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ecs_Container: ECS and Docker image</description></item>
        /// <item><description>Ecs: ECS image</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the operating system platform.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Ubuntu</description></item>
        /// <item><description>Debian</description></item>
        /// <item><description>Windows Server 2022</description></item>
        /// <item><description>Windows Server 2019</description></item>
        /// <item><description>Windows Server 2016</description></item>
        /// <item><description>Windows 11</description></item>
        /// <item><description>Windows 10</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Windows Server 2019</para>
        /// </summary>
        [NameInMap("PlatformName")]
        [Validation(Required=false)]
        public string PlatformName { get; set; }

        /// <summary>
        /// <para>The list of supported platform types. For valid values, refer to PlatformName above.</para>
        /// </summary>
        [NameInMap("PlatformNameList")]
        [Validation(Required=false)]
        public List<string> PlatformNameList { get; set; }

        /// <summary>
        /// <para>The product type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CloudDesktop: Elastic Desktop Service</description></item>
        /// <item><description>CloudApp: App Streaming</description></item>
        /// <item><description>WuyingServer: Workstation</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of products that are supported when the image supports multiple products.</para>
        /// </summary>
        [NameInMap("ProductTypeList")]
        [Validation(Required=false)]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// <para>The protocol type of the image.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HDX: the High-definition Experience (HDX) protocol</description></item>
        /// <item><description>ASP: the Alibaba Cloud-developed ASP protocol</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>Find images with certain fixed specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.2c4g</para>
        /// </summary>
        [NameInMap("ResourceInstanceType")]
        [Validation(Required=false)]
        public string ResourceInstanceType { get; set; }

        /// <summary>
        /// <para>The status of the image. You can query images in the specified status. By default, all images in the Not Deleted state are queried.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AVAILABLE: The image is available.</description></item>
        /// <item><description>INIT: The image is being initialized.</description></item>
        /// <item><description>CREATE_FAILED: The image failed to be created.</description></item>
        /// <item><description>CREATING: The image is being created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INIT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags to query.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<ListImageRequestTagList> TagList { get; set; }
        public class ListImageRequestTagList : TeaModel {
            /// <summary>
            /// <para>The key of the custom tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the custom tag.</para>
            /// 
            /// <b>Example:</b>
            /// <para>test</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
