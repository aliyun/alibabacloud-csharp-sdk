// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DeleteProtocolMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId may be different for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the delete request.
        /// A dry run helps you check parameter validity and dependencies. The export directory is not actually deleted, and no fees are incurred.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: performs a dry run. The export directory is not deleted. The system checks whether required parameters are specified, the request format is valid, and business limits and dependencies are met. If the request fails the dry run, an error is returned. If the request passes the dry run, the HTTP status code 200 is returned.</para>
        /// </description></item>
        /// <item><description><para>false (default): does not perform a dry run and sends the actual request. If the request passes the check, the export directory is directly deleted.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the export directory.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-19abf5beab8d****</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public string ExportId { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the protocol service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptc-197ed6a00f2b****</para>
        /// </summary>
        [NameInMap("ProtocolServiceId")]
        [Validation(Required=false)]
        public string ProtocolServiceId { get; set; }

    }

}
