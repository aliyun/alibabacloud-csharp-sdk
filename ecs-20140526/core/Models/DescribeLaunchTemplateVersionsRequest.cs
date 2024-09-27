// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecs20140526.Models
{
    public class DescribeLaunchTemplateVersionsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to query the default version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DefaultVersion")]
        [Validation(Required=false)]
        public bool? DefaultVersion { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the configurations of the launch template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: queries the basic information and other details of the launch template. The details include the image ID and system disk size.</description></item>
        /// <item><description>false: queries only the basic information of the launch template. The basic information includes the template ID, template name, and default version.</description></item>
        /// </list>
        /// <para>Default value: true.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DetailFlag")]
        [Validation(Required=false)]
        public bool? DetailFlag { get; set; }

        /// <summary>
        /// <para>The ID of the launch template.</para>
        /// <para>You must set LaunchTemplateId or LaunchTemplateName to specify a launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp168lnahrdwl39p****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The name of the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testLaunchTemplateName</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>Version N of the launch template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public List<long?> LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The maximum version number in the version range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public long? MaxVersion { get; set; }

        /// <summary>
        /// <para>The minimum version number in the version range to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("MinVersion")]
        [Validation(Required=false)]
        public long? MinVersion { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>Pages start from page 1.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID of the launch template.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> operation to query the most recent region list.</para>
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

    }

}
