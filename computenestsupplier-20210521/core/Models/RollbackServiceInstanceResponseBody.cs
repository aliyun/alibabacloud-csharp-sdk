// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class RollbackServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE9EF87D-46F8-5AF6-9A65-6B034E204136</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-5289e1d6d0c14397881d</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The deployment status of the service instance. Possible values:</para>
        /// <list type="bullet">
        /// <item><description><para>Created: Created</para>
        /// </description></item>
        /// <item><description><para>Deploying: Deploying</para>
        /// </description></item>
        /// <item><description><para>DeployedFailed: Deployment Failed</para>
        /// </description></item>
        /// <item><description><para>Deployed: Deployed</para>
        /// </description></item>
        /// <item><description><para>Upgrading: Upgrading</para>
        /// </description></item>
        /// <item><description><para>UpgradeRollbacking: Rolling Back</para>
        /// </description></item>
        /// <item><description><para>Deleting: Deleting</para>
        /// </description></item>
        /// <item><description><para>Deleted: Deleted</para>
        /// </description></item>
        /// <item><description><para>DeletedFailed: Deletion Failed</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UpgradeRollbacking</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
