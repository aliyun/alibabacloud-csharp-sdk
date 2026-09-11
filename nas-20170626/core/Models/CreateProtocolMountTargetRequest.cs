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
        /// <para>Ensures the idempotence of the request. Generate a parameter value from your client to ensure that the value is unique across different requests.</para>
        /// <para>ClientToken supports only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may vary for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the protocol service export directory. This is displayed as <b>Export Directory Name</b> in the console.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length and can contain letters and Chinese characters.</description></item>
        /// <item><description>The description must start with a letter or a Chinese character. It cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Description of this export directory</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request. A dry run checks parameter validity and dependencies without actually creating the instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: Sends a dry run request without creating the export directory. The check items include whether required parameters are specified, request format, and business limit dependencies. If the check fails, the corresponding error is returned. If the check passes, HTTP status code 200 is returned, but ExportId is empty.</para>
        /// </description></item>
        /// <item><description><para>false (default): Sends a normal request. After the check passes, the instance is directly created.</para>
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
        /// <para>The ID of the file system.</para>
        /// <remarks>
        /// <para>The target CPFS file system must be in the Running state before you call this operation. After creation, it takes approximately 20 to 40 minutes for the file system to reach the Running state. You can call <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-describefilesystems">DescribeFileSystems</a> to poll the Status field (Running indicates ready).</para>
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
        /// <para>The ID of the fileset to export.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The fileset must already exist.</description></item>
        /// <item><description>Only one export directory can be created for each fileset.</description></item>
        /// <item><description>You must specify one and only one of FsetId and Path.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>fset-1902718ea0ae****</para>
        /// </summary>
        [NameInMap("FsetId")]
        [Validation(Required=false)]
        public string FsetId { get; set; }

        /// <summary>
        /// <para>The path of the CPFS directory to export.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The directory must already exist on the CPFS file system.</description></item>
        /// <item><description>Only one export can be created for the same directory.</description></item>
        /// <item><description>You must specify one and only one of FsetId and Path.</description></item>
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
        /// <para>ptc-197ed6a00f2b****</para>
        /// </summary>
        [NameInMap("ProtocolServiceId")]
        [Validation(Required=false)]
        public string ProtocolServiceId { get; set; }

        /// <summary>
        /// <para>The ID of the vSwitch for the protocol service export.</para>
        /// <para>If the storage redundancy type of the file system is not zone-redundant storage (ZRS), this parameter is required when VpcId is specified.</para>
        /// <remarks>
        /// <para>The vSwitch must be in the same zone as the target CPFS file system (the ZoneId values must match). You can call <a href="https://www.alibabacloud.com/help/en/nas/developer-reference/api-nas-2017-06-26-describefilesystems">DescribeFileSystems</a> to query the ZoneId field of the file system, and then select a vSwitch in the same zone.</para>
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
        /// <para>The ID of the VPC for the protocol service export.</para>
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
