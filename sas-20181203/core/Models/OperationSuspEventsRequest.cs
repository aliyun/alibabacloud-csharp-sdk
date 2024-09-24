// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperationSuspEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the request source.</para>
        /// <para>Set the value to <b>sas</b>, which indicates that the request is sent from Security Center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform on alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>deal</b>: quarantines the source file of the malicious process.</description></item>
        /// <item><description><b>ignore</b>: ignores the alerts.</description></item>
        /// <item><description><b>mark_mis_info</b>: marks the alerts as false positives by adding the alerts to the whitelist.</description></item>
        /// <item><description><b>rm_mark_mis_info</b>: cancels false positives by removing the alerts from the whitelist.</description></item>
        /// <item><description><b>offline_handled</b>: marks the alerts as handled.</description></item>
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
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The suboperation that you want to perform when you quarantine the source file of the malicious process. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>killAndQuaraFileByPidAndMd5andPath</b>: terminates the process based on its process ID (PID) and quarantines the source file of the process.</description></item>
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
        /// <para>The IDs of alert events.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> operation to obtain the IDs of alert events from the SecurityEventIds response parameter.</para>
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
        /// <para>The type of the exceptions. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>alarm</b>: alerts</description></item>
        /// <item><description><b>null</b>: exceptions</description></item>
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
