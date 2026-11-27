// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteFilesetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the value on your client, but you must ensure that the value is unique among different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">Ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the delete request.</para>
        /// <para>A dry run helps you check parameter validity and resource availability without actually deleting the instance.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: performs a dry run and does not delete the instance. The system checks whether required parameters are specified, the request format is valid, and service limits are met. If the request fails the dry run, an error is returned. If the request passes the dry run, the HTTP status code 200 is returned.</para>
        /// </description></item>
        /// <item><description><para>false (default): sends a normal request and directly deletes the instance after it passes the check.</para>
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
        /// <para>The ID of the file system.</para>
        /// <list type="bullet">
        /// <item><description><para>CPFS: The ID must start with <c>cpfs-</c>. Example: cpfs-099394bd928c****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: The ID must start with <c>bmcpfs-</c>. Example: bmcpfs-290w65p03ok64ya****.</para>
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
