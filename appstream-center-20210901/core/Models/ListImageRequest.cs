// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListImageRequest : TeaModel {
        /// <summary>
        /// <para>The list of supported regions.
        /// WUYING images are centralized. Use this parameter to query the regions where the image is deployed.</para>
        /// </summary>
        [NameInMap("BizRegionIdList")]
        [Validation(Required=false)]
        public List<string> BizRegionIdList { get; set; }

        /// <summary>
        /// <para>The business type. This parameter is not publicly available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        /// <summary>
        /// <para>The list of all business types. This parameter is not publicly available.</para>
        /// </summary>
        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<int?> BizTypeList { get; set; }

        [NameInMap("Distro")]
        [Validation(Required=false)]
        public string Distro { get; set; }

        /// <summary>
        /// <para>The list of features supported by the image.</para>
        /// </summary>
        [NameInMap("FeatureList")]
        [Validation(Required=false)]
        public List<string> FeatureList { get; set; }

        /// <summary>
        /// <para>The image version information.</para>
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
        /// <para>The image type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <para>The language.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("LanguageType")]
        [Validation(Required=false)]
        public string LanguageType { get; set; }

        /// <summary>
        /// <para>The operating system type of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <para>The image package type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

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
        /// <para>The number of entries per page for paging queries. Maximum value: 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The operating system platform name.</para>
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
        /// 
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The list of products supported when the image supports multiple products.</para>
        /// </summary>
        [NameInMap("ProductTypeList")]
        [Validation(Required=false)]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// <para>The protocol type of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>Queries images of specific defined specifications.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.2c4g</para>
        /// </summary>
        [NameInMap("ResourceInstanceType")]
        [Validation(Required=false)]
        public string ResourceInstanceType { get; set; }

        /// <summary>
        /// <para>The image status. Specifies the status of images to query. By default, all images that are not deleted are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>INIT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The tags for query.</para>
        /// </summary>
        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<ListImageRequestTagList> TagList { get; set; }
        public class ListImageRequestTagList : TeaModel {
            /// <summary>
            /// <para>The custom tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>env</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The custom tag value.</para>
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
