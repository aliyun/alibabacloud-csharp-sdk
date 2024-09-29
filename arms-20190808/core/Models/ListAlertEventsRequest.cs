// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertEventsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test-triggered alert</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The end time of the alert events that you want to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-22 23:59:59</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The list of matching conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[         {           &quot;value&quot;: &quot;ARMS_NOTIFICATION&quot;,           &quot;key&quot;: &quot;clustername&quot;,           &quot;operator&quot;: &quot;eq&quot;         }       ]     },{       &quot;matchingConditions&quot;: [         {           &quot;value&quot;: &quot;test&quot;,           &quot;key&quot;: &quot;alertname&quot;,           &quot;operator&quot;: &quot;eq&quot;         }       ]</para>
        /// </summary>
        [NameInMap("MatchingConditions")]
        [Validation(Required=false)]
        public string MatchingConditions { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Page")]
        [Validation(Required=false)]
        public long? Page { get; set; }

        /// <summary>
        /// <para>Specifies whether to show the associated notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ShowNotificationPolicies")]
        [Validation(Required=false)]
        public bool? ShowNotificationPolicies { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The start time of the alert events that you want to query. Specify the time in the YYYY-MM-DD HH:mm:ss format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-19 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the alert events. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Active</description></item>
        /// <item><description>Silenced</description></item>
        /// <item><description>Resolved</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Active</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
