// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeRdsVpcsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>B45E8D29-EA17-5141-AE09-F7A399760C9E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Vpcs")]
        [Validation(Required=false)]
        public DescribeRdsVpcsResponseBodyVpcs Vpcs { get; set; }
        public class DescribeRdsVpcsResponseBodyVpcs : TeaModel {
            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public List<DescribeRdsVpcsResponseBodyVpcsVpc> Vpc { get; set; }
            public class DescribeRdsVpcsResponseBodyVpcsVpc : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1485293698******</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public string AliUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>26842</para>
                /// </summary>
                [NameInMap("Bid")]
                [Validation(Required=false)]
                public string Bid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10.21.0.0/16</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-08-28T02:25:41Z</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2025-04-30T09:41:14+08:00</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Available</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VSwitchs")]
                [Validation(Required=false)]
                public List<DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs> VSwitchs { get; set; }
                public class DescribeRdsVpcsResponseBodyVpcsVpcVSwitchs : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>192.168.7.0/24</para>
                    /// </summary>
                    [NameInMap("CidrBlock")]
                    [Validation(Required=false)]
                    public string CidrBlock { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-05-12 18:17:25</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-01-07T15:10:32+08:00</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>true</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-hangzhou-k</para>
                    /// </summary>
                    [NameInMap("IzNo")]
                    [Validation(Required=false)]
                    public string IzNo { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>Available</para>
                    /// </summary>
                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public string Status { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>vsw-**********</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>test</para>
                    /// </summary>
                    [NameInMap("VSwitchName")]
                    [Validation(Required=false)]
                    public string VSwitchName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-*************</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>fc-webide</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
