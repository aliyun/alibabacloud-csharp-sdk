// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationSuspEventsRequest : TeaModel {
        /// <summary>
        /// <para>The request source identifier.</para>
        /// <para>Set this parameter to <b>sas</b>, which indicates a request from the Security Center client.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The operation to perform on the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>deal</b>: handles the alert (quarantine).</description></item>
        /// <item><description><b>ignore</b>: ignores the alert.</description></item>
        /// <item><description><b>mark_mis_info</b>: marks the alert as a false positive (adds it to the whitelist).</description></item>
        /// <item><description><b>rm_mark_mis_info</b>: unmarks the alert as a false positive (removes it from the whitelist).</description></item>
        /// <item><description><b>offline_handled</b>: marks the alert as handled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>deal</para>
        /// </summary>
        [NameInMap("Operation")]
        [Validation(Required=false)]
        public string Operation { get; set; }

        /// <summary>
        /// <para>The IP address of the access source.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The sub-operation type to perform when quarantining the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>killAndQuaraFileByPidAndMd5andPath</b>: terminates the process by PID and quarantines the source file of the process.</description></item>
        /// <item><description><b>quaraFileByMd5andPath</b>: quarantines the source file of the process.</description></item>
        /// <item><description><b>killAndQuaraFileByMd5andPath</b>: terminates the process and quarantines the source file of the process.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>killAndQuaraFileByPidAndMd5andPath</para>
        /// </summary>
        [NameInMap("SubOperation")]
        [Validation(Required=false)]
        public string SubOperation { get; set; }

        /// <summary>
        /// <para>The list of alert event IDs.</para>
        /// <remarks>
        /// <para>You can call <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> to obtain alert event IDs from the SecurityEventIds response parameter.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>290852</para>
        /// </summary>
        [NameInMap("SuspiciousEventIds")]
        [Validation(Required=false)]
        public string SuspiciousEventIds { get; set; }

        /// <summary>
        /// <para>The type of the exception event to handle. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>alarm</b>: alert.</description></item>
        /// <item><description><b>Empty</b>: exception.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>alarm</para>
        /// </summary>
        [NameInMap("WarnType")]
        [Validation(Required=false)]
        public string WarnType { get; set; }

    }

}
