// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class DescribeRiskEventStatisticRequest : TeaModel {
        /// <summary>
        /// <para>The attacked application.</para>
        /// </summary>
        [NameInMap("AttackApp")]
        [Validation(Required=false)]
        public List<string> AttackApp { get; set; }

        /// <summary>
        /// <para>The attack type of the intrusion prevention event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>1</b>: anomalous connection</para>
        /// </description></item>
        /// <item><description><para><b>2</b>: command execution</para>
        /// </description></item>
        /// <item><description><para><b>3</b>: brute-force attack</para>
        /// </description></item>
        /// <item><description><para><b>4</b>: scanning</para>
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
        /// <item><description><para><b>10</b>: trojan backdoor</para>
        /// </description></item>
        /// <item><description><para><b>11</b>: virus and worm</para>
        /// </description></item>
        /// <item><description><para><b>12</b>: mining</para>
        /// </description></item>
        /// <item><description><para><b>13</b>: reverse shell</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not specify this parameter, all attack types are queried.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("AttackType")]
        [Validation(Required=false)]
        public string AttackType { get; set; }

        /// <summary>
        /// <para>The edition of Cloud Firewall.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("BuyVersion")]
        [Validation(Required=false)]
        public string BuyVersion { get; set; }

        /// <summary>
        /// <para>The end time. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1534408267</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The language of the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the visitor.</para>
        /// 
        /// <b>Example:</b>
        /// <para>218.76.30.XXX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The start time. The value is a UNIX timestamp. Unit: seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1656664560</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
