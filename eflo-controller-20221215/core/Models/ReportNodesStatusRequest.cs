// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eflo_controller20221215.Models
{
    public class ReportNodesStatusRequest : TeaModel {
        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dwd_mysql_lingwan_faxing_login_di</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The end time of the node exception. Specify the time in the ISO 8601 standard with the time zone. The format is yyyy-MM-ddTHH:mm:ss+0800.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T10:17:06</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The category of the exception. This parameter is required when Reason is set to HardwareError. Valid values:</br></para>
        /// <list type="bullet">
        /// <item><description>hardware-cpu-error: CPU failure.</br></description></item>
        /// <item><description>hardware-gpu-error: GPU failure.</br></description></item>
        /// <item><description>hardware-motherboard-error: Motherboard failure.</br></description></item>
        /// <item><description>hardware-mem-error: Memory failure.</br></description></item>
        /// <item><description>hardware-power-error: Power supply failure.</br></description></item>
        /// <item><description>hardware-disk-error: Disk failure.</description></item>
        /// <item><description>hardware-networkcard-error: NIC failure.</br></description></item>
        /// <item><description>hardware-fan-error: Fan failure.</br></description></item>
        /// <item><description>hardware-cable-error: Network cable failure.</br></description></item>
        /// <item><description>others: Others.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>hardware-disk-error</para>
        /// </summary>
        [NameInMap("IssueCategory")]
        [Validation(Required=false)]
        public string IssueCategory { get; set; }

        /// <summary>
        /// <para>The list of nodes.</para>
        /// </summary>
        [NameInMap("Nodes")]
        [Validation(Required=false)]
        public List<string> Nodes { get; set; }

        /// <summary>
        /// <para>The impact of the exception on the Lingjun node. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>HardwareError: A hardware exception occurs.</description></item>
        /// <item><description>SoftwareError: A software exception occurs.</description></item>
        /// <item><description>NetworkError: A network exception occurs.</description></item>
        /// <item><description>Others: Other exceptions. If none of the preceding impact types apply, set Reason to Others and provide more information in Description.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SoftwareError</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The start time of the node exception. Specify the time in the ISO 8601 standard with the time zone. The format is yyyy-MM-ddTHH:mm:ss+0800. Note: This parameter is actually required. If it is not provided, the API returns a 400 InvalidParameter (field required) error.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
