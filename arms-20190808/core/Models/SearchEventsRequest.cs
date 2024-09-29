// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchEventsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert rule. You can call the SearchAlertRules operation and view the <c>Id</c> parameter in the response. For more information, see <a href="https://help.aliyun.com/document_detail/175825.html">SearchAlertRules</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123</para>
        /// </summary>
        [NameInMap("AlertId")]
        [Validation(Required=false)]
        public long? AlertId { get; set; }

        /// <summary>
        /// <para>The type of the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: custom alert rules to monitor drill-down data sets</description></item>
        /// <item><description><c>3</c>: custom alert rules to monitor tiled data sets</description></item>
        /// <item><description><c>4</c>: alert rules to monitor the frontend, including the default frontend alert rules</description></item>
        /// <item><description><c>5</c>: alert rules to monitor applications, including the default application alert rules</description></item>
        /// <item><description><c>6</c>: the default frontend alert rules</description></item>
        /// <item><description><c>7</c>: the default application alert rules</description></item>
        /// <item><description><c>8</c>: Tracing Analysis alert rules</description></item>
        /// <item><description><c>101</c>: Prometheus alert rules</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public int? AlertType { get; set; }

        /// <summary>
        /// <para>The type of the application that is associated with the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>TRACE</c>: application monitoring</description></item>
        /// <item><description><c>RETCODE</c>: frontend monitoring</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>TRACE</para>
        /// </summary>
        [NameInMap("AppType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <c>1</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify a UNIX timestamp of the LONG data type, in milliseconds. The default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1595568970000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>Specifies whether the alert event is triggered. If you do not set this parameter, all alert events are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>1</c>: The event is triggered.</description></item>
        /// <item><description><c>0</c>: The event is not triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsTrigger")]
        [Validation(Required=false)]
        public int? IsTrigger { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <c>10</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The process identifier (PID) of the application that is associated with the alert rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>atc889zkcf@d8deedfa9bf****</para>
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

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
        /// <para>The beginning of the time range to query. Specify a UNIX timestamp of the LONG data type, in milliseconds. The default value is 10 minutes before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1595565300000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
