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
        /// <para>Specifies whether to query detailed template configuration information. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Queries detailed template configuration information. In addition to basic template information, detailed configuration such as image ID and system disk size is returned.</para>
        /// </description></item>
        /// <item><description><para>false: Queries only basic template information, such as template ID, template name, and default version.</para>
        /// </description></item>
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
        /// <para>The launch template ID.</para>
        /// <para>You must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to determine the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lt-bp168lnahrdwl39p****</para>
        /// </summary>
        [NameInMap("LaunchTemplateId")]
        [Validation(Required=false)]
        public string LaunchTemplateId { get; set; }

        /// <summary>
        /// <para>The launch template name.</para>
        /// <para>You must specify <c>LaunchTemplateId</c> or <c>LaunchTemplateName</c> to determine the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testLaunchTemplateName</para>
        /// </summary>
        [NameInMap("LaunchTemplateName")]
        [Validation(Required=false)]
        public string LaunchTemplateName { get; set; }

        /// <summary>
        /// <para>One or more launch template version numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LaunchTemplateVersion")]
        [Validation(Required=false)]
        public List<long?> LaunchTemplateVersion { get; set; }

        /// <summary>
        /// <para>The maximum version number used to filter query results. Used together with <c>MinVersion</c> to query version information within the range between the minimum and maximum version numbers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxVersion")]
        [Validation(Required=false)]
        public long? MaxVersion { get; set; }

        /// <summary>
        /// <para>The minimum version number used to filter query results. Used together with <c>MaxVersion</c> to query version information within the range between the minimum and maximum version numbers.</para>
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
        /// <para>The page number of the launch template list.</para>
        /// <para>Minimum value: 1. </para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page in a paged query. Settings this parameter for paging. </para>
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
        /// <para>You can call <a href="https://help.aliyun.com/document_detail/25609.html">DescribeRegions</a> to query the most recent region list.</para>
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
