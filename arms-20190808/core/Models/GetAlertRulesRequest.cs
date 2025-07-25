// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetAlertRulesRequest : TeaModel {
        /// <summary>
        /// <para>The unique IDs of alert rules.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the API operation does not filter alert rules based on their IDs.</description></item>
        /// <item><description>If you specify this parameter, the API operation returns only the information of the specified alert rules. Other filter conditions also take effect.</description></item>
        /// </list>
        /// <remarks>
        /// <para>When you call the GetAlertRules operation, you can specify other request parameters to obtain the AlertIds parameter from the response. Then, you can specify the AlertIds parameter to query the specified alert rules.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;12345&quot;]</para>
        /// </summary>
        [NameInMap("AlertIds")]
        [Validation(Required=false)]
        public string AlertIds { get; set; }

        /// <summary>
        /// <para>The names of alert rules. When you create alert rules of the new version, you cannot specify duplicate names. However, existing alert rules may have duplicate names. Therefore, the <b>AlertName</b> parameter does not uniquely identify an alert rule.</para>
        /// <list type="bullet">
        /// <item><description>If you do not specify this parameter, the API operation does not filter alert rules based on their names.</description></item>
        /// <item><description>If you specify this parameter, the API operation returns only the information of the specified alert rules. Other filter conditions also take effect.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;test&quot;]</para>
        /// </summary>
        [NameInMap("AlertNames")]
        [Validation(Required=false)]
        public string AlertNames { get; set; }

        /// <summary>
        /// <para>The status of the alert rule. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>RUNNING</description></item>
        /// <item><description>STOPPED</description></item>
        /// <item><description>PAUSED</description></item>
        /// </list>
        /// <remarks>
        /// <para> The PAUSED state indicates an abnormal and paused alert rule. This may result from excessively large threshold values or deleted associated clusters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("AlertStatus")]
        [Validation(Required=false)]
        public string AlertStatus { get; set; }

        /// <summary>
        /// <para>The type of the alert rule. This parameter is required for the new version of Alert Management. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>APPLICATION_MONITORING_ALERT_RULE: alert rule for Application Monitoring</description></item>
        /// <item><description>BROWSER_MONITORING_ALERT_RULE: alert rule for Browser Monitoring</description></item>
        /// <item><description>PROMETHEUS_MONITORING_ALERT_RULE: alert rule for Managed Service for Prometheus</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>APPLICATION_MONITORING_ALERT_RULE</para>
        /// </summary>
        [NameInMap("AlertType")]
        [Validation(Required=false)]
        public string AlertType { get; set; }

        [NameInMap("BizRegionId")]
        [Validation(Required=false)]
        public string BizRegionId { get; set; }

        /// <summary>
        /// <para>The ID of the monitored cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ceba9b9ea5b924dd0b6726d2de6******</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

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
        /// <para>You do not need to configure this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>null</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The number of alert rules to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The list of tags.</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<GetAlertRulesRequestTags> Tags { get; set; }
        public class GetAlertRulesRequestTags : TeaModel {
            /// <summary>
            /// <para>The tag key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>type</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The tag value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
