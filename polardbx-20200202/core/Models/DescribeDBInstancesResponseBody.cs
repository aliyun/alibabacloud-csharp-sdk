// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesResponseBodyDBInstances> DBInstances { get; set; }
        public class DescribeDBInstancesResponseBodyDBInstances : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>pxc-c-dmlgit****</para>
            /// </summary>
            [NameInMap("CdcInstanceName")]
            [Validation(Required=false)]
            public string CdcInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polarx.x4.large.2e</para>
            /// </summary>
            [NameInMap("CnNodeClassCode")]
            [Validation(Required=false)]
            public string CnNodeClassCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CnNodeCount")]
            [Validation(Required=false)]
            public int? CnNodeCount { get; set; }

            [NameInMap("ColumnarInstanceName")]
            [Validation(Required=false)]
            public string ColumnarInstanceName { get; set; }

            [NameInMap("ColumnarReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ColumnarReadDBInstances { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>drds_polarxpre_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContainBinlogX")]
            [Validation(Required=false)]
            public bool? ContainBinlogX { get; set; }

            [NameInMap("CpuType")]
            [Validation(Required=false)]
            public string CpuType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-11-01T03:49:50.000+0000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pxc-xxxxx</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>mysql.n4.medium.25</para>
            /// </summary>
            [NameInMap("DnNodeClassCode")]
            [Validation(Required=false)]
            public string DnNodeClassCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DnNodeCount")]
            [Validation(Required=false)]
            public int? DnNodeCount { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-12-01T16:00:00.000+0000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pxc-hzr2yeov9jmg3z</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polarx-kernel_5.4.12-16349923_xcluster-20210926</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>polarx.x4.large.2e</para>
            /// </summary>
            [NameInMap("NodeClass")]
            [Validation(Required=false)]
            public string NodeClass { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesNodes> Nodes { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesNodes : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>polarx.x4.large.2e</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>if can be null:</b>
                /// <c>true</c>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g-aliyun</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Prepaid</para>
            /// </summary>
            [NameInMap("PayType")]
            [Validation(Required=false)]
            public string PayType { get; set; }

            [NameInMap("PrimaryInstanceId")]
            [Validation(Required=false)]
            public string PrimaryInstanceId { get; set; }

            /// <summary>
            /// <para>主可用区。</para>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            [NameInMap("ReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ReadDBInstances { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rg-xxxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>次可用区。</para>
            /// </summary>
            [NameInMap("SecondaryZone")]
            [Validation(Required=false)]
            public string SecondaryZone { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Running</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("StorageType")]
            [Validation(Required=false)]
            public string StorageType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>40658534400</para>
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportBinlogX")]
            [Validation(Required=false)]
            public bool? SupportBinlogX { get; set; }

            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesTagSet> TagSet { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesTagSet : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>第三可用区。</para>
            /// </summary>
            [NameInMap("TertiaryZone")]
            [Validation(Required=false)]
            public string TertiaryZone { get; set; }

            /// <summary>
            /// <para>拓扑类型：</para>
            /// <list type="bullet">
            /// <item><description><b>3azones</b>：三可用区；</description></item>
            /// <item><description><b>1azone</b>：单可用区。</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ReadWrite</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>VPC ID。</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPCID</para>
            /// </summary>
            [NameInMap("VPCId")]
            [Validation(Required=false)]
            public string VPCId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou-g</para>
            /// </summary>
            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

            [NameInMap("gdnRole")]
            [Validation(Required=false)]
            public string GdnRole { get; set; }

            [NameInMap("isInGdn")]
            [Validation(Required=false)]
            public bool? IsInGdn { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
