// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.NAS20170626.Models
{
    public class DescribeProtocolServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The marker used to retrieve the remaining protocol services.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aBcdeg==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The list of protocol service information.</para>
        /// </summary>
        [NameInMap("ProtocolServices")]
        [Validation(Required=false)]
        public List<DescribeProtocolServiceResponseBodyProtocolServices> ProtocolServices { get; set; }
        public class DescribeProtocolServiceResponseBodyProtocolServices : TeaModel {
            /// <summary>
            /// <para>The time when the protocol service was created, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-12T07:28:38Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the protocol service.</para>
            /// <para>Limits:</para>
            /// <list type="bullet">
            /// <item><description>The description must be 2 to 128 characters in length.</description></item>
            /// <item><description>The description must start with a letter and cannot start with <c>http://</c> or <c>https://</c>.</description></item>
            /// <item><description>The description can contain digits, colons (:), underscores (_), or hyphens (-).</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Description of this protocol service</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The file system ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cpfs-099394bd928c****</para>
            /// </summary>
            [NameInMap("FileSystemId")]
            [Validation(Required=false)]
            public string FileSystemId { get; set; }

            /// <summary>
            /// <para>The base throughput of the protocol node. Unit: MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InstanceBaseThroughput")]
            [Validation(Required=false)]
            public int? InstanceBaseThroughput { get; set; }

            /// <summary>
            /// <para>The burst throughput of the protocol node. Unit: MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("InstanceBurstThroughput")]
            [Validation(Required=false)]
            public int? InstanceBurstThroughput { get; set; }

            /// <summary>
            /// <para>The memory cache size of the protocol node. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("InstanceRAM")]
            [Validation(Required=false)]
            public int? InstanceRAM { get; set; }

            /// <summary>
            /// <para>The time when the protocol service was last modified, in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2018-12-12T07:28:38Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <para>The total number of CPFS directories and filesets exported in this protocol service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MountTargetCount")]
            [Validation(Required=false)]
            public int? MountTargetCount { get; set; }

            /// <summary>
            /// <para>The protocol service ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ptc-197ed6a00f2b****</para>
            /// </summary>
            [NameInMap("ProtocolServiceId")]
            [Validation(Required=false)]
            public string ProtocolServiceId { get; set; }

            /// <summary>
            /// <para>The specification of the protocol service cluster.</para>
            /// <list type="bullet">
            /// <item><description>Valid values: General</description></item>
            /// <item><description>Default value: General</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>General</para>
            /// </summary>
            [NameInMap("ProtocolSpec")]
            [Validation(Required=false)]
            public string ProtocolSpec { get; set; }

            /// <summary>
            /// <para>The throughput of the protocol service. Unit: MB/s.</para>
            /// 
            /// <b>Example:</b>
            /// <para>500</para>
            /// </summary>
            [NameInMap("ProtocolThroughput")]
            [Validation(Required=false)]
            public int? ProtocolThroughput { get; set; }

            /// <summary>
            /// <para>The protocol type supported by the protocol service.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>NFS: The protocol service supports NFS protocol access.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>NFS</para>
            /// </summary>
            [NameInMap("ProtocolType")]
            [Validation(Required=false)]
            public string ProtocolType { get; set; }

            /// <summary>
            /// <para>The status of the protocol service.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Creating: The protocol service is being created.</description></item>
            /// <item><description>Starting: The protocol service is being started.</description></item>
            /// <item><description>Running: The protocol service is available.</description></item>
            /// <item><description>Updating: The protocol service is being updated.</description></item>
            /// <item><description>Deleting: The protocol service is being deleted.</description></item>
            /// <item><description>Stopping: The protocol service is being stopped.</description></item>
            /// <item><description>Stopped: The protocol service is stopped.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The vSwitch ID associated with the protocol service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-123xxx</para>
            /// </summary>
            [NameInMap("VSwitchId")]
            [Validation(Required=false)]
            public string VSwitchId { get; set; }

            /// <summary>
            /// <para>The VPC ID associated with the protocol service.</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpc-123xxx</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
