// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class GetProtocolMountTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>If the response is truncated, you can use NextToken to send a subsequent request to retrieve the content after the current truncation point.</para>
        /// 
        /// <b>Example:</b>
        /// <para>M18xMA==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The export directory information of the protocol service.</para>
        /// </summary>
        [NameInMap("ProtocolMountTarget")]
        [Validation(Required=false)]
        public GetProtocolMountTargetResponseBodyProtocolMountTarget ProtocolMountTarget { get; set; }
        public class GetProtocolMountTargetResponseBodyProtocolMountTarget : TeaModel {
            /// <summary>
            /// <para>The permission group name.</para>
            /// <para>Default permission group: DEFAULT_VPC_GROUP_NAME.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_VPC_GROUP_NAME</para>
            /// </summary>
            [NameInMap("AccessGroupName")]
            [Validation(Required=false)]
            public string AccessGroupName { get; set; }

            /// <summary>
            /// <para>The creation time.
            /// Format: yyyy-MM-dd HH:mm:ss</para>
            /// 
            /// <b>Example:</b>
            /// <para>2025-12-22 17:49:25</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the protocol service export.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Description of this protocol service export</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The export directory ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exp-19abf5beab8d****</para>
            /// </summary>
            [NameInMap("ExportId")]
            [Validation(Required=false)]
            public string ExportId { get; set; }

            /// <summary>
            /// <para>Fileset ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>fset-299b4ca04de8****</para>
            /// </summary>
            [NameInMap("FsetId")]
            [Validation(Required=false)]
            public string FsetId { get; set; }

            /// <summary>
            /// <para>The path of the queried CPFS directory.</para>
            /// <para>Format:</para>
            /// <list type="bullet">
            /// <item><description>The path is 1 to 1,024 characters in length.</description></item>
            /// <item><description>The path is encoded in UTF-8.</description></item>
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
            /// <para>The domain name of the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpfs-0229cb80bcc0****-x******.cn-*****.cpfs.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ProtocolMountTargetDomain")]
            [Validation(Required=false)]
            public string ProtocolMountTargetDomain { get; set; }

            /// <summary>
            /// <para>The protocol type of the file system.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NFS: NFS protocol</description></item>
            /// <item><description>SMB: SMB protocol</description></item>
            /// <item><description>cpfs: the protocol type supported by CPFS file systems</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The status of the protocol service export directory. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>CREATING: Being created.</description></item>
            /// <item><description>AVAILABLE: Available.</description></item>
            /// <item><description>MODIFYING: Being modified.</description></item>
            /// <item><description>DELETING: Being deleted.</description></item>
            /// <item><description>STOPPING: Being stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>AVAILABLE</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The vSwitch ID of the protocol service export.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-8vb2qjnxs6hiobzve****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The list of vSwitch IDs of the protocol service export.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The virtual private cloud (VPC) ID of the protocol service export.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-bp1h5mxoqfuo3xurf****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6299428C-3861-435D-AE54-9B330A00****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
