// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class CreateProtocolServiceRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request. You can use the client to generate the token, but make sure that the token is unique among different requests.</para>
        /// <para>The token can contain only ASCII characters and cannot exceed 64 characters in length. For more information, see <a href="https://help.aliyun.com/document_detail/25693.html">How to ensure idempotence</a>.</para>
        /// <remarks>
        /// <para>If you do not specify this parameter, the system automatically uses the RequestId of the API request as the ClientToken. The RequestId may differ for each API request.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>123e4567-e89b-12d3-a456-42665544****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the protocol service. This value is displayed as &quot;Protocol service name&quot; in the console.</para>
        /// <para>Limits:</para>
        /// <list type="bullet">
        /// <item><description>The description must be 2 to 128 characters in length.</description></item>
        /// <item><description>The description must start with a letter or Chinese character and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
        /// <item><description>The description can contain digits, colons (:), underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>此协议服务的描述。</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to perform a dry run for this request.</para>
        /// <para>A dry run checks parameter validity and dependencies without actually creating the instance or incurring charges.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: Sends a check request without creating the protocol service. The check items include whether required parameters are specified, the request format, and business limit dependencies. If the check fails, the corresponding error is returned. If the check passes, HTTP status code 200 is returned, but ProtocolServiceId is empty.</description></item>
        /// <item><description>false (default): Sends a normal request. After the check passes, the instance is directly created.</description></item>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cpfs-099394bd928c****</para>
        /// </summary>
        [NameInMap("FileSystemId")]
        [Validation(Required=false)]
        public string FileSystemId { get; set; }

        /// <summary>
        /// <para>The specification of the protocol service.</para>
        /// <para>Valid values: General (default).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>General</para>
        /// </summary>
        [NameInMap("ProtocolSpec")]
        [Validation(Required=false)]
        public string ProtocolSpec { get; set; }

        /// <summary>
        /// <para>The protocol type of the protocol service.</para>
        /// <para>Valid values: NFS (default). Only NFSv3 access is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NFS</para>
        /// </summary>
        [NameInMap("ProtocolType")]
        [Validation(Required=false)]
        public string ProtocolType { get; set; }

        /// <summary>
        /// <para>The bandwidth of the protocol service.</para>
        /// <para>Unit: MB/s.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8000</para>
        /// </summary>
        [NameInMap("Throughput")]
        [Validation(Required=false)]
        public int? Throughput { get; set; }

        /// <summary>
        /// <para>The vSwitch ID of the protocol service.</para>
        /// <para>If the storage redundancy type of the file system is zone-redundant storage (ZRS), do not set this parameter. Otherwise, this parameter is required.</para>
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
        /// <para>The VPC ID of the protocol service. The VPC must be the same as the VPC of the file system.</para>
        /// <para>If the storage redundancy type of the file system is zone-redundant storage (ZRS), do not set this parameter. Otherwise, this parameter is required.</para>
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
