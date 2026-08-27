// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class SetTemplatePermissionRequest : TeaModel {
        /// <summary>
        /// <para>The Alibaba Cloud accounts with or from which you want to share or unshare the template.<br>
        /// Valid values of N: 1, 2, 3, 4, and 5.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description><para>This parameter cannot be set to the ID of the Alibaba Cloud account that owns the template, or the RAM users of this Alibaba Cloud account.</para>
        /// </description></item>
        /// <item><description><para>When ShareOption is set to CancelSharing, you can unshare the template from all the specified Alibaba Cloud accounts by using an asterisk (\*).</para>
        /// </description></item>
        /// </list>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>151266687691****</para>
        /// </summary>
        [NameInMap("AccountIds")]
        [Validation(Required=false)]
        public List<string> AccountIds { get; set; }

        /// <summary>
        /// <para>The sharing option.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>ShareToAccounts: shares the template with other Alibaba Cloud accounts.</para>
        /// </description></item>
        /// <item><description><para>CancelSharing: unshares the template.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ShareToAccounts</para>
        /// </summary>
        [NameInMap("ShareOption")]
        [Validation(Required=false)]
        public string ShareOption { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The version of the shared template. This parameter takes effect only if you set ShareOption to ShareToAccounts and set VersionOption to Specified.</para>
        /// <para>Valid values: v1 to v100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

        /// <summary>
        /// <para>The version option for the shared template. This parameter takes effect only if you set ShareOption to ShareToAccounts.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AllVersions (default): shares all versions of the template.</para>
        /// </description></item>
        /// <item><description><para>Latest: shares only the latest version of template. When the version of the template is updated, ROS updates the shared version to the latest version.</para>
        /// </description></item>
        /// <item><description><para>Current: shares only the current version of the template. When the version of the template is updated, ROS does not update the shared version.</para>
        /// </description></item>
        /// <item><description><para>Specified: shares only the specified version of the template.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Specified</para>
        /// </summary>
        [NameInMap("VersionOption")]
        [Validation(Required=false)]
        public string VersionOption { get; set; }

    }

}
