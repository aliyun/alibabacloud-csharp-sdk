// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateServiceLinkedRoleRequest : TeaModel {
        /// <summary>
        /// <para>The service-linked role. Default value: <b>AliyunServiceRoleForSas</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AliyunServiceRoleForSas</b>: the service-linked role for Security Center (SAS). Security Center uses this role to access your resources in other Alibaba Cloud services.</description></item>
        /// <item><description><b>AliyunServiceRoleForSasCspm</b>: the service-linked role for Security Center - Cloud Security Posture Management (CSPM) (sas-cspm). sas-cspm uses this role to access your resources in other Alibaba Cloud services.</description></item>
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
