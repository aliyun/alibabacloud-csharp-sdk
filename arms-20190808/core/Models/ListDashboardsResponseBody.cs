// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDashboardsResponseBody : TeaModel {
        /// <summary>
        /// The information about the Grafana dashboard.
        /// </summary>
        [NameInMap("DashboardVos")]
        [Validation(Required=false)]
        public List<ListDashboardsResponseBodyDashboardVos> DashboardVos { get; set; }
        public class ListDashboardsResponseBodyDashboardVos : TeaModel {
            /// <summary>
            /// The type of the Grafana dashboard. This parameter has the same effect as the Exporter parameter whereas provides clearer implication.
            /// </summary>
            [NameInMap("DashboardType")]
            [Validation(Required=false)]
            public string DashboardType { get; set; }

            /// <summary>
            /// The type of the exporter access source. Valid values:
            /// 
            /// *   Prometheus
            /// *   Node
            /// *   GPU
            /// *   Redis
            /// *   MySQL
            /// *   Kafka
            /// *   NGINX V2
            /// *   Nginx
            /// *   ZooKeeper
            /// *   MongoDB
            /// *   RabbitMQ
            /// *   PostgreSQL
            /// *   Kubernetes
            /// *   Client Library
            /// *   Elasticsearch
            /// *   RocketMQ
            /// </summary>
            [NameInMap("Exporter")]
            [Validation(Required=false)]
            public string Exporter { get; set; }

            /// <summary>
            /// The URL of the Grafana dashboard.
            /// </summary>
            [NameInMap("HttpUrl")]
            [Validation(Required=false)]
            public string HttpUrl { get; set; }

            /// <summary>
            /// The URL of the Grafana dashboard.
            /// </summary>
            [NameInMap("HttpsUrl")]
            [Validation(Required=false)]
            public string HttpsUrl { get; set; }

            /// <summary>
            /// The information about the Grafana dashboard.
            /// </summary>
            [NameInMap("I18nChild")]
            [Validation(Required=false)]
            public ListDashboardsResponseBodyDashboardVosI18nChild I18nChild { get; set; }
            public class ListDashboardsResponseBodyDashboardVosI18nChild : TeaModel {
                /// <summary>
                /// The type of the Grafana dashboard. This parameter has the same effect as the Exporter parameter whereas provides clearer implication.
                /// </summary>
                [NameInMap("DashboardType")]
                [Validation(Required=false)]
                public string DashboardType { get; set; }

                /// <summary>
                /// The type of the exporter access source. Valid values:
                /// 
                /// *   Prometheus
                /// *   Node
                /// *   GPU
                /// *   Redis
                /// *   MySQL
                /// *   Kafka
                /// *   NGINX V2
                /// *   Nginx
                /// *   ZooKeeper
                /// *   MongoDB
                /// *   RabbitMQ
                /// *   PostgreSQL
                /// *   Kubernetes
                /// *   Client Library
                /// *   Elasticsearch
                /// *   RocketMQ
                /// </summary>
                [NameInMap("Exporter")]
                [Validation(Required=false)]
                public string Exporter { get; set; }

                /// <summary>
                /// The URL of the Grafana dashboard.
                /// </summary>
                [NameInMap("HttpUrl")]
                [Validation(Required=false)]
                public string HttpUrl { get; set; }

                /// <summary>
                /// The URL of the Grafana dashboard.
                /// </summary>
                [NameInMap("HttpsUrl")]
                [Validation(Required=false)]
                public string HttpsUrl { get; set; }

                /// <summary>
                /// The ID of the Grafana dashboard. The value is unique only when you install the Grafana dashboard.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// Indicates whether the exporter is provided by ARMS.
                /// 
                /// *   `true:` The exporter is provided by ARMS.
                /// *   `false:`: The exporter is not provided by ARMS.
                /// </summary>
                [NameInMap("IsArmsExporter")]
                [Validation(Required=false)]
                public bool? IsArmsExporter { get; set; }

                /// <summary>
                /// The category of the Grafana dashboard. Valid values: BASIC, THIRD, LIMIT, and CUSTOM.
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// The language of the Grafana dashboard.
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// The name of the Grafana dashboard. This parameter is different from the **Title** parameter as this parameter cannot be changed.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// Indicates whether the Grafana dashboard has a new version that is available for upgrade.
                /// </summary>
                [NameInMap("NeedUpdate")]
                [Validation(Required=false)]
                public bool? NeedUpdate { get; set; }

                /// <summary>
                /// The tags of the Grafana dashboard.
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// The time when the Grafana dashboard was created. The value is a timestamp.
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// The title of the Grafana dashboard.
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// The type of the Grafana dashboard. Valid values:
                /// 
                /// *   `dash-db`: a dashboard
                /// *   `dash-folder`: a folder that can include a dashboard
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// The unique identifier of the Grafana dashboard.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// The complete URL of the Grafana dashboard.
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// The version of the Grafana dashboard. The combination of version and name uniquely identifies a dashboard.
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// The ID of the Grafana dashboard. The value is unique only when you install the Grafana dashboard.
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// Indicates whether the exporter is provided by Application Real-Time Monitoring Service (ARMS).
            /// 
            /// *   `true:` The exporter is provided by ARMS.
            /// *   `false:`: The exporter is not provided by ARMS.
            /// </summary>
            [NameInMap("IsArmsExporter")]
            [Validation(Required=false)]
            public bool? IsArmsExporter { get; set; }

            /// <summary>
            /// The category of the Grafana dashboard. Valid values: BASIC, THIRD, LIMIT, and CUSTOM.
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// The language of the Grafana dashboard.
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// The name of the Grafana dashboard. This parameter is different from the **Title** parameter as this parameter cannot be changed.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// Indicates whether the Grafana dashboard has a new version that is available for upgrade.
            /// </summary>
            [NameInMap("NeedUpdate")]
            [Validation(Required=false)]
            public bool? NeedUpdate { get; set; }

            /// <summary>
            /// The tags of the Grafana dashboard.
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// The time when the Grafana dashboard was created. The value is a timestamp. Unit: seconds.
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// The title of the Grafana dashboard.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// The type of the Grafana dashboard. Valid values:
            /// 
            /// *   `dash-db`: a dashboard
            /// *   `dash-folder`: a folder that can include a dashboard
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// The unique identifier of the Grafana dashboard.
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// The complete URL of the Grafana dashboard.
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// The version of the Grafana dashboard. The combination of version and name uniquely identifies a dashboard.
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// The ID of the environment instance.
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// Indicates whether Managed Service for Grafana is activated.
        /// </summary>
        [NameInMap("GrafanaServiceOpened")]
        [Validation(Required=false)]
        public string GrafanaServiceOpened { get; set; }

        /// <summary>
        /// Whether or not to turn on Prometheus service.
        /// </summary>
        [NameInMap("PrometheusServiceOpened")]
        [Validation(Required=false)]
        public string PrometheusServiceOpened { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
