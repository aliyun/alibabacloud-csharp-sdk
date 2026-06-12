// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class UpgradeServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F224E002-AB0E-5FD9-A87E-54AEE56F6CAE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-5cbae874da0e47xxxxxx</para>
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
        /// <item><description><para>DeployedFailed: The service instance failed to be deployed.</para>
        /// </description></item>
        /// <item><description><para>Deployed: The service instance is deployed.</para>
        /// </description></item>
        /// <item><description><para>Upgrading: The service instance is being upgraded.</para>
        /// </description></item>
        /// <item><description><para>Deleting: The service instance is being deleted.</para>
        /// </description></item>
        /// <item><description><para>Deleted: The service instance is deleted.</para>
        /// </description></item>
        /// <item><description><para>DeletedFailed: The service instance failed to be deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Created</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The parameters that are required for the upgrade.</para>
        /// </summary>
        [NameInMap("UpgradeRequiredParameters")]
        [Validation(Required=false)]
        public List<string> UpgradeRequiredParameters { get; set; }

    }

}
