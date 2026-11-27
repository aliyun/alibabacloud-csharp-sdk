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
        /// <para>The client token that is used to ensure the idempotence of the request. You can generate a parameter value from your client to ensure that the value is unique across different requests.</para>
        /// <para>The ClientToken parameter supports only ASCII characters and can be up to 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId of each API request may be different.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the export directory for the protocol service. It is displayed as the <b>Export Directory Name</b> in the console.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The value must be 2 to 128 characters in length.</description></item>
        /// <item><description>The value must start with a letter or a Chinese character, and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The value can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>The description of this export directory</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run on the creation request.
        /// A dry run helps you check the validity of parameters and dependencies without actually creating the instance or incurring fees.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: sends a check request and does not create the export directory. The check items include whether required parameters are specified, the request format, and business limits and dependencies. If the check fails, the corresponding error is returned. If the check succeeds, the HTTP status code 200 is returned, but ExportId is empty.</description></item>
        /// <item><description>false (default): sends a normal request and directly creates the instance after the check succeeds.</description></item>
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
        /// <remarks>
        /// <para>The target CPFS file system must be in the Running state before you can call this operation. It takes about 20 to 40 minutes for a file system to reach the Running state after creation. You can poll the Status field by calling the <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-describefilesystems">DescribeFileSystems</a> operation. A value of Running indicates that the file system is ready.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The ID of the Fileset to be exported.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The Fileset must already exist.</description></item>
        /// <item><description>Only one export directory can be created for a single Fileset.</description></item>
        /// <item><description>You must specify either Fileset or Path, but not both.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fset-1902718ea0ae****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The path of the CPFS directory to be exported.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The directory must already exist on the CPFS file system.</description></item>
        /// <item><description>Only one export can be created for the same directory.</description></item>
        /// <item><description>You must specify either Fileset or Path, but not both.</description></item>
        /// </list>
        /// <para>Format:</para>
        /// <list type="bullet">
        /// <item><description>The value must be 1 to 1,024 characters in length.</description></item>
        /// <item><description>The value must be encoded in UTF-8.</description></item>
        /// <item><description>The value must start and end with a forward slash (/). The root directory is <c>/</c>.</description></item>
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
        /// <para>ptc-197ed6a00f2b****</para>
        /// </summary>
        [NameInMap("ProtocolServiceId")]
        [Validation(Required=false)]
        public string ProtocolServiceId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch to which the protocol service export belongs.</para>
        /// <para>If the storage redundancy type of the file system is not zone-redundant storage (ZRS) and VpcId is specified, this parameter is required.</para>
        /// <remarks>
        /// <para>The vSwitch must be in the same zone as the target CPFS file system (the ZoneId values must be the same). You can call the <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-describefilesystems">DescribeFileSystems</a> operation to query the ZoneId field of the file system, and then select a vSwitch in the same zone.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vsw-2vc3c2lybvdllxyq4****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VSwitchId")]
        [Validation(Required=false)]
        public string VSwitchId { get; set; }

        /// <summary>
        /// <para>The list of vSwitch IDs for the protocol service export.</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VSwitchIds")]
        [Validation(Required=false)]
        public List<string> VSwitchIds { get; set; }

        /// <summary>
        /// <para>The ID of the VPC to which the protocol service export belongs.</para>
        /// <remarks>
        /// <para>The CIDR block of the selected VPC must not overlap with the VPC CIDR block of the target CPFS file system. You can call the DescribeVpcs operation of VPC to query the CidrBlock field of each VPC for comparison, and select a VPC that does not conflict and is in the same zone as the file system.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>vpc-2vct297b8157bth9z****</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("VpcId")]
        [Validation(Required=false)]
        public string VpcId { get; set; }

    }

}
