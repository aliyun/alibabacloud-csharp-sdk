// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class QueryApmGrafanaDataShrinkRequest : TeaModel {
        /// <summary>
        /// 集群ID。
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        [NameInMap("DashboardId")]
        [Validation(Required=false)]
        public string DashboardId { get; set; }

        [NameInMap("End")]
        [Validation(Required=false)]
        public string End { get; set; }

        [NameInMap("Provider")]
        [Validation(Required=false)]
        public string Provider { get; set; }

        [NameInMap("Query")]
        [Validation(Required=false)]
        public string Query { get; set; }

        [NameInMap("QueryParams")]
        [Validation(Required=false)]
        public QueryApmGrafanaDataShrinkRequestQueryParams QueryParams { get; set; }
        public class QueryApmGrafanaDataShrinkRequestQueryParams : TeaModel {
            [NameInMap("PanelId")]
            [Validation(Required=false)]
            public long? PanelId { get; set; }

            [NameInMap("RefId")]
            [Validation(Required=false)]
            public string RefId { get; set; }

            [NameInMap("VariableName")]
            [Validation(Required=false)]
            public string VariableName { get; set; }

        }

        [NameInMap("QueryUrl")]
        [Validation(Required=false)]
        public string QueryUrl { get; set; }

        /// <summary>
        /// 地域ID。
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// 如果存在clusterId，从Cluster中获取该值，如果clusterId为空，用户显式指定
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        [NameInMap("Start")]
        [Validation(Required=false)]
        public string Start { get; set; }

        [NameInMap("Step")]
        [Validation(Required=false)]
        public string Step { get; set; }

        [NameInMap("Time")]
        [Validation(Required=false)]
        public string Time { get; set; }

        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string VariablesShrink { get; set; }

    }

}
