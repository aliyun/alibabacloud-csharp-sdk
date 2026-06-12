// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class CreateServiceInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4DB0F536-B3BE-4F0D-BD29-E83FB56D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the service instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>si-d6ab3a63ccbb4b17****</para>
        /// </summary>
        [NameInMap("ServiceInstanceId")]
        [Validation(Required=false)]
        public string ServiceInstanceId { get; set; }

        /// <summary>
        /// <para>The status of the service instance. Valid values:</para>
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

    }

}
