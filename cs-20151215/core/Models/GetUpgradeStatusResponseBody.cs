// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetUpgradeStatusResponseBody : TeaModel {
        /// <summary>
        /// <para>The error message during the cluster upgrade.</para>
        /// 
        /// <b>Example:</b>
        /// <para>subject to actual return</para>
        /// </summary>
        [NameInMap("error_message")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// <para>The ID of the precheck report.</para>
        /// 
        /// <b>Example:</b>
        /// <para>be4c8eb72de94d459ea7ace7c811d119</para>
        /// </summary>
        [NameInMap("precheck_report_id")]
        [Validation(Required=false)]
        public string PrecheckReportId { get; set; }

        /// <summary>
        /// <para>The current upgrade status of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>success</c>: The upgrade is successful.</description></item>
        /// <item><description><c>fail</c>: The upgrade has failed.</description></item>
        /// <item><description><c>pause</c>: The upgrade is paused.</description></item>
        /// <item><description><c>running</c>: The upgrade is in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The current upgrade phase of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>not_start</c>: Not started.</description></item>
        /// <item><description><c>prechecking</c>: Prechecking is in progress.</description></item>
        /// <item><description><c>upgrading</c>: The upgrade is in progress.</description></item>
        /// <item><description><c>pause</c>: The upgrade is paused.</description></item>
        /// <item><description><c>success</c>: The upgrade is successful.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prechecking</para>
        /// </summary>
        [NameInMap("upgrade_step")]
        [Validation(Required=false)]
        public string UpgradeStep { get; set; }

        /// <summary>
        /// <para>The upgrade task details.</para>
        /// </summary>
        [NameInMap("upgrade_task")]
        [Validation(Required=false)]
        public GetUpgradeStatusResponseBodyUpgradeTask UpgradeTask { get; set; }
        public class GetUpgradeStatusResponseBodyUpgradeTask : TeaModel {
            /// <summary>
            /// <para>The description of the upgrade task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>subject to actual return</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The upgrade task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>running</c>: The task is running.</description></item>
            /// <item><description><c>Success</c>: The task is successful.</description></item>
            /// <item><description><c>Failed</c>: The task has failed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>running</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

    }

}
