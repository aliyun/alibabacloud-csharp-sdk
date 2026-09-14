// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr_serverless_spark20230808.Models
{
    public class QueryApmGrafanaDataShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the monitoring dashboard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark-all</para>
        /// </summary>
        [NameInMap("componentName")]
        [Validation(Required=false)]
        public string ComponentName { get; set; }

        /// <summary>
        /// <para>The dashboard ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ex2tTKoNz</para>
        /// </summary>
        [NameInMap("dashboardId")]
        [Validation(Required=false)]
        public string DashboardId { get; set; }

        /// <summary>
        /// <para>The end time of the query. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1697033783</para>
        /// </summary>
        [NameInMap("end")]
        [Validation(Required=false)]
        public string End { get; set; }

        /// <summary>
        /// <para>The datasource provider.</para>
        /// 
        /// <b>Example:</b>
        /// <para>spark</para>
        /// </summary>
        [NameInMap("provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        /// <summary>
        /// <para>The PromQL query expression.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bizType:</para>
        /// </summary>
        [NameInMap("query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        /// <summary>
        /// <para>The panel-level query parameters.</para>
        /// </summary>
        [NameInMap("queryParams")]
        [Validation(Required=false)]
        public string QueryParamsShrink { get; set; }

        /// <summary>
        /// <para>The Grafana datasource proxy path.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/datasources/proxy/1/api/v1/query_range</para>
        /// </summary>
        [NameInMap("queryUrl")]
        [Validation(Required=false)]
        public string QueryUrl { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("regionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The start time of the query. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1697030183</para>
        /// </summary>
        [NameInMap("start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        /// <summary>
        /// <para>The query step, in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15</para>
        /// </summary>
        [NameInMap("step")]
        [Validation(Required=false)]
        public string Step { get; set; }

        /// <summary>
        /// <para>The time point for an instant query. The value is a UNIX timestamp in seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1697033783</para>
        /// </summary>
        [NameInMap("time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        /// <summary>
        /// <para>The dashboard variables, as a JSON string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;fenix_job_runId&quot;:&quot;jr-b5059689bb50f360&quot;}</para>
        /// </summary>
        [NameInMap("variables")]
        [Validation(Required=false)]
        public string Variables { get; set; }

        /// <summary>
        /// <para>The workspace ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>w-d2d82aa09155****</para>
        /// </summary>
        [NameInMap("workspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
