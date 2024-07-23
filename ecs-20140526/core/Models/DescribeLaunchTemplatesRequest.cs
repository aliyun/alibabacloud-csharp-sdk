// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of launch templates. You can specify up to 100 launch template IDs. You must specify LaunchTemplateId or LaunchTemplateName to determine a launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-m5e3ofjr1zn1aw7q****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public List<string> LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The names of launch templates. You can specify up to 100 launch template names.</para>
        /// 
        /// <b>Example:</b>
        /// <para>wd-152630748****</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public List<string> LaunchTemplateName { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the launch template belongs. If you specify this parameter to query resources, up to 1,000 resources that belong to the specified resource group can be returned.</para>
        /// <remarks>
        /// <para>Resources in the default resource group are displayed in the response regardless of whether you specify this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The tags of the launch template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The IDs of launch templates. You can specify up to 100 launch template IDs. You must specify LaunchTemplateId or LaunchTemplateName to determine a launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxazb4p****</para>
        /// </summary>
        [NameInMap("TemplateResourceGroupId")]
        [Validation(Required=false)]
        public string TemplateResourceGroupId { get; set; }

        /// <summary>
        /// <para>The tag of the launch template.</para>
        /// </summary>
        [NameInMap("TemplateTag")]
        [Validation(Required=false)]
        public List<DescribeLaunchTemplatesRequestTemplateTag> TemplateTag { get; set; }
        public class DescribeLaunchTemplatesRequestTemplateTag : TeaModel {
            /// <summary>
            /// <para>The value of tag N of the launch template. Valid values of N: 1 to 20.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestKey</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The number of the page to return. Pages start from page 1.</para>
            /// <para>Default value: 1.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TestValue</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
