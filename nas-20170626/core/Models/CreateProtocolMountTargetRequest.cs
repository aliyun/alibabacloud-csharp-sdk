// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateProtocolMountTargetRequest : TeaModel {
        /// <summary>
        /// <para>The name of the permission group.</para>
        /// <para>Default value: DEFAULT_VPC_GROUP_NAME.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DEFAULT_VPC_GROUP_NAME</para>
        /// </summary>
        [NameInMap("AccessGroupName")]
        [Validation(Required=false)]
        public string AccessGroupName { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but you must make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How do I ensure the idempotence?</a></para>
        /// <remarks>
        /// <para> If you do not specify this parameter, the system automatically uses the request ID as the client token. The request ID may be different for each request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the export directory for the protocol service. The <b>name of the export directory</b> appears in the console.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter but cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain letters, digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run. The dry run checks parameter validity and prerequisites. The dry run does not create an export directory or incur fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: performs a dry run. The system checks the request format, service limits, prerequisites, and whether the required parameters are specified. If the request fails the dry run, an error message is returned. If the request passes the dry run, the HTTP status code 200 is returned. No value is returned for the ExportId parameter.</description></item>
        /// <item><description>false (default): performs a dry run and sends the request. If the request passes the dry run, an export directory is created.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>The ID of the file system.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-123****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the fileset that you want to export.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The fileset already exists.</description></item>
        /// <item><description>You can create only one export directory for a fileset.</description></item>
        /// <item><description>You can specify either a fileset or a path.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fset-123****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The path of the CPFS directory that you want to export.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The directory already exists in the CPFS file system.</description></item>
        /// <item><description>You can create only one export directory for a directory.</description></item>
        /// <item><description>You can specify either a fileset or a path.</description></item>
        /// </list>
        /// <para>Format:</para>
        /// <list type="bullet">
        /// <item><description>The path must be 1 to 1,024 characters in length.</description></item>
        /// <item><description>The path must be encoded in UTF-8.</description></item>
        /// <item><description>The path must start and end with a forward slash (/). The root directory is <c>/</c>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>/</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The ID of the protocol service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ptc-123****</para>
        /// </summary>
        [NameInMap("ProtocolServiceId")]
        [Validation(Required=false)]
        public string ProtocolServiceId { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the export directory for the protocol service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-123****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The VPC ID of the export directory for the protocol service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-123****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
