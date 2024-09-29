// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class UpdateAlertRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert rule.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1234567</para>
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// <para>The IDs of the alert contact groups. The value must be a JSON array.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[123, 234]</para>
        /// </summary>
        [NameInMap("ContactGroupIds")]
        [Validation(Required=false)]
        public string ContactGroupIds { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable the alert rule after it is created. Default value: <c>false</c>.</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: enables the alert rule.</description></item>
        /// <item><description><c>false</c>: disables the alert rule.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsAutoStart")]
        [Validation(Required=false)]
        public bool? IsAutoStart { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The configurations of the alert template based on which you want to create an alert rule. The value must be a JSON string. You must set at least one of the <b>TemplateAlertId</b> and <b>TemplageAlertConfig</b> parameters. If you set both parameters, the <b>TemplateAlertId</b> parameter prevails. For more information about the TemplageAlertConfig parameter, see the following <b>additional information about the TemplageAlertConfig parameter</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[ { &quot;contactGroupIds&quot;: &quot;381&quot;, &quot;alertType&quot;: 5, &quot;alarmContext&quot;: { &quot;subTitle&quot;: &quot;&quot;, &quot;content&quot;: &quot;Alarm name: $alarm name\nFilter condition: $filter\nAlarm time : $Alarm time\nAlarm content: $Alarm content\nNote: Before the recovery email is received, the alarm is in continuous alarm, and you will be reminded again after 24 hours!&quot; }, &quot;alertLevel&quot;: &quot;WARN&quot;, &quot; metricParam&quot;: { &quot;appId&quot;: &quot;70901&quot;, &quot;pid&quot;: &quot;atc889zkcf@d8deedfa9bf****&quot;, &quot;type&quot;: &quot;TXN&quot;, &quot;dimensions&quot;: [ { &quot;type&quot;: &quot;STATIC&quot;, &quot;value &quot;: &quot;\\/hello_test_api_address\\/test1&quot;, &quot;key&quot;: &quot;rpc&quot; } ] }, &quot;alertWay&quot;: [ &quot;SMS&quot;, &quot;MAIL&quot;, &quot;DING_ROBOT&quot; ], &quot;alertRule&quot;: { &quot;rules&quot; : [ { &quot;measure&quot;: &quot;appstat.txn.rt&quot;, &quot;alias&quot;: &quot;Entry call response time_ms&quot;, &quot;aggregates&quot;: &quot;AVG&quot;, &quot;nValue&quot;: 1, &quot;value&quot;: 1, &quot;operator &quot;: &quot;CURRENT_GTE&quot; } ], &quot;operator&quot;: &quot;|&quot; }, &quot;title&quot;: &quot;Alarm template alarm name&quot;, &quot;config&quot;: &quot;{\&quot;continuous\&quot;:false,\&quot;dataRevision\&quot;:2, \&quot;ownerId\&quot;:\&quot;123412341234\&quot;}&quot;, &quot;notice&quot;: { &quot;noticeStartTime&quot;: 1480521600000, &quot;startTime&quot;: 1480521600000, &quot;endTime&quot;: 1480607940000, &quot;noticeEndTime&quot;: 1480607940000 }, &quot;stat us&quot;: &quot;NON &quot; } ]</para>
        /// </summary>
        [NameInMap("TemplageAlertConfig")]
        [Validation(Required=false)]
        public string TemplageAlertConfig { get; set; }

    }

}
