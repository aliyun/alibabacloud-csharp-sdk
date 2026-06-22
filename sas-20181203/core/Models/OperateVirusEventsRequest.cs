// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateVirusEventsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to handle all alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("OperationAll")]
        [Validation(Required=false)]
        public int? OperationAll { get; set; }

        /// <summary>
        /// <para>The method to handle the alert event. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: deep scan and removal</description></item>
        /// <item><description><b>ignore</b>: ignore</description></item>
        /// <item><description><b>advance_mark_mis_info</b>: add to whitelist</description></item>
        /// <item><description><b>manual_handled</b>: manually handled.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("OperationCode")]
        [Validation(Required=false)]
        public string OperationCode { get; set; }

        /// <summary>
        /// <para>The scope of the handling operation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;type\&quot;:\&quot;machine\&quot;,\&quot;list\&quot;:[\&quot;xxxxxxxxx-4cbf-4ca6-a1b7-8a09d1f86ab0\&quot;]}]</para>
        /// </summary>
        [NameInMap("OperationRange")]
        [Validation(Required=false)]
        public string OperationRange { get; set; }

    }

}
