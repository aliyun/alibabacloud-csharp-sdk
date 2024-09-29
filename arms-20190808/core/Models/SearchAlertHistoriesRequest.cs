// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class SearchAlertHistoriesRequest : TeaModel {
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
        /// <item><description><c>1</c>: a custom alert rule that is used to monitor drill-down data sets</description></item>
        /// <item><description><c>3</c>: a custom alert rule that is used to monitor tiled data sets</description></item>
        /// <item><description><c>4</c>: an alert rule that is used to monitor web pages, including the default alert rule for browser monitoring</description></item>
        /// <item><description><c>5</c>: an alert rule that is used to monitor applications, including the default alert rule for application monitoring</description></item>
        /// <item><description><c>6</c>: the default alert rule for browser monitoring</description></item>
        /// <item><description><c>7</c>: the default alert rule for application monitoring</description></item>
        /// <item><description><c>8</c>: a Tracing Analysis alert rule</description></item>
        /// <item><description><c>101</c>: a Prometheus alert rule</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public int? AlertType { get; set; }

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
        /// <para>The end of the time range to query. The value is a UNIX timestamp of the LONG data type. Unit: milliseconds. The default value is the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1579499626000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

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
        /// <para>The ID of the region. Default value: <c>cn-hangzhou</c>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp of the LONG data type. Unit: milliseconds. The default value is 10 minutes before the current time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1595568910000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
