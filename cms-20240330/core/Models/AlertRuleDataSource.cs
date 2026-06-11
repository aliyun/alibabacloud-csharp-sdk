// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleDataSource : TeaModel {
        /// <summary>
        /// <para>Applies to the APM_DS data source type.</para>
        /// <para>The type of the application. Valid value:</para>
        /// <list type="bullet">
        /// <item><description>apm</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apm</para>
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>Applies to the SLS_MULTI_DS data source type.</para>
        /// <para>A list of sub-data sources.</para>
        /// </summary>
        [NameInMap("dsList")]
        [Validation(Required=false)]
        public List<AlertRuleDataSourceDsList> DsList { get; set; }
        public class AlertRuleDataSourceDsList : TeaModel {
            /// <summary>
            /// <para>The SLS project.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mySlsProject</para>
            /// </summary>
            [NameInMap("project")]
            [Validation(Required=false)]
            public string Project { get; set; }

            /// <summary>
            /// <para>The region where the SLS project is located.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the LogStore or MetricStore.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mySlsLogStore</para>
            /// </summary>
            [NameInMap("store")]
            [Validation(Required=false)]
            public string Store { get; set; }

            /// <summary>
            /// <para>The type of the SLS sub-data source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>SLS_LOG_DS: A LogStore data source.</para>
            /// </description></item>
            /// <item><description><para>SLS_METRIC_DS: A MetricStore data source.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>SLS_LOG_DS</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>Applies to the PROMETHEUS_DS data source type.</para>
        /// <para>The ID of the Prometheus instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-bbe8961b4a59be0</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Applies to the ENTERPRISE_DS data source type.</para>
        /// <para>The name of the Hybrid Cloud Monitoring metric repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Applies to the APM_DS and PROMETHEUS_DS data source types.</para>
        /// <para>The ID of the region where the data source is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("tenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

        /// <summary>
        /// <para>The data source type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PROMETHEUS_DS: A Prometheus data source.</para>
        /// </description></item>
        /// <item><description><para>SLS_MULTI_DS: An SLS data source.</para>
        /// </description></item>
        /// <item><description><para>APM_DS: An Application Monitoring data source.</para>
        /// </description></item>
        /// <item><description><para>CMS_BASIC_DS: A basic Cloud Monitor data source.</para>
        /// </description></item>
        /// <item><description><para>ENTERPRISE_DS: A Hybrid Cloud Monitoring data source.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PROMETHEUS_DS</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
