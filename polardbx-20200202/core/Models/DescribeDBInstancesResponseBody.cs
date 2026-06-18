// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeDBInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instances.</para>
        /// </summary>
        [NameInMap("DBInstances")]
        [Validation(Required=false)]
        public List<DescribeDBInstancesResponseBodyDBInstances> DBInstances { get; set; }
        public class DescribeDBInstancesResponseBodyDBInstances : TeaModel {
            /// <summary>
            /// <para>The name of the log node.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-c-dmlgit****</para>
            /// </summary>
            [NameInMap("CdcInstanceName")]
            [Validation(Required=false)]
            public string CdcInstanceName { get; set; }

            /// <summary>
            /// <para>The CN node specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>polarx.x4.medium.2e</b>: 2 cores, 8 GB memory</description></item>
            /// <item><description><b>polarx.x4.large.2e</b>: 4 cores, 16 GB memory</description></item>
            /// <item><description><b>polarx.x8.large.2e</b>: 4 cores, 32 GB memory</description></item>
            /// <item><description><b>polarx.x4.xlarge.2e</b>: 8 cores, 32 GB memory</description></item>
            /// <item><description><b>polarx.x8.xlarge.2e</b>: 8 cores, 64 GB memory</description></item>
            /// <item><description><b>polarx.x4.2xlarge.2e</b>: 16 cores, 64 GB memory</description></item>
            /// <item><description><b>polarx.x8.2xlarge.2e</b>: 16 cores, 128 GB memory</description></item>
            /// <item><description><b>polarx.x4.4xlarge.2e</b>: 32 cores, 128 GB memory</description></item>
            /// <item><description><b>polarx.x8.4xlarge.2e</b>: 32 cores, 256 GB memory</description></item>
            /// <item><description><b>polarx.st.8xlarge.2e</b>: 60 cores, 470 GB memory</description></item>
            /// <item><description><b>polarx.st.12xlarge.2e</b>: 90 cores, 720 GB memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>polarx.x4.large.2e</para>
            /// </summary>
            [NameInMap("CnNodeClassCode")]
            [Validation(Required=false)]
            public string CnNodeClassCode { get; set; }

            /// <summary>
            /// <para>The number of CN nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("CnNodeCount")]
            [Validation(Required=false)]
            public int? CnNodeCount { get; set; }

            /// <summary>
            /// <para>The name of the column store engine instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxxxxxxx</para>
            /// </summary>
            [NameInMap("ColumnarInstanceName")]
            [Validation(Required=false)]
            public string ColumnarInstanceName { get; set; }

            /// <summary>
            /// <para>The column store read-only instance information.</para>
            /// </summary>
            [NameInMap("ColumnarReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ColumnarReadDBInstances { get; set; }

            /// <summary>
            /// <para>The commodity code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>drds_polarxpre_public_cn</para>
            /// </summary>
            [NameInMap("CommodityCode")]
            [Validation(Required=false)]
            public string CommodityCode { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance contains the multi-stream log service. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: The instance contains the multi-stream log service.</description></item>
            /// <item><description><b>false</b>: The instance does not contain the multi-stream log service.</description></item>
            /// </list>
            /// 
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
            /// <para>The creation time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-11-01T03:49:50.000+0000</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The name of the database instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-xxxxx</para>
            /// </summary>
            [NameInMap("DBInstanceName")]
            [Validation(Required=false)]
            public string DBInstanceName { get; set; }

            /// <summary>
            /// <para>The database type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("DBType")]
            [Validation(Required=false)]
            public string DBType { get; set; }

            /// <summary>
            /// <para>The database version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5.7</para>
            /// </summary>
            [NameInMap("DBVersion")]
            [Validation(Required=false)]
            public string DBVersion { get; set; }

            /// <summary>
            /// <para>The database description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>测试</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The DN node specifications. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>mysql.n2.medium.25</b>: 2 cores, 4 GB memory</description></item>
            /// <item><description><b>mysql.n4.medium.25</b>: 2 cores, 8 GB memory</description></item>
            /// <item><description><b>mysql.x8.medium.25</b>: 2 cores, 16 GB memory</description></item>
            /// <item><description><b>mysql.n2.large.25</b>: 4 cores, 8 GB memory</description></item>
            /// <item><description><b>mysql.n4.large.25</b>: 4 cores, 16 GB memory</description></item>
            /// <item><description><b>mysql.x8.large.25</b>: 4 cores, 32 GB memory</description></item>
            /// <item><description><b>mysql.n2.xlarge.25</b>: 8 cores, 16 GB memory</description></item>
            /// <item><description><b>mysql.n4.xlarge.25</b>: 8 cores, 32 GB memory</description></item>
            /// <item><description><b>mysql.x8.xlarge.25</b>: 8 cores, 64 GB memory</description></item>
            /// <item><description><b>mysql.n4.2xlarge.25</b>: 16 cores, 64 GB memory</description></item>
            /// <item><description><b>mysql.x8.2xlarge.25</b>: 16 cores, 128 GB memory</description></item>
            /// <item><description><b>mysql.x4.4xlarge.25</b>: 32 cores, 128 GB memory</description></item>
            /// <item><description><b>mysql.x8.4xlarge.25</b>: 32 cores, 256 GB memory</description></item>
            /// <item><description><b>mysql.st.8xlarge.25</b>: 60 cores, 470 GB memory</description></item>
            /// <item><description><b>mysql.st.12xlarge.25</b>: 90 cores, 720 GB memory.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>mysql.n4.medium.25</para>
            /// </summary>
            [NameInMap("DnNodeClassCode")]
            [Validation(Required=false)]
            public string DnNodeClassCode { get; set; }

            /// <summary>
            /// <para>The number of DN nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("DnNodeCount")]
            [Validation(Required=false)]
            public int? DnNodeCount { get; set; }

            /// <summary>
            /// <para>The engine type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx</para>
            /// </summary>
            [NameInMap("Engine")]
            [Validation(Required=false)]
            public string Engine { get; set; }

            [NameInMap("EngineVersion")]
            [Validation(Required=false)]
            public string EngineVersion { get; set; }

            /// <summary>
            /// <para>The expiration time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-01T16:00:00.000+0000</para>
            /// </summary>
            [NameInMap("ExpireTime")]
            [Validation(Required=false)]
            public string ExpireTime { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance has expired.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("Expired")]
            [Validation(Required=false)]
            public bool? Expired { get; set; }

            /// <summary>
            /// <para>The instance ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pxc-hzr2yeov******</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance is locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Unlock</para>
            /// </summary>
            [NameInMap("LockMode")]
            [Validation(Required=false)]
            public string LockMode { get; set; }

            /// <summary>
            /// <para>The reason why the instance is locked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>欠费</para>
            /// </summary>
            [NameInMap("LockReason")]
            [Validation(Required=false)]
            public string LockReason { get; set; }

            /// <summary>
            /// <para>The current Milvus version.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx-kernel_5.4.12-16349923_xcluster-20210926</para>
            /// </summary>
            [NameInMap("MinorVersion")]
            [Validation(Required=false)]
            public string MinorVersion { get; set; }

            /// <summary>
            /// <para>The network type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>VPC</para>
            /// </summary>
            [NameInMap("Network")]
            [Validation(Required=false)]
            public string Network { get; set; }

            /// <summary>
            /// <para>The node specifications.</para>
            /// 
            /// <b>Example:</b>
            /// <para>polarx.x4.large.2e</para>
            /// </summary>
            [NameInMap("NodeClass")]
            [Validation(Required=false)]
            public string NodeClass { get; set; }

            /// <summary>
            /// <para>The number of nodes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("NodeCount")]
            [Validation(Required=false)]
            public int? NodeCount { get; set; }

            /// <summary>
            /// <para>The list of nodes.</para>
            /// </summary>
            [NameInMap("Nodes")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesNodes> Nodes { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesNodes : TeaModel {
                /// <summary>
                /// <para>The instance specifications.</para>
                /// 
                /// <b>Example:</b>
                /// <para>polarx.x4.large.2e</para>
                /// </summary>
                [NameInMap("ClassCode")]
                [Validation(Required=false)]
                public string ClassCode { get; set; }

                /// <summary>
                /// <para>The node ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>pxi-zd89wrzqh******</para>
                /// </summary>
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
                /// <para>The region ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g-aliyun</para>
                /// </summary>
                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                /// <summary>
                /// <para>The zone ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou-g</para>
                /// </summary>
                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

            /// <summary>
            /// <para>The billing method of the instance. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>Postpaid</b>: pay-as-you-go.</description></item>
            /// <item><description><b>Prepaid</b>: subscription.</description></item>
            /// </list>
            /// 
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
            /// <para>The primary zone.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-j</para>
            /// </summary>
            [NameInMap("PrimaryZone")]
            [Validation(Required=false)]
            public string PrimaryZone { get; set; }

            /// <summary>
            /// <para>The list of read-only instances.</para>
            /// </summary>
            [NameInMap("ReadDBInstances")]
            [Validation(Required=false)]
            public List<string> ReadDBInstances { get; set; }

            /// <summary>
            /// <para>The region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The resource group ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rg-xxxxxx</para>
            /// </summary>
            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            /// <summary>
            /// <para>The secondary zone.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-l</para>
            /// </summary>
            [NameInMap("SecondaryZone")]
            [Validation(Required=false)]
            public string SecondaryZone { get; set; }

            /// <summary>
            /// <para>The instance edition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>enterprise</b>: Enterprise Edition.</description></item>
            /// <item><description><b>standard</b>: Standard Edition.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>enterprise</para>
            /// </summary>
            [NameInMap("Series")]
            [Validation(Required=false)]
            public string Series { get; set; }

            /// <summary>
            /// <para>The instance status. For more information, see <a href="https://help.aliyun.com/document_detail/339826.html">Instance status table</a>.</para>
            /// 
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
            /// <para>The storage usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>40658534400</para>
            /// </summary>
            [NameInMap("StorageUsed")]
            [Validation(Required=false)]
            public long? StorageUsed { get; set; }

            /// <summary>
            /// <para>Indicates whether the instance supports multi-stream. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("SupportBinlogX")]
            [Validation(Required=false)]
            public bool? SupportBinlogX { get; set; }

            /// <summary>
            /// <para>The set of tags.</para>
            /// </summary>
            [NameInMap("TagSet")]
            [Validation(Required=false)]
            public List<DescribeDBInstancesResponseBodyDBInstancesTagSet> TagSet { get; set; }
            public class DescribeDBInstancesResponseBodyDBInstancesTagSet : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>key1</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>value1</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The third zone in the three-zone deployment.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou-k</para>
            /// </summary>
            [NameInMap("TertiaryZone")]
            [Validation(Required=false)]
            public string TertiaryZone { get; set; }

            /// <summary>
            /// <para>The topology type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>3azones</b>: three-zone deployment.</description></item>
            /// <item><description><b>1azone</b>: single-zone deployment.</description></item>
            /// </list>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3azones</para>
            /// </summary>
            [NameInMap("TopologyType")]
            [Validation(Required=false)]
            public string TopologyType { get; set; }

            /// <summary>
            /// <para>The instance type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>ReadWrite</b>: primary instance.</description></item>
            /// <item><description><b>ReadOnly</b>: read-only instance.</description></item>
            /// </list>
            /// 
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
            /// <para>The zone ID.</para>
            /// 
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
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C458B1E8-1683-3645-B154-6BA32080EEA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("TotalNumber")]
        [Validation(Required=false)]
        public int? TotalNumber { get; set; }

    }

}
