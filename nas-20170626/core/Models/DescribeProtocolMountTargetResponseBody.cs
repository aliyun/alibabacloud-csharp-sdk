// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeProtocolMountTargetResponseBody : TeaModel {
        /// <summary>
        /// <para>The marker used to retrieve the remaining export directories in subsequent queries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aBcdeg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The collection of protocol service export directories.</para>
        /// </summary>
        [NameInMap("ProtocolMountTargets")]
        [Validation(Required=false)]
        public List<DescribeProtocolMountTargetResponseBodyProtocolMountTargets> ProtocolMountTargets { get; set; }
        public class DescribeProtocolMountTargetResponseBodyProtocolMountTargets : TeaModel {
            /// <summary>
            /// <para>The permission group associated with the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEFAULT_VPC_GROUP_NAME</para>
            /// </summary>
            [NameInMap("AccessGroupName")]
            [Validation(Required=false)]
            public string AccessGroupName { get; set; }

            /// <summary>
            /// <para>The time when the protocol service export directory was created. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-12T07:28:38Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>此协议服务导出目录的描述。</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>exp-19abf5beab8d****</para>
            /// </summary>
            [NameInMap("ExportId")]
            [Validation(Required=false)]
            public string ExportId { get; set; }

            /// <summary>
            /// <para>The fileset ID of the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>fset-1902718ea0ae****</para>
            /// </summary>
            [NameInMap("FsetId")]
            [Validation(Required=false)]
            public string FsetId { get; set; }

            /// <summary>
            /// <para>The exported directory of the protocol service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>/path/</para>
            /// </summary>
            [NameInMap("Path")]
            [Validation(Required=false)]
            public string Path { get; set; }

            /// <summary>
            /// <para>The domain name of the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpfs-123****.cn-hangzhou.cpfs.aliyuncs.com</para>
            /// </summary>
            [NameInMap("ProtocolMountTargetDomain")]
            [Validation(Required=false)]
            public string ProtocolMountTargetDomain { get; set; }

            /// <summary>
            /// <para>The protocol service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ptc-123****</para>
            /// </summary>
            [NameInMap("ProtocolServiceId")]
            [Validation(Required=false)]
            public string ProtocolServiceId { get; set; }

            /// <summary>
            /// <para>The protocol type supported by the protocol service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The mount target status.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CREATING</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The vSwitch ID of the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-2vc3c2lybvdllxyq4****</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The list of zone-redundant vSwitch IDs.</para>
            /// </summary>
            [NameInMap("VSwitchIds")]
            [Validation(Required=false)]
            public List<string> VSwitchIds { get; set; }

            /// <summary>
            /// <para>The VPC ID of the protocol service export directory.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-2vct297b8157bth9z****</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
