// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class ModifyProtocolMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate the token on your client and ensure that the token is unique across different requests.</para>
        /// <para>The client token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the client token. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the export directory for the protocol service.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>It must start with a letter or a Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>It can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Description of the export directory</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the modification request.</para>
        /// <para>A dry run checks whether the parameters are valid and whether the dependencies are met. It does not actually modify the export directory or incur any fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: A dry run is performed and the export directory is not modified. The system checks whether required parameters are specified, the request format is valid, and the business limits and dependencies are met.</para>
        /// <list type="bullet">
        /// <item><description><b>A dry run with DryRun set to true also checks the resource status</b> (including the requirement that the export directory must be in the AVAILABLE state).</description></item>
        /// <item><description>If the status of the export directory does not meet the requirements (for example, the status is CREATING), the corresponding error is returned.</description></item>
        /// <item><description><b>A dry run does not bypass the status check</b>. It is only used to verify the validity of request parameters and basic dependencies.</description></item>
        /// <item><description>If the request fails the dry run, the corresponding error is returned. If the request passes the dry run, the HTTP status code 200 is returned.</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para><b>false</b> (default): A normal request is sent. If the request passes the check, the parameters of the export directory are directly modified.</para>
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
        /// <para>The ID of the export directory for the protocol service. You can call the <a href="https://www.alibabacloud.com/help/en/cpfs/cpfsonecs/developer-reference/api-nas-2017-06-26-describeprotocolmounttarget-cpfs">DescribeProtocolMountTarget</a> operation to query the export directory information and obtain the ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exp-19abf5beab8d****</para>
        /// </summary>
        [NameInMap("ExportId")]
        [Validation(Required=false)]
        public string ExportId { get; set; }

        /// <summary>
        /// <para>The ID of the file system. You can call the <a href="https://www.alibabacloud.com/help/en/cpfs/cpfsonecs/developer-reference/api-nas-2017-06-26-describefilesystems-cpfs">DescribeFileSystems</a> operation to query the file system information and obtain the ID. Set the FileSystemType parameter to cpfs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the protocol service. You can call the <a href="https://www.alibabacloud.com/help/en/cpfs/cpfsonecs/developer-reference/api-nas-2017-06-26-describeprotocolservice-cpfs">DescribeProtocolService</a> operation to query the protocol service information and obtain the ID.</para>
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
