// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ListImageRequest : TeaModel {
        [NameInMap("BizRegionIdList")]
        [Validation(Required=false)]
        public List<string> BizRegionIdList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public int? BizType { get; set; }

        [NameInMap("BizTypeList")]
        [Validation(Required=false)]
        public List<int?> BizTypeList { get; set; }

        [NameInMap("FeatureList")]
        [Validation(Required=false)]
        public List<string> FeatureList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2.0.3-xxxx</para>
        /// </summary>
        [NameInMap("FotaVersion")]
        [Validation(Required=false)]
        public string FotaVersion { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>img-bp13mu****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>DemoImage</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>User</para>
        /// </summary>
        [NameInMap("ImageType")]
        [Validation(Required=false)]
        public string ImageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>zh-CN</para>
        /// </summary>
        [NameInMap("LanguageType")]
        [Validation(Required=false)]
        public string LanguageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Windows</para>
        /// </summary>
        [NameInMap("OsType")]
        [Validation(Required=false)]
        public string OsType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Ecs</para>
        /// </summary>
        [NameInMap("PackageType")]
        [Validation(Required=false)]
        public string PackageType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Windows Server 2019</para>
        /// </summary>
        [NameInMap("PlatformName")]
        [Validation(Required=false)]
        public string PlatformName { get; set; }

        [NameInMap("PlatformNameList")]
        [Validation(Required=false)]
        public List<string> PlatformNameList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CloudApp</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        [NameInMap("ProductTypeList")]
        [Validation(Required=false)]
        public List<string> ProductTypeList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ASP</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>eds.enterprise_office.2c4g</para>
        /// </summary>
        [NameInMap("ResourceInstanceType")]
        [Validation(Required=false)]
        public string ResourceInstanceType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>INIT</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TagList")]
        [Validation(Required=false)]
        public List<ListImageRequestTagList> TagList { get; set; }
        public class ListImageRequestTagList : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
