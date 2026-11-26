// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudsso20210515.Models
{
    public class DeleteAccessConfigurationRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the access configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ac-001j9mcm3k7335bc****</para>
        /// </summary>
        [NameInMap("AccessConfigurationId")]
        [Validation(Required=false)]
        public string AccessConfigurationId { get; set; }

        /// <summary>
        /// <para>The ID of the directory.</para>
        /// 
        /// <b>Example:</b>
        /// <para>d-00fc2p61****</para>
        /// </summary>
        [NameInMap("DirectoryId")]
        [Validation(Required=false)]
        public string DirectoryId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly remove system policies and inline policies. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: forcibly removes the associated system policies and inline policies when the access configuration is deleted.</description></item>
        /// <item><description>false (default): does not forcibly remove the associated system policies and inline policies when the access configuration is deleted. If these policies exist, the deletion fails. You must remove these system policies and inline policies before you delete the access configuration. For more information, see <a href="https://help.aliyun.com/document_detail/336904.html">RemovePermissionPolicyFromAccessConfiguration</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceRemovePermissionPolicies")]
        [Validation(Required=false)]
        public bool? ForceRemovePermissionPolicies { get; set; }

    }

}
