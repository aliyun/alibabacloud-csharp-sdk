// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class RollbackServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EE9EF87D-46F8-5AF6-9A65-6B034E204136</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-5289e1d6d0c14397881d</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The deployment status of the service instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Created: The service instance is created.</para>
        /// </description></item>
        /// <item><description><para>Deploying: The service instance is being deployed.</para>
        /// </description></item>
        /// <item><description><para>DeployedFailed: The deployment of the service instance failed.</para>
        /// </description></item>
        /// <item><description><para>Deployed: The service instance is deployed.</para>
        /// </description></item>
        /// <item><description><para>Upgrading: The service instance is being upgraded.</para>
        /// </description></item>
        /// <item><description><para>UpgradeRollbacking: The service instance is being rolled back.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The service instance is being deleted.</para>
        /// </description></item>
        /// <item><description><para>Deleted: The service instance is deleted.</para>
        /// </description></item>
        /// <item><description><para>DeletedFailed: The deletion of the service instance failed.</para>
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
