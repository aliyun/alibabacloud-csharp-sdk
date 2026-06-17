// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventTopAttackTypeResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BECDBF66-91DA-5B40-8B05-0D26541A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of the top attack types.</para>
        /// </summary>
        [NameInMap("TopAttackTypeList")]
        [Validation(Required=false)]
        public List<DescribeRiskEventTopAttackTypeResponseBodyTopAttackTypeList> TopAttackTypeList { get; set; }
        public class DescribeRiskEventTopAttackTypeResponseBodyTopAttackTypeList : TeaModel {
            /// <summary>
            /// <para>The number of attacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para>38</para>
            /// </summary>
            [NameInMap("AttackCnt")]
            [Validation(Required=false)]
            public long? AttackCnt { get; set; }

            /// <summary>
            /// <para>The attack type of the intrusion prevention event. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>1</b>: abnormal connection</para>
            /// </description></item>
            /// <item><description><para><b>2</b>: command execution</para>
            /// </description></item>
            /// <item><description><para><b>3</b>: brute-force attack</para>
            /// </description></item>
            /// <item><description><para><b>4</b>: scan</para>
            /// </description></item>
            /// <item><description><para><b>5</b>: other</para>
            /// </description></item>
            /// <item><description><para><b>6</b>: information leakage</para>
            /// </description></item>
            /// <item><description><para><b>7</b>: DoS attack</para>
            /// </description></item>
            /// <item><description><para><b>8</b>: overflow attack</para>
            /// </description></item>
            /// <item><description><para><b>9</b>: web attack</para>
            /// </description></item>
            /// <item><description><para><b>10</b>: trojan and backdoor</para>
            /// </description></item>
            /// <item><description><para><b>11</b>: virus and worm</para>
            /// </description></item>
            /// <item><description><para><b>12</b>: cryptomining</para>
            /// </description></item>
            /// <item><description><para><b>13</b>: reverse shell</para>
            /// </description></item>
            /// </list>
            /// <remarks>
            /// <para>By default, this API queries for all attack types.</para>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("AttackType")]
            [Validation(Required=false)]
            public long? AttackType { get; set; }

            /// <summary>
            /// <para>The number of protection triggers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>42</para>
            /// </summary>
            [NameInMap("ProtectCnt")]
            [Validation(Required=false)]
            public long? ProtectCnt { get; set; }

        }

        /// <summary>
        /// <para>The total number of attacks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>47</para>
        /// </summary>
        [NameInMap("TotalAttackCnt")]
        [Validation(Required=false)]
        public long? TotalAttackCnt { get; set; }

        /// <summary>
        /// <para>The total number of protection triggers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>65</para>
        /// </summary>
        [NameInMap("TotalProtectCnt")]
        [Validation(Required=false)]
        public long? TotalProtectCnt { get; set; }

    }

}
