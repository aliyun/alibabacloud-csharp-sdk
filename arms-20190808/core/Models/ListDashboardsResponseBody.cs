// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDashboardsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the Grafana dashboard.</para>
        /// </summary>
        [NameInMap("DashboardVos")]
        [Validation(Required=false)]
        public List<ListDashboardsResponseBodyDashboardVos> DashboardVos { get; set; }
        public class ListDashboardsResponseBodyDashboardVos : TeaModel {
            /// <summary>
            /// <para>The type of the Grafana dashboard. This parameter has the same effect as the Exporter parameter whereas provides clearer implication.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Node</para>
            /// </summary>
            [NameInMap("DashboardType")]
            [Validation(Required=false)]
            public string DashboardType { get; set; }

            /// <summary>
            /// <para>The type of the exporter access source. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Prometheus</description></item>
            /// <item><description>Node</description></item>
            /// <item><description>GPU</description></item>
            /// <item><description>Redis</description></item>
            /// <item><description>MySQL</description></item>
            /// <item><description>Kafka</description></item>
            /// <item><description>NGINX V2</description></item>
            /// <item><description>Nginx</description></item>
            /// <item><description>ZooKeeper</description></item>
            /// <item><description>MongoDB</description></item>
            /// <item><description>RabbitMQ</description></item>
            /// <item><description>PostgreSQL</description></item>
            /// <item><description>Kubernetes</description></item>
            /// <item><description>Client Library</description></item>
            /// <item><description>Elasticsearch</description></item>
            /// <item><description>RocketMQ</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Nginx</para>
            /// </summary>
            [NameInMap("Exporter")]
            [Validation(Required=false)]
            public string Exporter { get; set; }

            /// <summary>
            /// <para>The URL of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&refresh=60s">http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&amp;refresh=60s</a></para>
            /// </summary>
            [NameInMap("HttpUrl")]
            [Validation(Required=false)]
            public string HttpUrl { get; set; }

            /// <summary>
            /// <para>The URL of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&refresh=60s">http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&amp;refresh=60s</a></para>
            /// </summary>
            [NameInMap("HttpsUrl")]
            [Validation(Required=false)]
            public string HttpsUrl { get; set; }

            /// <summary>
            /// <para>The information about the Grafana dashboard.</para>
            /// </summary>
            [NameInMap("I18nChild")]
            [Validation(Required=false)]
            public ListDashboardsResponseBodyDashboardVosI18nChild I18nChild { get; set; }
            public class ListDashboardsResponseBodyDashboardVosI18nChild : TeaModel {
                /// <summary>
                /// <para>The type of the Grafana dashboard. This parameter has the same effect as the Exporter parameter whereas provides clearer implication.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Node</para>
                /// </summary>
                [NameInMap("DashboardType")]
                [Validation(Required=false)]
                public string DashboardType { get; set; }

                /// <summary>
                /// <para>The type of the exporter access source. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>Prometheus</description></item>
                /// <item><description>Node</description></item>
                /// <item><description>GPU</description></item>
                /// <item><description>Redis</description></item>
                /// <item><description>MySQL</description></item>
                /// <item><description>Kafka</description></item>
                /// <item><description>NGINX V2</description></item>
                /// <item><description>Nginx</description></item>
                /// <item><description>ZooKeeper</description></item>
                /// <item><description>MongoDB</description></item>
                /// <item><description>RabbitMQ</description></item>
                /// <item><description>PostgreSQL</description></item>
                /// <item><description>Kubernetes</description></item>
                /// <item><description>Client Library</description></item>
                /// <item><description>Elasticsearch</description></item>
                /// <item><description>RocketMQ</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>Nginx</para>
                /// </summary>
                [NameInMap("Exporter")]
                [Validation(Required=false)]
                public string Exporter { get; set; }

                /// <summary>
                /// <para>The URL of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&refresh=60s">http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&amp;refresh=60s</a></para>
                /// </summary>
                [NameInMap("HttpUrl")]
                [Validation(Required=false)]
                public string HttpUrl { get; set; }

                /// <summary>
                /// <para>The URL of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&refresh=60s">http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&amp;refresh=60s</a></para>
                /// </summary>
                [NameInMap("HttpsUrl")]
                [Validation(Required=false)]
                public string HttpsUrl { get; set; }

                /// <summary>
                /// <para>The ID of the Grafana dashboard. The value is unique only when you install the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1100**</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>Indicates whether the exporter is provided by ARMS.</para>
                /// <list type="bullet">
                /// <item><description><c>true:</c> The exporter is provided by ARMS.</description></item>
                /// <item><description><c>false:</c>: The exporter is not provided by ARMS.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsArmsExporter")]
                [Validation(Required=false)]
                public bool? IsArmsExporter { get; set; }

                /// <summary>
                /// <para>The category of the Grafana dashboard. Valid values: BASIC, THIRD, LIMIT, and CUSTOM.</para>
                /// 
                /// <b>Example:</b>
                /// <para>BASIC</para>
                /// </summary>
                [NameInMap("Kind")]
                [Validation(Required=false)]
                public string Kind { get; set; }

                /// <summary>
                /// <para>The language of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>zh</para>
                /// </summary>
                [NameInMap("Language")]
                [Validation(Required=false)]
                public string Language { get; set; }

                /// <summary>
                /// <para>The name of the Grafana dashboard. This parameter is different from the <b>Title</b> parameter as this parameter cannot be changed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k8s-node-overview</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>Indicates whether the Grafana dashboard has a new version that is available for upgrade.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("NeedUpdate")]
                [Validation(Required=false)]
                public bool? NeedUpdate { get; set; }

                /// <summary>
                /// <para>The tags of the Grafana dashboard.</para>
                /// </summary>
                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<string> Tags { get; set; }

                /// <summary>
                /// <para>The time when the Grafana dashboard was created. The value is a timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1590136924</para>
                /// </summary>
                [NameInMap("Time")]
                [Validation(Required=false)]
                public string Time { get; set; }

                /// <summary>
                /// <para>The title of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ApiServer</para>
                /// </summary>
                [NameInMap("Title")]
                [Validation(Required=false)]
                public string Title { get; set; }

                /// <summary>
                /// <para>The type of the Grafana dashboard. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>dash-db</c>: a dashboard</description></item>
                /// <item><description><c>dash-folder</c>: a folder that can include a dashboard</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>dash-db</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                /// <summary>
                /// <para>The unique identifier of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1131971649496228-*****-59</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                /// <summary>
                /// <para>The complete URL of the Grafana dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&refresh=60s">http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&amp;refresh=60s</a></para>
                /// </summary>
                [NameInMap("Url")]
                [Validation(Required=false)]
                public string Url { get; set; }

                /// <summary>
                /// <para>The version of the Grafana dashboard. The combination of version and name uniquely identifies a dashboard.</para>
                /// 
                /// <b>Example:</b>
                /// <para>v2</para>
                /// </summary>
                [NameInMap("Version")]
                [Validation(Required=false)]
                public string Version { get; set; }

            }

            /// <summary>
            /// <para>The ID of the Grafana dashboard. The value is unique only when you install the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1100**</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>Indicates whether the exporter is provided by Application Real-Time Monitoring Service (ARMS).</para>
            /// <list type="bullet">
            /// <item><description><c>true:</c> The exporter is provided by ARMS.</description></item>
            /// <item><description><c>false:</c>: The exporter is not provided by ARMS.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("IsArmsExporter")]
            [Validation(Required=false)]
            public bool? IsArmsExporter { get; set; }

            /// <summary>
            /// <para>The category of the Grafana dashboard. Valid values: BASIC, THIRD, LIMIT, and CUSTOM.</para>
            /// 
            /// <b>Example:</b>
            /// <para>BASIC</para>
            /// </summary>
            [NameInMap("Kind")]
            [Validation(Required=false)]
            public string Kind { get; set; }

            /// <summary>
            /// <para>The language of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>en</para>
            /// </summary>
            [NameInMap("Language")]
            [Validation(Required=false)]
            public string Language { get; set; }

            /// <summary>
            /// <para>The name of the Grafana dashboard. This parameter is different from the <b>Title</b> parameter as this parameter cannot be changed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>k8s-node-overview</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>Indicates whether the Grafana dashboard has a new version that is available for upgrade.</para>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedUpdate")]
            [Validation(Required=false)]
            public bool? NeedUpdate { get; set; }

            /// <summary>
            /// <para>The tags of the Grafana dashboard.</para>
            /// </summary>
            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<string> Tags { get; set; }

            /// <summary>
            /// <para>The time when the Grafana dashboard was created. The value is a timestamp. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1590136924</para>
            /// </summary>
            [NameInMap("Time")]
            [Validation(Required=false)]
            public string Time { get; set; }

            /// <summary>
            /// <para>The title of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ApiServer</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

            /// <summary>
            /// <para>The type of the Grafana dashboard. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><c>dash-db</c>: a dashboard</description></item>
            /// <item><description><c>dash-folder</c>: a folder that can include a dashboard</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>dash-db</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The unique identifier of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1131971649496228-*****-59</para>
            /// </summary>
            [NameInMap("Uid")]
            [Validation(Required=false)]
            public string Uid { get; set; }

            /// <summary>
            /// <para>The complete URL of the Grafana dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&refresh=60s">http://g.console.aliyun.com/d/1131971649496228-*****-59/ApiServer?orgId=3**&amp;refresh=60s</a></para>
            /// </summary>
            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

            /// <summary>
            /// <para>The version of the Grafana dashboard. The combination of version and name uniquely identifies a dashboard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>v2</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The ID of the environment instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>env-ebd54733482581fc8c4237******</para>
        /// </summary>
        [NameInMap("EnvironmentId")]
        [Validation(Required=false)]
        public string EnvironmentId { get; set; }

        /// <summary>
        /// <para>Indicates whether Managed Service for Grafana is activated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("GrafanaServiceOpened")]
        [Validation(Required=false)]
        public string GrafanaServiceOpened { get; set; }

        /// <summary>
        /// <para>Whether or not to turn on Prometheus service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("PrometheusServiceOpened")]
        [Validation(Required=false)]
        public string PrometheusServiceOpened { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2A0CEDF1-06FE-44AC-8E21-21A5BE65****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
