// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class RenewServiceInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to perform a dry run of the renewal request, including permission and instance status checks. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: Sends the request without renewing the service instance.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: Sends the request and renews the service instance after the checks pass.</para>
        /// </description></item>
        /// </list>
        /// <para>Default value: false. The operation is allowed only when the service instance is in the Pending Renewal or Renewal Failed state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-70a3b15bb626435b****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

    }

}
