// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListDashboardsRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the ACK cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc7a37ee31aea4ed1a059eff8034b****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>Valid values: ACK, ASK, cloud-product-prometheus, and Node. You can query the dashboards of a virtual cluster by specifying the cluster type. For InfluxDB, set this parameter to <c>cloud-product-prometheus</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Node</para>
        /// </summary>
        [NameInMap("ClusterType")]
        [Validation(Required=false)]
        public string ClusterType { get; set; }

        /// <summary>
        /// <para>The unique names of the dashboards. You can query dashboards by specifying their names. The <b>dashboard title</b> can be changed whereas the <b>dashboard name</b> cannot. You can specify multiple names and separate them with commas (,), for example, <c>k8s-event,k8s-overview</c>. A dashboard may have multiple versions. If you want to specify a version, you can add version information after the name, for example, <c>k8s-event:v1,k8s-overview:latest</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>k8s-node-overview</para>
        /// </summary>
        [NameInMap("DashboardName")]
        [Validation(Required=false)]
        public string DashboardName { get; set; }

        /// <summary>
        /// <para>The language of the returned Grafana dashboard. Valid values: en and zh. Default value: en.</para>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        /// <summary>
        /// <para>The cloud service code. This parameter is required if you set the ClusterType parameter to <c>cloud-product-prometheus</c>. The following cloud services are available: Serverless App Engine, Microservices Engine, Message Queue for Apache RocketMQ, Lindorm, Message Queue for Apache Kafka, ApsaraDB for ClickHouse, Data Lake Analytics, Message Queue for RabbitMQ, ApsaraDB for MongoDB, Time Series Database (TSDB) for InfluxDB, MSE Cloud-native Gateway, Grafana Service, SchedulerX, Global Transaction Service, Enterprise Distributed Application Service, Machine Learning Platform for AI - Elastic Algorithm Service (EAS), Application High Availability Service, and Performance Testing.</para>
        /// 
        /// <b>Example:</b>
        /// <para>xxxx</para>
        /// </summary>
        [NameInMap("Product")]
        [Validation(Required=false)]
        public string Product { get; set; }

        /// <summary>
        /// <para>Specifies whether to create or query a virtual cluster. This parameter provides backward compatibility.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("RecreateSwitch")]
        [Validation(Required=false)]
        public bool? RecreateSwitch { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The dashboard title. The dashboard title can be changed. We recommend that you specify the <b>DashboardName</b> parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ApiServer</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
