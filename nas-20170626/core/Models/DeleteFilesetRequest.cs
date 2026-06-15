// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteFilesetRequest : TeaModel {
        /// <summary>
        /// <para>A client-generated token that you can use to ensure the idempotence of the request. The ClientToken must be unique across requests.</para>
        /// <para>The ClientToken can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the request ID as the ClientToken. The request ID is unique for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for the request.</para>
        /// <para>A dry run checks for issues such as parameter validity and resource availability, but does not delete the fileset.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Sends a check request and does not delete the fileset. The system checks for required parameters, request format, and business limits. If the check fails, an error is returned. If the check passes, an HTTP 200 OK status code is returned.</para>
        /// </description></item>
        /// <item><description><para>false (Default): Sends a normal request and deletes the fileset after the check passes.</para>
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
        /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>, such as cpfs-099394bd928c\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// <item><description><para>CPFS for AI and HPC: The ID must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya\<em>\</em>\<em>\</em>.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bmcpfs-290w65p03ok64ya****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The fileset ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>fset-1902718ea0ae****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

    }

}
