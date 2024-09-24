// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeServiceLinkedRoleStatusRequest : TeaModel {
        /// <summary>
        /// <para>The service-linked role. Default value: <b>AliyunServiceRoleForSas</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>AliyunServiceRoleForSas</b>: the service-linked role of Security Center. Security Center assumes this role to access the resources of other cloud services within your account.</description></item>
        /// <item><description><b>AliyunServiceRoleForSasCspm</b>: the service-linked role of Security Center-CSPM. Security Center-CSPM assumes this role to access the resources of other cloud services within your account.</description></item>
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
