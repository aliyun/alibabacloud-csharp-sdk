// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListAlertsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Test alert</para>
        /// </summary>
        [NameInMap("AlertName")]
        [Validation(Required=false)]
        public string AlertName { get; set; }

        /// <summary>
        /// <para>The ID of the notification policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345</para>
        /// </summary>
        [NameInMap("DispatchRuleId")]
        [Validation(Required=false)]
        public long? DispatchRuleId { get; set; }

        /// <summary>
        /// <para>The end time of the alert sending history that you want to query. Specify the time in the <c>YYYY-MM-DD HH:mm:ss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-22 23:59:59</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The integration type.</para>
        /// <list type="bullet">
        /// <item><description>ARMS</description></item>
        /// <item><description>CLOUD_MONITOR</description></item>
        /// <item><description>MSE</description></item>
        /// <item><description>ARMS_CLOUD_DIALTEST</description></item>
        /// <item><description>PROMETHEUS</description></item>
        /// <item><description>LOG_SERVICE</description></item>
        /// <item><description>CUSTOM</description></item>
        /// <item><description>ARMS_PROMETHEUS</description></item>
        /// <item><description>ARMS_APP_MON</description></item>
        /// <item><description>ARMS_FRONT_MON</description></item>
        /// <item><description>ARMS_CUSTOM</description></item>
        /// <item><description>XTRACE</description></item>
        /// <item><description>GRAFANA</description></item>
        /// <item><description>ZABBIX</description></item>
        /// <item><description>SKYWALKING</description></item>
        /// <item><description>EVENT_BRIDGE</description></item>
        /// <item><description>NAGIOS</description></item>
        /// <item><description>OPENFALCON</description></item>
        /// <item><description>ARMS_INSIGHTS</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ARMS_APP_MON</para>
        /// </summary>
        [NameInMap("IntegrationType")]
        [Validation(Required=false)]
        public string IntegrationType { get; set; }

        /// <summary>
        /// <para>The notification object configured in the notification policy, responsible for handling alerts.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Alice</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

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
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The severity level of the alert. Valid values: P6, P5, P4, P3, P2, and P1. The preceding values are listed in ascending order of severity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>P6</para>
        /// </summary>
        [NameInMap("Severity")]
        [Validation(Required=false)]
        public string Severity { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the activities that correspond to alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>false</c> (default value): The activities are not queried.</description></item>
        /// <item><description><c>true</c>: The activities in the last three days are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowActivities")]
        [Validation(Required=false)]
        public bool? ShowActivities { get; set; }

        /// <summary>
        /// <para>Specifies whether to query the events that correspond to alerts. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>false</c> (default value): The events are not queried.</description></item>
        /// <item><description><c>true</c>: The events are queried.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ShowEvents")]
        [Validation(Required=false)]
        public bool? ShowEvents { get; set; }

        /// <summary>
        /// <para>The number of alerts to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The start time of the alert sending history that you want to query. Specify the time in the <c>YYYY-MM-DD HH:mm:ss</c> format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-12-10 00:00:00</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the alert. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: The alert is pending.</description></item>
        /// <item><description>1: The alert is being handled.</description></item>
        /// <item><description>2: The alert is handled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public long? State { get; set; }

    }

}
