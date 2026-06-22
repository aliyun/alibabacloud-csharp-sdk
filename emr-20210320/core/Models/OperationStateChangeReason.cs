// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class OperationStateChangeReason : TeaModel {
        /// <summary>
        /// <para>The operation status code. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>UserRequest</c>: The operation was initiated by a user.</para>
        /// </description></item>
        /// <item><description><para><c>OutOfStock</c>: The requested ECS instance type is out of stock.</para>
        /// </description></item>
        /// <item><description><para><c>NotAuthorized</c>: You are not authorized to perform the operation.</para>
        /// </description></item>
        /// <item><description><para><c>QuotaExceeded</c>: A resource quota was exceeded.</para>
        /// </description></item>
        /// <item><description><para><c>OperationDenied</c>: The operation was denied.</para>
        /// </description></item>
        /// <item><description><para><c>AccountException</c>: An account exception occurred.</para>
        /// </description></item>
        /// <item><description><para><c>NodeFailure</c>: An ECS node failed.</para>
        /// </description></item>
        /// <item><description><para><c>BootstrapFailure</c>: A bootstrap action failed.</para>
        /// </description></item>
        /// <item><description><para><c>ValidationFail</c>: The business logic validation failed.</para>
        /// </description></item>
        /// <item><description><para><c>ServiceFailure</c>: A dependent service failed.</para>
        /// </description></item>
        /// <item><description><para><c>InternalError</c>: An internal error occurred.</para>
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
        /// <para>A human-readable message that provides details about the state change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The requested resource is sold out in the specified zone, try other types of resources or other regions and zones.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
