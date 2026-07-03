// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class CreateHealthCheckRequest : TeaModel {
        /// <summary>
        /// <para>The description of the health check instance.</para>
        /// <para>The description must be 2 to 256 characters in length, and must start with a letter or a Chinese character. The description can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc_123</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The destination IP address of the health check.</para>
        /// <para>This parameter is required.</para>
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
        /// <para>This feature is currently not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1333</para>
        /// </summary>
        [NameInMap("DstPort")]
        [Validation(Required=false)]
        public int? DstPort { get; set; }

        /// <summary>
        /// <para>The threshold for the number of consecutive probe failures.</para>
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
        /// <para>The name of the health check instance.</para>
        /// <para>The name must be 2 to 100 characters in length, and must start with a letter or a Chinese character. The name can contain digits, periods (.), underscores (_), and hyphens (-).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc-123</para>
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
        /// <para>The number of probes per health check.</para>
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
        /// <para>The interval between health check probes. The next probe will not be initiated until the current probe is complete.</para>
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
        /// <para>The timeout period for a single probe.</para>
        /// <para>Valid values: <b>10</b> to <b>30000</b>.</para>
        /// <para>Default value: <b>1000</b>.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("ProbeTimeout")]
        [Validation(Required=false)]
        public int? ProbeTimeout { get; set; }

        /// <summary>
        /// <para>The ID of the region where the Smart Access Gateway instance is deployed.</para>
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
        /// <para>The number of times that the RTT threshold can be reached.</para>
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
        /// <para>The round-trip time (RTT) threshold.</para>
        /// <para>Valid values: <b>-1</b> or <b>1</b> to <b>5000</b>.</para>
        /// <para>Default value: <b>-1</b>, which indicates that no RTT threshold is set.</para>
        /// <para>Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("RttThreshold")]
        [Validation(Required=false)]
        public int? RttThreshold { get; set; }

        /// <summary>
        /// <para>The ID of the Smart Access Gateway instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sag-1um5x5nwhilymw****</para>
        /// </summary>
        [NameInMap("SmartAGId")]
        [Validation(Required=false)]
        public string SmartAGId { get; set; }

        /// <summary>
        /// <para>The source IP address of the health check instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10.XX.XX.1</para>
        /// </summary>
        [NameInMap("SrcIpAddr")]
        [Validation(Required=false)]
        public string SrcIpAddr { get; set; }

        /// <summary>
        /// <para>The source port of the health check.</para>
        /// <remarks>
        /// <para>This feature is currently not supported.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1344</para>
        /// </summary>
        [NameInMap("SrcPort")]
        [Validation(Required=false)]
        public int? SrcPort { get; set; }

        /// <summary>
        /// <para>The type of health check packets.</para>
        /// <remarks>
        /// <para>Only <b>ICMP_ECHO</b> is supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ICMP_ECHO</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
