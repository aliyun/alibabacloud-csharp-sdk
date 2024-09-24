// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateVirusEventsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to handle all alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: yes</description></item>
        /// <item><description><b>0</b>: no</description></item>
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
        /// <para>The operation that you want to perform on the alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>default</b>: performs in-depth detection and removal</description></item>
        /// <item><description><b>ignore</b>: ignores the alert event</description></item>
        /// <item><description><b>advance_mark_mis_info</b>: adds the alert events to the whitelist</description></item>
        /// <item><description><b>manual_handled</b>: marks the alert events as manually handled</description></item>
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
        /// <para>The handling scope.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;type\&quot;:\&quot;machine\&quot;,\&quot;list\&quot;:[\&quot;xxxxxxxxx-4cbf-4ca6-a1b7-8a09d1f86ab0\&quot;]}]</para>
        /// </summary>
        [NameInMap("OperationRange")]
        [Validation(Required=false)]
        public string OperationRange { get; set; }

    }

}
