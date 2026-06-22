// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeTotalStatisticsResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of asset logon attempts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Account")]
        [Validation(Required=false)]
        public int? Account { get; set; }

        /// <summary>
        /// <para>The total number of unfixed baseline check items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Health")]
        [Validation(Required=false)]
        public int? Health { get; set; }

        /// <summary>
        /// <para>The total number of baseline check items.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HealthTotal")]
        [Validation(Required=false)]
        public int? HealthTotal { get; set; }

        /// <summary>
        /// <para>The total number of fixed baseline check items. This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HealthdealedTotal")]
        [Validation(Required=false)]
        public int? HealthdealedTotal { get; set; }

        /// <summary>
        /// <para>The number of baseline check items with the high urgency level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HealthhighTotal")]
        [Validation(Required=false)]
        public int? HealthhighTotal { get; set; }

        /// <summary>
        /// <para>The number of baseline check items with the low urgency level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HealthlowTotal")]
        [Validation(Required=false)]
        public int? HealthlowTotal { get; set; }

        /// <summary>
        /// <para>The number of medium-level baseline risks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HealthmediumTotal")]
        [Validation(Required=false)]
        public int? HealthmediumTotal { get; set; }

        /// <summary>
        /// <para>The number of baseline check items with the critical urgency level. This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("HealthseriousTotal")]
        [Validation(Required=false)]
        public int? HealthseriousTotal { get; set; }

        /// <summary>
        /// <para>The number of Server Guard or Security Center alerts.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If <b>Type</b> is <b>sas</b>, this value indicates the number of Security Center alerts.</description></item>
        /// <item><description>If <b>Type</b> is <b>aqs</b>, this value indicates the number of Server Guard alerts.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Newsuspicious")]
        [Validation(Required=false)]
        public int? Newsuspicious { get; set; }

        /// <summary>
        /// <para>Indicates whether the client is online. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Online.</description></item>
        /// <item><description><b>false</b>: Offline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Online")]
        [Validation(Required=false)]
        public bool? Online { get; set; }

        /// <summary>
        /// <para>The number of Web-CMS vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Patch")]
        [Validation(Required=false)]
        public int? Patch { get; set; }

        /// <summary>
        /// <para>The request ID. Alibaba Cloud generates a unique identifier for each API request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A4EB8B1C-1DEC-5E18-BCD0-D1BBB3936FA7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The number of Server Guard security alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Suspicious")]
        [Validation(Required=false)]
        public int? Suspicious { get; set; }

        /// <summary>
        /// <para>The total number of security alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SuspiciousTotal")]
        [Validation(Required=false)]
        public int? SuspiciousTotal { get; set; }

        /// <summary>
        /// <para>The number of handled security alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SuspiciousdealedTotal")]
        [Validation(Required=false)]
        public int? SuspiciousdealedTotal { get; set; }

        /// <summary>
        /// <para>The total number of security alerts. This field is deprecated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SuspicioushighTotal")]
        [Validation(Required=false)]
        public int? SuspicioushighTotal { get; set; }

        /// <summary>
        /// <para>The number of alerts with the reminder severity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SuspiciouslowTotal")]
        [Validation(Required=false)]
        public int? SuspiciouslowTotal { get; set; }

        /// <summary>
        /// <para>The number of alerts with the suspicious severity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>28</para>
        /// </summary>
        [NameInMap("SuspiciousmediumTotal")]
        [Validation(Required=false)]
        public int? SuspiciousmediumTotal { get; set; }

        /// <summary>
        /// <para>The number of alerts with the critical severity level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SuspiciousseriousTotal")]
        [Validation(Required=false)]
        public int? SuspiciousseriousTotal { get; set; }

        /// <summary>
        /// <para>The number of WebShell alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Trojan")]
        [Validation(Required=false)]
        public int? Trojan { get; set; }

        /// <summary>
        /// <para>The number of unfixed vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("Vul")]
        [Validation(Required=false)]
        public int? Vul { get; set; }

        /// <summary>
        /// <para>The number of high-priority vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16</para>
        /// </summary>
        [NameInMap("VulAsapSum")]
        [Validation(Required=false)]
        public int? VulAsapSum { get; set; }

        /// <summary>
        /// <para>The total number of fixed vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulDealedTotal")]
        [Validation(Required=false)]
        public int? VulDealedTotal { get; set; }

        /// <summary>
        /// <para>The number of medium-priority vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulLaterSum")]
        [Validation(Required=false)]
        public int? VulLaterSum { get; set; }

        /// <summary>
        /// <para>The number of low-priority vulnerabilities to be fixed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulNntfSum")]
        [Validation(Required=false)]
        public int? VulNntfSum { get; set; }

        /// <summary>
        /// <para>The number of vulnerabilities.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VulTotal")]
        [Validation(Required=false)]
        public int? VulTotal { get; set; }

    }

}
