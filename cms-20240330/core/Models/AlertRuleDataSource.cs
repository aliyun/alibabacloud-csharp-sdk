// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class AlertRuleDataSource : TeaModel {
        /// <summary>
        /// <para>Applicable data source type: APM_DS.
        /// Application type: </para>
        /// <list type="bullet">
        /// <item><description>apm.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>apm</para>
        /// </summary>
        [NameInMap("appType")]
        [Validation(Required=false)]
        public string AppType { get; set; }

        /// <summary>
        /// <para>Applicable data source type: SLS_MULTI_DS.
        /// List of sub-data sources.</para>
        /// </summary>
        [NameInMap("dsList")]
        [Validation(Required=false)]
        public List<AlertRuleDataSourceDsList> DsList { get; set; }
        public class AlertRuleDataSourceDsList : TeaModel {
            /// <summary>
            /// <para>SLS project</para>
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
            /// <para>LogStore/MetricStore name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>mySlsLogStore</para>
            /// </summary>
            [NameInMap("store")]
            [Validation(Required=false)]
            public string Store { get; set; }

            /// <summary>
            /// <para>Type of SLS data sub-source:</para>
            /// <list type="bullet">
            /// <item><description>SLS_LOG_DS: LogStore data source.</description></item>
            /// <item><description>SLS_METRIC_DS: MetricStore data source.</description></item>
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
        /// <para>Applicable data source type: PROMETHEUS_DS.
        /// Prometheus instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rw-bbe8961b4a59be0</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Applicable data source type: ENTERPRISE_DS.
        /// Name of the enterprise cloud monitoring metric repository.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyun-default</para>
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Applicable data source types: APM_DS, PROMETHEUS_DS.
        /// The regionId to which the data source belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Data source type.
        /// Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PROMETHEUS_DS: Prometheus data source.</description></item>
        /// <item><description>SLS_MULTI_DS: SLS data source.</description></item>
        /// <item><description>APM_DS: Application monitoring data source.</description></item>
        /// <item><description>CMS_BASIC_DS: Basic cloud monitoring data source.</description></item>
        /// <item><description>ENTERPRISE_DS: Enterprise cloud monitoring data source.</description></item>
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
