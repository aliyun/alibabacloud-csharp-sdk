// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class DescribeNodeResponseBody : TeaModel {
        /// <summary>
        /// <para>Cluster ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i116913051662373010974</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Cluster name</para>
        /// 
        /// <b>Example:</b>
        /// <para>Standard_Cluster</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>Creation time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-09-30T03:35:53Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>Disk infos</para>
        /// </summary>
        [NameInMap("Disks")]
        [Validation(Required=false)]
        public List<DescribeNodeResponseBodyDisks> Disks { get; set; }
        public class DescribeNodeResponseBodyDisks : TeaModel {
            /// <summary>
            /// <para>The category of the disk.</para>
            /// <list type="bullet">
            /// <item><description>cloud_ssd: all-flash disk.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>cloud_essd</para>
            /// </summary>
            [NameInMap("Category")]
            [Validation(Required=false)]
            public string Category { get; set; }

            /// <summary>
            /// <para>The ID of the disk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>d-bp1fi88ryk4yah8a6yos</para>
            /// </summary>
            [NameInMap("DiskId")]
            [Validation(Required=false)]
            public string DiskId { get; set; }

            /// <summary>
            /// <para>The performance level of the ESSD. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PL0: A single ESSD can deliver up to 10,000 random read/write IOPS.</description></item>
            /// <item><description>PL1: A single ESSD can deliver up to 50,000 random read/write IOPS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PL1</para>
            /// </summary>
            [NameInMap("PerformanceLevel")]
            [Validation(Required=false)]
            public string PerformanceLevel { get; set; }

            /// <summary>
            /// <para>The size of the disk. Unit: GiB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public int? Size { get; set; }

            /// <summary>
            /// <para>The type of the disk. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>system: system disk</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>system</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Expiration time</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-06-23T16:00:00Z</para>
        /// </summary>
        [NameInMap("ExpiredTime")]
        [Validation(Required=false)]
        public string ExpiredTime { get; set; }

        /// <summary>
        /// <para>是否支持文件存储挂载</para>
        /// </summary>
        [NameInMap("FileSystemMountEnabled")]
        [Validation(Required=false)]
        public bool? FileSystemMountEnabled { get; set; }

        /// <summary>
        /// <para>Hostname</para>
        /// 
        /// <b>Example:</b>
        /// <para>31d38530-241e-11ed-bc63-acde48001122</para>
        /// </summary>
        [NameInMap("Hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>Cluster number</para>
        /// 
        /// <b>Example:</b>
        /// <para>A1</para>
        /// </summary>
        [NameInMap("HpnZone")]
        [Validation(Required=false)]
        public string HpnZone { get; set; }

        /// <summary>
        /// <para>Image ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>i190297201634099844192</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>Image name</para>
        /// 
        /// <b>Example:</b>
        /// <para>Centos7.9_all_0811</para>
        /// </summary>
        [NameInMap("ImageName")]
        [Validation(Required=false)]
        public string ImageName { get; set; }

        /// <summary>
        /// <para>Machine type</para>
        /// 
        /// <b>Example:</b>
        /// <para>efg1.nvga1</para>
        /// </summary>
        [NameInMap("MachineType")]
        [Validation(Required=false)]
        public string MachineType { get; set; }

        /// <summary>
        /// <para>Network information</para>
        /// </summary>
        [NameInMap("Networks")]
        [Validation(Required=false)]
        public List<DescribeNodeResponseBodyNetworks> Networks { get; set; }
        public class DescribeNodeResponseBodyNetworks : TeaModel {
            /// <summary>
            /// <para>Network interface port information</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bond0</para>
            /// </summary>
            [NameInMap("BondName")]
            [Validation(Required=false)]
            public string BondName { get; set; }

            /// <summary>
            /// <para>Machine IP</para>
            /// 
            /// <b>Example:</b>
            /// <para>47.254.235.44</para>
            /// </summary>
            [NameInMap("Ip")]
            [Validation(Required=false)]
            public string Ip { get; set; }

            /// <summary>
            /// <para>Cluster subnet ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vsw-uf68v51fldm5egmui5a6k</para>
            /// </summary>
            [NameInMap("SubnetId")]
            [Validation(Required=false)]
            public string SubnetId { get; set; }

            /// <summary>
            /// <para>Cluster network ID</para>
            /// 
            /// <b>Example:</b>
            /// <para>vpd-xcuhjyrj</para>
            /// </summary>
            [NameInMap("VpdId")]
            [Validation(Required=false)]
            public string VpdId { get; set; }

        }

        /// <summary>
        /// <para>Node group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>ng-ec3c96ff0aa4c60d</para>
        /// </summary>
        [NameInMap("NodeGroupId")]
        [Validation(Required=false)]
        public string NodeGroupId { get; set; }

        /// <summary>
        /// <para>Node group name</para>
        /// 
        /// <b>Example:</b>
        /// <para>emr-default</para>
        /// </summary>
        [NameInMap("NodeGroupName")]
        [Validation(Required=false)]
        public string NodeGroupName { get; set; }

        /// <summary>
        /// <para>Node ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>e01-cn-zvp2tgykr08</para>
        /// </summary>
        [NameInMap("NodeId")]
        [Validation(Required=false)]
        public string NodeId { get; set; }

        /// <summary>
        /// <para>Node status</para>
        /// 
        /// <b>Example:</b>
        /// <para>Using</para>
        /// </summary>
        [NameInMap("OperatingState")]
        [Validation(Required=false)]
        public string OperatingState { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>AC4F0004-7BCE-52E0-891B-CAC7D64E3368</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Resource group ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmywpvugkh7kq</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Unique machine identifier</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag42ckf4jx</para>
        /// </summary>
        [NameInMap("Sn")]
        [Validation(Required=false)]
        public string Sn { get; set; }

        /// <summary>
        /// <para>The script by user defined</para>
        /// 
        /// <b>Example:</b>
        /// <para>#!/bin/bash
        /// uptime
        /// echo &quot;aaaaaaa&quot; &gt;&gt; /tmp/ttttt20250110141010.sh</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

        /// <summary>
        /// <para>Zone ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou-i</para>
        /// </summary>
        [NameInMap("ZoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
