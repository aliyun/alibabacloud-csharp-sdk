// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeGdnInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of instance details.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGdnInstancesResponseBodyData Data { get; set; }
        public class DescribeGdnInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of GDN instances.</para>
            /// </summary>
            [NameInMap("GdnInstanceList")]
            [Validation(Required=false)]
            public List<DescribeGdnInstancesResponseBodyDataGdnInstanceList> GdnInstanceList { get; set; }
            public class DescribeGdnInstancesResponseBodyDataGdnInstanceList : TeaModel {
                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The GDN instance name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>gdn-***</para>
                /// </summary>
                [NameInMap("GdnInstanceName")]
                [Validation(Required=false)]
                public string GdnInstanceName { get; set; }

                [NameInMap("GdnMode")]
                [Validation(Required=false)]
                public string GdnMode { get; set; }

                /// <summary>
                /// <para>The creation time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-01-02T13:11:10.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                /// <summary>
                /// <para>The list of members.</para>
                /// </summary>
                [NameInMap("MemberList")]
                [Validation(Required=false)]
                public List<DescribeGdnInstancesResponseBodyDataGdnInstanceListMemberList> MemberList { get; set; }
                public class DescribeGdnInstancesResponseBodyDataGdnInstanceListMemberList : TeaModel {
                    /// <summary>
                    /// <para>The instance type.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polarx.x4.medium.2e</para>
                    /// </summary>
                    [NameInMap("ClassCode")]
                    [Validation(Required=false)]
                    public string ClassCode { get; set; }

                    /// <summary>
                    /// <para>The CN node specifications. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>polarx.x4.medium.2e</b>: 2 cores, 8 GB</description></item>
                    /// <item><description><b>polarx.x4.large.2e</b>: 4 cores, 16 GB</description></item>
                    /// <item><description><b>polarx.x8.large.2e</b>: 4 cores, 32 GB</description></item>
                    /// <item><description><b>polarx.x4.xlarge.2e</b>: 8 cores, 32 GB</description></item>
                    /// <item><description><b>polarx.x8.xlarge.2e</b>: 8 cores, 64 GB</description></item>
                    /// <item><description><b>polarx.x4.2xlarge.2e</b>: 16 cores, 64 GB</description></item>
                    /// <item><description><b>polarx.x8.2xlarge.2e</b>: 16 cores, 128 GB</description></item>
                    /// <item><description><b>polarx.x4.4xlarge.2e</b>: 32 cores, 128 GB</description></item>
                    /// <item><description><b>polarx.x8.4xlarge.2e</b>: 32 cores, 256 GB</description></item>
                    /// <item><description><b>polarx.st.8xlarge.2e</b>: 60 cores, 470 GB</description></item>
                    /// <item><description><b>polarx.st.12xlarge.2e</b>: 90 cores, 720 GB.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>polarx.x4.medium.2e</para>
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
                    public string CnNodeCount { get; set; }

                    /// <summary>
                    /// <para>The commodity code.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>drds_polarxpre_public_cn</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

                    [NameInMap("DataSyncStatus")]
                    [Validation(Required=false)]
                    public string DataSyncStatus { get; set; }

                    /// <summary>
                    /// <para>The DN node specifications. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>mysql.n2.medium.25</b>: 2 cores, 4 GB</description></item>
                    /// <item><description><b>mysql.n4.medium.25</b>: 2 cores, 8 GB</description></item>
                    /// <item><description><b>mysql.x8.medium.25</b>: 2 cores, 16 GB</description></item>
                    /// <item><description><b>mysql.n2.large.25</b>: 4 cores, 8 GB</description></item>
                    /// <item><description><b>mysql.n4.large.25</b>: 4 cores, 16 GB</description></item>
                    /// <item><description><b>mysql.x8.large.25</b>: 4 cores, 32 GB</description></item>
                    /// <item><description><b>mysql.n2.xlarge.25</b>: 8 cores, 16 GB</description></item>
                    /// <item><description><b>mysql.n4.xlarge.25</b>: 8 cores, 32 GB</description></item>
                    /// <item><description><b>mysql.x8.xlarge.25</b>: 8 cores, 64 GB</description></item>
                    /// <item><description><b>mysql.n4.2xlarge.25</b>: 16 cores, 64 GB</description></item>
                    /// <item><description><b>mysql.x8.2xlarge.25</b>: 16 cores, 128 GB</description></item>
                    /// <item><description><b>mysql.x4.4xlarge.25</b>: 32 cores, 128 GB</description></item>
                    /// <item><description><b>mysql.x8.4xlarge.25</b>: 32 cores, 256 GB</description></item>
                    /// <item><description><b>mysql.st.8xlarge.25</b>: 60 cores, 470 GB</description></item>
                    /// <item><description><b>mysql.st.12xlarge.25</b>: 90 cores, 720 GB.</description></item>
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
                    public string DnNodeCount { get; set; }

                    /// <summary>
                    /// <para>The expiration time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-02T13:11:10.000+0000</para>
                    /// </summary>
                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public string ExpireTime { get; set; }

                    /// <summary>
                    /// <para>The creation time.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>2025-01-02T13:11:10.000+0000</para>
                    /// </summary>
                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public string GmtCreated { get; set; }

                    /// <summary>
                    /// <para>The member name (PolarDB-X instance name).</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>pxc-***</para>
                    /// </summary>
                    [NameInMap("MemberName")]
                    [Validation(Required=false)]
                    public string MemberName { get; set; }

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

                    /// <summary>
                    /// <para>The primary zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("PrimaryZone")]
                    [Validation(Required=false)]
                    public string PrimaryZone { get; set; }

                    [NameInMap("ReadWriteStatus")]
                    [Validation(Required=false)]
                    public string ReadWriteStatus { get; set; }

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
                    /// <para>The member role.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>primary、
                    /// standby</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <para>The secondary zone.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("SecondaryZone")]
                    [Validation(Required=false)]
                    public string SecondaryZone { get; set; }

                    /// <summary>
                    /// <para>The data latency.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1s</para>
                    /// </summary>
                    [NameInMap("SecondsBehindMaster")]
                    [Validation(Required=false)]
                    public string SecondsBehindMaster { get; set; }

                    /// <summary>
                    /// <para>The member status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>Creating</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <para>The switchover task status.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>prepared：参数初始化完毕
                    /// set_old_primary_readonly：原主实例已禁写
                    /// set_new_primary_read_write：已切换
                    /// timeout：任务超时
                    /// rollback：已回滚</para>
                    /// </summary>
                    [NameInMap("TaskStatus")]
                    [Validation(Required=false)]
                    public string TaskStatus { get; set; }

                    /// <summary>
                    /// <para>The zone for Three-zone deployment. This zone is active only when three-zone deployment is enabled.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("TertiaryZone")]
                    [Validation(Required=false)]
                    public string TertiaryZone { get; set; }

                    /// <summary>
                    /// <para>The zone ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// <para>The MySQL version supported by the instance.</para>
                /// 
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("MysqlVersion")]
                [Validation(Required=false)]
                public string MysqlVersion { get; set; }

                [NameInMap("RplConflictStrategy")]
                [Validation(Required=false)]
                public string RplConflictStrategy { get; set; }

                [NameInMap("RplDmlStrategy")]
                [Validation(Required=false)]
                public string RplDmlStrategy { get; set; }

                [NameInMap("RplSyncDdl")]
                [Validation(Required=false)]
                public bool? RplSyncDdl { get; set; }

                /// <summary>
                /// <para>The status.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Creating</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <para>The switchover log.</para>
                /// 
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("SwitchHistory")]
                [Validation(Required=false)]
                public string SwitchHistory { get; set; }

            }

            /// <summary>
            /// <para>The page number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <para>The page size.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("TotalNumber")]
            [Validation(Required=false)]
            public string TotalNumber { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// <remarks>
        /// <para>This parameter is empty when the request succeeds. When the request fails, an exception message is returned, such as an error code.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7B044BD1-6402-5DE9-9AED-63D15A994E37</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
