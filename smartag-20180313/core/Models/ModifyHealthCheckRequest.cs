// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ModifyHealthCheckRequest : TeaModel {
        /// <summary>
        /// <para>The description of the health check.</para>
        /// <para>The description must be 2 to 256 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>description</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination IP address of the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("DstIpAddr")]
        [Validation(Required=false)]
        public string DstIpAddr { get; set; }

        /// <summary>
        /// <para>The destination port of the health check.</para>
        /// <remarks>
        /// <para> This parameter is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2233</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        /// <summary>
        /// <para>The number of failed probes before a health check is declared failed.</para>
        /// <para>Valid values: <b>1</b> to <b>15</b>.</para>
        /// <para>Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("FailCountThreshold")]
        [Validation(Required=false)]
        public int? FailCountThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the health check.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc-k9id4loo3lup57****</para>
        /// </summary>
        [NameInMap("HcInstanceId")]
        [Validation(Required=false)]
        public string HcInstanceId { get; set; }

        /// <summary>
        /// <para>The name of the health check.</para>
        /// <para>The name must be 2 to 100 characters in length, and can contain letters, digits, periods (.), underscores (_), and hyphens (-). It must start with a letter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sss333</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The number of probes that are performed per health check.</para>
        /// <para>Valid values: <b>1</b> to <b>20</b>.</para>
        /// <para>Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("ProbeCount")]
        [Validation(Required=false)]
        public int? ProbeCount { get; set; }

        /// <summary>
        /// <para>The time interval at which probes are performed. The next probe does not start before the current one is complete.</para>
        /// <para>Valid values: <b>1000</b> to <b>60000</b>.</para>
        /// <para>Default value: <b>2000</b>.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2000</para>
        /// </summary>
        [NameInMap("ProbeInterval")]
        [Validation(Required=false)]
        public int? ProbeInterval { get; set; }

        /// <summary>
        /// <para>The timeout period of the probe.</para>
        /// <para>Valid values: <b>10</b> to <b>30000</b>.</para>
        /// <para>Default value: <b>3000</b>.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3000</para>
        /// </summary>
        [NameInMap("ProbeTimeout")]
        [Validation(Required=false)]
        public int? ProbeTimeout { get; set; }

        /// <summary>
        /// <para>The region ID of the Smart Access Gateway (SAG) instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The number of times that the maximum RTT is exceeded before an alert is triggered.</para>
        /// <para>Valid values: <b>1</b> to <b>15</b>.</para>
        /// <para>Default value: <b>3</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RttFailThreshold")]
        [Validation(Required=false)]
        public int? RttFailThreshold { get; set; }

        /// <summary>
        /// <para>The maximum round-trip time (RTT).</para>
        /// <para>Valid values: <b>-1</b> and <b>1</b> to <b>5000</b>.</para>
        /// <para>Default value: <b>-1</b>. This value indicates that the RTT threshold is not specified.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("RttThreshold")]
        [Validation(Required=false)]
        public int? RttThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the SAG instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-i0e85k06v1mzpo****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The source IP address of the health check.</para>
        /// 
        /// <b>Example:</b>
        /// <para>192.XX.XX.1</para>
        /// </summary>
        [NameInMap("SrcIpAddr")]
        [Validation(Required=false)]
        public string SrcIpAddr { get; set; }

        /// <summary>
        /// <para>The source port of the health check.</para>
        /// <remarks>
        /// <para> This parameter is not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>3333</para>
        /// </summary>
        [NameInMap("SrcPort")]
        [Validation(Required=false)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// <para>The type of packet used in the health check. Only <b>ICMP_ECHO</b> is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP_ECHO</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
