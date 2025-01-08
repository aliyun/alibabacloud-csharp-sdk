// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeGdnInstancesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeGdnInstancesResponseBodyData Data { get; set; }
        public class DescribeGdnInstancesResponseBodyData : TeaModel {
            [NameInMap("GdnInstanceList")]
            [Validation(Required=false)]
            public List<DescribeGdnInstancesResponseBodyDataGdnInstanceList> GdnInstanceList { get; set; }
            public class DescribeGdnInstancesResponseBodyDataGdnInstanceList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>gdn-***</para>
                /// </summary>
                [NameInMap("GdnInstanceName")]
                [Validation(Required=false)]
                public string GdnInstanceName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-01-02T13:11:10.000+0000</para>
                /// </summary>
                [NameInMap("GmtCreated")]
                [Validation(Required=false)]
                public string GmtCreated { get; set; }

                [NameInMap("MemberList")]
                [Validation(Required=false)]
                public List<DescribeGdnInstancesResponseBodyDataGdnInstanceListMemberList> MemberList { get; set; }
                public class DescribeGdnInstancesResponseBodyDataGdnInstanceListMemberList : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>polarx.x4.medium.2e</para>
                    /// </summary>
                    [NameInMap("ClassCode")]
                    [Validation(Required=false)]
                    public string ClassCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>polarx.x4.medium.2e</para>
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
                    public string CnNodeCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>drds_polarxpre_public_cn</para>
                    /// </summary>
                    [NameInMap("CommodityCode")]
                    [Validation(Required=false)]
                    public string CommodityCode { get; set; }

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
                    public string DnNodeCount { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-01-02T13:11:10.000+0000</para>
                    /// </summary>
                    [NameInMap("ExpireTime")]
                    [Validation(Required=false)]
                    public string ExpireTime { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-01-02T13:11:10.000+0000</para>
                    /// </summary>
                    [NameInMap("GmtCreated")]
                    [Validation(Required=false)]
                    public string GmtCreated { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>pxc-***</para>
                    /// </summary>
                    [NameInMap("MemberName")]
                    [Validation(Required=false)]
                    public string MemberName { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Prepaid</para>
                    /// </summary>
                    [NameInMap("PayType")]
                    [Validation(Required=false)]
                    public string PayType { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("PrimaryZone")]
                    [Validation(Required=false)]
                    public string PrimaryZone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou</para>
                    /// </summary>
                    [NameInMap("RegionId")]
                    [Validation(Required=false)]
                    public string RegionId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>primary、
                    /// standby</para>
                    /// </summary>
                    [NameInMap("Role")]
                    [Validation(Required=false)]
                    public string Role { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("SecondaryZone")]
                    [Validation(Required=false)]
                    public string SecondaryZone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1s</para>
                    /// </summary>
                    [NameInMap("SecondsBehindMaster")]
                    [Validation(Required=false)]
                    public string SecondsBehindMaster { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Creating</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("TertiaryZone")]
                    [Validation(Required=false)]
                    public string TertiaryZone { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-zhangjiakou-a</para>
                    /// </summary>
                    [NameInMap("ZoneId")]
                    [Validation(Required=false)]
                    public string ZoneId { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>5.7</para>
                /// </summary>
                [NameInMap("MysqlVersion")]
                [Validation(Required=false)]
                public string MysqlVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Creating</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("SwitchHistory")]
                [Validation(Required=false)]
                public string SwitchHistory { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public string PageNumber { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public string PageSize { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>130</para>
            /// </summary>
            [NameInMap("TotalNumber")]
            [Validation(Required=false)]
            public string TotalNumber { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>7B044BD1-6402-5DE9-9AED-63D15A994E37</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
