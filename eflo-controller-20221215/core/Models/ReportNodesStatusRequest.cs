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
        /// <para>The end time of the node issue. The time is in the ISO 8601 format \<c>yyyy-MM-ddTHH:mm:ss+0800\\</c> and includes the time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-07-10T10:17:06</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The category of the issue. This parameter is required when \<c>Reason\\</c> is set to \<c>HardwareError\\</c>. Valid values:<br>
        /// ● hardware-cpu-error: CPU failure<br>
        /// ● hardware-gpu-error: GPU failure<br>
        /// ● hardware-motherboard-error: Motherboard failure<br>
        /// ● hardware-mem-error: Memory failure<br>
        /// ● hardware-power-error: Power supply failure<br>
        /// ● hardware-disk-error: Disk failure
        /// ● hardware-networkcard-error: Network interface card failure<br>
        /// ● hardware-fan-error: Fan failure<br>
        /// ● hardware-cable-error: Network cable failure<br>
        /// ● others: Other<br><br><br><br><br><br><br><br><br></para>
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
        /// <para>The impact of the issue on the Lingjun node.
        /// Valid values:
        /// ● HardwareError: A hardware error occurred.
        /// ● SoftwareError: A software error occurred.
        /// ● NetworkError: A network error occurred.
        /// ● Others: Other issues. If none of the preceding values apply, set this parameter to \<c>Others\\</c> and provide details in the \<c>Description\\</c> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>SoftwareError</para>
        /// </summary>
        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        /// <summary>
        /// <para>The start time of the node issue. The time is in the ISO 8601 format \<c>yyyy-MM-ddTHH:mm:ss+0800\\</c> and includes the time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2024-09-22T16:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

    }

}
