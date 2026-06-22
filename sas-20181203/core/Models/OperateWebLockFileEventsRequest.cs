// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateWebLockFileEventsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to handle all alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no.</description></item>
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
        /// <para>The list of alert event IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("EventIds")]
        [Validation(Required=false)]
        public List<long?> EventIds { get; set; }

        /// <summary>
        /// <para>The method to handle the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>mark_mis_info</b>: marks the alert as a false positive</description></item>
        /// <item><description><b>rm_mark_mis_info</b>: unmarks the false positive</description></item>
        /// <item><description><b>offline_handled</b>: handled offline</description></item>
        /// <item><description><b>whitelist</b>: adds to the whitelist</description></item>
        /// <item><description><b>rm_whitelist</b>: removes from the whitelist.</description></item>
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
