// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class ClusterStateChangeReason : TeaModel {
        /// <summary>
        /// <para>The status code for the state change. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>UserRequest: A user request triggered the state change.</para>
        /// </description></item>
        /// <item><description><para>OutOfStock: The requested ECS instance type is out of stock.</para>
        /// </description></item>
        /// <item><description><para>NotAuthorized: The operation was denied due to insufficient permission.</para>
        /// </description></item>
        /// <item><description><para>QuotaExceeded: The request exceeded a service quota.</para>
        /// </description></item>
        /// <item><description><para>OperationDenied: The operation was denied.</para>
        /// </description></item>
        /// <item><description><para>AccountException: An account-related exception occurred.</para>
        /// </description></item>
        /// <item><description><para>NodeFailure: An ECS node failed.</para>
        /// </description></item>
        /// <item><description><para>BootstrapFailure: A bootstrap action failed.</para>
        /// </description></item>
        /// <item><description><para>ValidationFail: The request failed business logic validation.</para>
        /// </description></item>
        /// <item><description><para>ServiceFailure: A dependent service failed.</para>
        /// </description></item>
        /// <item><description><para>InternalError: An internal error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OutOfStock</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A human-readable message detailing the cluster state change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource is sold out in the specified zone, try other types of resources or other regions and zones.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
