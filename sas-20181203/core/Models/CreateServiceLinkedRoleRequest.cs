// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. Different requests must use different tokens. The token can contain only ASCII characters and cannot exceed 64 characters in length.</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform only a dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs only a dry run without executing the actual operation.</description></item>
        /// <item><description>false: performs the actual operation.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The service-linked role. Default value: <b>AliyunServiceRoleForSas</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AliyunServiceRoleForSas</b>: The service-linked role for Security Center (SAS). Security Center uses this role to access your resources in other Alibaba Cloud services.</description></item>
        /// <item><description><b>AliyunServiceRoleForSasCspm</b>: The service-linked role for Security Center - Cloud Security Posture Management (CSPM) (sas-cspm). sas-cspm uses this role to access your resources in other Alibaba Cloud services.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>AliyunServiceRoleForSas</para>
        /// </summary>
        [NameInMap("ServiceLinkedRole")]
        [Validation(Required=false)]
        public string ServiceLinkedRole { get; set; }

    }

}
