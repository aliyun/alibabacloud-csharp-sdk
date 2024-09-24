// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateWebLockFileEventsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to handle all alert events that are generated for web tamper proofing. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DealAll")]
        [Validation(Required=false)]
        public int? DealAll { get; set; }

        /// <summary>
        /// <para>The IDs of alert events.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventIds")]
        [Validation(Required=false)]
        public List<long?> EventIds { get; set; }

        /// <summary>
        /// <para>The operation that you want to perform on the alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mark_mis_info</b>: marks the alert events as false positives</description></item>
        /// <item><description><b>rm_mark_mis_info</b>: cancels marking the alerts events as false positives</description></item>
        /// <item><description><b>offline_handled</b>: marks the alert events as handled offline</description></item>
        /// <item><description><b>whitelist</b>: adds the alert events to the whitelist</description></item>
        /// <item><description><b>rm_whitelist</b>: cancels adding the alert events to the whitelist</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>whitelist</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

    }

}
