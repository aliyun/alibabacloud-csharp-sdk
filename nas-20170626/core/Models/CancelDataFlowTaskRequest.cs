// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CancelDataFlowTaskRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that you can use to ensure the idempotence of the request. The token must be unique across different requests.</para>
        /// <para>The <c>ClientToken</c> value must be an ASCII string of 64 characters or less. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the request ID as the <c>ClientToken</c>. The request ID is unique for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The data flow ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>df-194433a5be31****</para>
        /// </summary>
        [NameInMap("DataFlowId")]
        [Validation(Required=false)]
        public string DataFlowId { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for the request.</para>
        /// <para>A dry run checks for parameter validity and resource availability without actually canceling the task or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>true</c>: Performs a dry run. The system checks the request for potential issues, including missing parameters, invalid formats, and service limits. If the check fails, the system returns an error message; otherwise, it returns a success code.</para>
        /// </description></item>
        /// <item><description><para><c>false</c> (default): Sends a normal request. After the request passes the check, the task is canceled.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The file system ID.</para>
        /// <list type="bullet">
        /// <item><description><para>For a general-purpose CPFS instance, the ID must start with <c>cpfs-</c>, for example, <c>cpfs-125487****</c>.</para>
        /// </description></item>
        /// <item><description><para>For a CPFS for AI Computing instance, the ID must start with <c>bmcpfs-</c>, for example, <c>bmcpfs-0015****</c>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The data flow task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>task-38aa8e890f45****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
