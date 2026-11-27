// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyFilesetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The release protection property of the instance. Specifies whether the instance can be released by using the console or by calling the <a href="https://help.aliyun.com/document_detail/2402263.html">DeleteFileset</a> operation.</para>
        /// <list type="bullet">
        /// <item><description>true: enables release protection for the instance.</description></item>
        /// <item><description>false: disables release protection for the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This property only restricts manual release operations and does not take effect on system release operations.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("DeletionProtection")]
        [Validation(Required=false)]
        public bool? DeletionProtection { get; set; }

        /// <summary>
        /// <para>The description of the fileset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the modification request.</para>
        /// <para>A dry run checks parameter validity and inventory without actually modifying the instance or incurring fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The instance is not modified. The system checks whether required parameters are specified, the request format, business limits, and NAS inventory. If the request fails the dry run, an error is returned. If the request passes the dry run, the HTTP status code 200 is returned.</description></item>
        /// <item><description>false: performs a regular request. If the request passes the dry run, the instance is modified.</description></item>
        /// </list>
        /// <para>Default value: false.</para>
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
        /// <item><description><para>CPFS: must start with <c>cpfs-</c>, such as cpfs-099394bd928c****.</para>
        /// </description></item>
        /// <item><description><para>CPFS for Lingjun: must start with <c>bmcpfs-</c>, such as bmcpfs-290w65p03ok64ya****.</para>
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
        /// <para>The Fileset ID.</para>
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
