// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Csas20230120.Models
{
    public class ListDynamicDisposalProcessesRequest : TeaModel {
        /// <summary>
        /// <para>The page number to display in the paginated query. Range: 1~10000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>Terminal device ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E7798391-2554-FE83-E0B7-045DDED629A8</para>
        /// </summary>
        [NameInMap("DevTag")]
        [Validation(Required=false)]
        public string DevTag { get; set; }

        /// <summary>
        /// <para>Disposal action.</para>
        /// <list type="bullet">
        /// <item><description><b>ztna_connect</b>: Prohibit connection to the zero-trust intranet.</description></item>
        /// <item><description><b>nac_connect</b>: Prohibit connection to the office network access.</description></item>
        /// <item><description><b>none</b>: No disposal action.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>none</para>
        /// </summary>
        [NameInMap("DisposalAction")]
        [Validation(Required=false)]
        public string DisposalAction { get; set; }

        /// <summary>
        /// <para>Disposal process ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dp-xxxxxxxx</para>
        /// </summary>
        [NameInMap("DisposalProcessId")]
        [Validation(Required=false)]
        public string DisposalProcessId { get; set; }

        /// <summary>
        /// <para>The end time for querying dynamic disposal processes. Format: Unix timestamp (in seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743143296</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The number of items per page in the paginated query. Range: 1~1000.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>Recovery type.</para>
        /// <list type="bullet">
        /// <item><description><b>auto</b>: Automatic recovery.</description></item>
        /// <item><description><b>console</b>: Console recovery.</description></item>
        /// <item><description><b>auth</b>: Recovery by authentication and reporting.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>auto</para>
        /// </summary>
        [NameInMap("RecoveryType")]
        [Validation(Required=false)]
        public string RecoveryType { get; set; }

        /// <summary>
        /// <para>The start time for querying dynamic disposal processes. Format: Unix timestamp (in seconds).</para>
        /// 
        /// <b>Example:</b>
        /// <para>1743143296</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>Disposal status. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>disposal</b>: In the disposal state.</description></item>
        /// <item><description><b>finished</b>: Already automatically recovered.</description></item>
        /// <item><description><b>recovery</b>: Recovered by authentication and reporting or console recovery.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>disposal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Username.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xiaoming</para>
        /// </summary>
        [NameInMap("UserName")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
