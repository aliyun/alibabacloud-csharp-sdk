// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class DescribeSagWan4GResponseBody : TeaModel {
        /// <summary>
        /// <para>The IP address of the 4G NIC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("Ip")]
        [Validation(Required=false)]
        public string Ip { get; set; }

        /// <summary>
        /// <para>The MAC address of the 4G NIC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c4:00:ad:a2:f5:****</para>
        /// </summary>
        [NameInMap("Mac")]
        [Validation(Required=false)]
        public string Mac { get; set; }

        /// <summary>
        /// <para>The priority of the 4G NIC. The default value is <b>99</b>, which indicates the lowest priority. The priority cannot be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>99</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public int? Priority { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CE6642D4-21EB-4168-9BF9-F217953F9892</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the 4G NIC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: The status is normal.</description></item>
        /// <item><description><b>Abnormal</b>: The status is abnormal.</description></item>
        /// <item><description><b>Unavailable</b>: No 4G NIC is available.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The 4G signal strength. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>High</b>: Strong.</description></item>
        /// <item><description><b>Middle</b>: Medium.</description></item>
        /// <item><description><b>Low</b>: Weak.</description></item>
        /// <item><description><b>Unavailable</b>: No signal.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>High</para>
        /// </summary>
        [NameInMap("Strength")]
        [Validation(Required=false)]
        public string Strength { get; set; }

        /// <summary>
        /// <para>The traffic status of the 4G NIC. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>active</b>: The 4G NIC acts as the active link, and current traffic is transmitted through this 4G NIC.</description></item>
        /// <item><description><b>standby</b>: The 4G NIC acts as the standby link and does not forward traffic. If the active link fails, traffic is transmitted through this 4G NIC.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>active</para>
        /// </summary>
        [NameInMap("TrafficState")]
        [Validation(Required=false)]
        public string TrafficState { get; set; }

    }

}
