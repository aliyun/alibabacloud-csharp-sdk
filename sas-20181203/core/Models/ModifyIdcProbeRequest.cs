// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifyIdcProbeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the data center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("IdcName")]
        [Validation(Required=false)]
        public string IdcName { get; set; }

        /// <summary>
        /// <para>The region ID of the data center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Hangzhou</para>
        /// </summary>
        [NameInMap("IdcRegion")]
        [Validation(Required=false)]
        public string IdcRegion { get; set; }

        /// <summary>
        /// <para>The scan interval.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IntervalPeriod")]
        [Validation(Required=false)]
        public int? IntervalPeriod { get; set; }

        /// <summary>
        /// <para>The settings of the CIDR block.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.168.XX.XX/24</para>
        /// </summary>
        [NameInMap("IpSegments")]
        [Validation(Required=false)]
        public string IpSegments { get; set; }

        /// <summary>
        /// <para>The Linux port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("LinuxPort")]
        [Validation(Required=false)]
        public string LinuxPort { get; set; }

        /// <summary>
        /// <para>The unit of the scan interval. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>day</b></description></item>
        /// <item><description><b>hour</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>day</para>
        /// </summary>
        [NameInMap("PeriodUnit")]
        [Validation(Required=false)]
        public string PeriodUnit { get; set; }

        /// <summary>
        /// <para>The usage status. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: enabled.</description></item>
        /// <item><description><b>1</b>: disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        /// <summary>
        /// <para>The UUID of the server. Separate multiple UUIDs with commas (,).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUID.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b6d4072118f487094199cedf90c****,f6310b7976144639867beea2f346****</para>
        /// </summary>
        [NameInMap("Uuids")]
        [Validation(Required=false)]
        public string Uuids { get; set; }

        /// <summary>
        /// <para>The Windows port.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40</para>
        /// </summary>
        [NameInMap("WinPort")]
        [Validation(Required=false)]
        public string WinPort { get; set; }

    }

}
