// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class DescribeRdsVpcsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>4C1A7CFB-9F73-5041-8C74-27626E58985A</para>
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
                /// <para>314****36</para>
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
                /// <para>47.121.246.0/24</para>
                /// </summary>
                [NameInMap("CidrBlock")]
                [Validation(Required=false)]
                public string CidrBlock { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>Mon May 12 10:13:14 CST 2025</para>
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-09-29 17:47:56</para>
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>False</para>
                /// </summary>
                [NameInMap("IsDefault")]
                [Validation(Required=false)]
                public bool? IsDefault { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-shanghai</para>
                /// </summary>
                [NameInMap("RegionNo")]
                [Validation(Required=false)]
                public string RegionNo { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>True</para>
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
                    /// <para>10.0.0.0/24</para>
                    /// </summary>
                    [NameInMap("CidrBlock")]
                    [Validation(Required=false)]
                    public string CidrBlock { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1574156944000</para>
                    /// </summary>
                    [NameInMap("GmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>2025-09-03T19:19:13+08:00</para>
                    /// </summary>
                    [NameInMap("GmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>false</para>
                    /// </summary>
                    [NameInMap("IsDefault")]
                    [Validation(Required=false)]
                    public bool? IsDefault { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cn-beijing-g</para>
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
                    /// <para>vsw-8vbkwmpn****4nrd639ih</para>
                    /// </summary>
                    [NameInMap("VSwitchId")]
                    [Validation(Required=false)]
                    public string VSwitchId { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>cloud_auto_g</para>
                    /// </summary>
                    [NameInMap("VSwitchName")]
                    [Validation(Required=false)]
                    public string VSwitchName { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>vpc-2zekldxxy28nobay7o1f3</para>
                /// </summary>
                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cloud_auto_test</para>
                /// </summary>
                [NameInMap("VpcName")]
                [Validation(Required=false)]
                public string VpcName { get; set; }

            }

        }

    }

}
