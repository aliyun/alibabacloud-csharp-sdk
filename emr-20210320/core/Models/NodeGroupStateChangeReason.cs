// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class NodeGroupStateChangeReason : TeaModel {
        /// <summary>
        /// <para>The status code for the state change. Valid values include:</para>
        /// <list type="bullet">
        /// <item><description><para><c>UserRequest</c>: A user request triggered the change.</para>
        /// </description></item>
        /// <item><description><para><c>OutOfStock</c>: The requested ECS instance type is out of stock.</para>
        /// </description></item>
        /// <item><description><para><c>NotAuthorized</c>: The request lacks the required permissions.</para>
        /// </description></item>
        /// <item><description><para><c>QuotaExceeded</c>: The request exceeds the resource quota.</para>
        /// </description></item>
        /// <item><description><para><c>OperationDenied</c>: The system denied the operation.</para>
        /// </description></item>
        /// <item><description><para><c>AccountException</c>: An account exception occurred.</para>
        /// </description></item>
        /// <item><description><para><c>NodeFailure</c>: An ECS node failed.</para>
        /// </description></item>
        /// <item><description><para><c>BootstrapFailure</c>: The bootstrap process failed.</para>
        /// </description></item>
        /// <item><description><para><c>ValidationFail</c>: The request parameters failed validation.</para>
        /// </description></item>
        /// <item><description><para><c>ServiceFailure</c>: A dependent service failed.</para>
        /// </description></item>
        /// <item><description><para><c>InternalError</c>: An unexpected internal error occurred.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>UserRequest</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>A human-readable message that provides details about the state change.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The instance type is required.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

    }

}
