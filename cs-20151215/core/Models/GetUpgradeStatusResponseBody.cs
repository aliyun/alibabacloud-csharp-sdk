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
        /// <item><description><c>success</c>: Upgrade succeeded.</description></item>
        /// <item><description><c>fail</c>: Upgrade failed.</description></item>
        /// <item><description><c>pause</c>: Upgrade paused.</description></item>
        /// <item><description><c>running</c>: Upgrade in progress.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>running</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The current upgrade stage of the cluster. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>not_start</c>: Not started.</description></item>
        /// <item><description><c>prechecking</c>: Prechecking.</description></item>
        /// <item><description><c>upgrading</c>: Upgrading.</description></item>
        /// <item><description><c>pause</c>: Paused.</description></item>
        /// <item><description><c>success</c>: Upgrade succeeded.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>prechecking</para>
        /// </summary>
        [NameInMap("upgrade_step")]
        [Validation(Required=false)]
        public string UpgradeStep { get; set; }

        /// <summary>
        /// <para>The details of the upgrade task.</para>
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
            /// <para>The status of the upgrade task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>running</c>: Running.</description></item>
            /// <item><description><c>Success</c>: Succeeded.</description></item>
            /// <item><description><c>Failed</c>: Failed.</description></item>
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
