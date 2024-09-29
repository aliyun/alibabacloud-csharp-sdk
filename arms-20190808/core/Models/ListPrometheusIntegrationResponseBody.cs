// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusIntegrationResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The queried exporters.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListPrometheusIntegrationResponseBodyData> Data { get; set; }
        public class ListPrometheusIntegrationResponseBodyData : TeaModel {
            /// <summary>
            /// <para>Indicates whether the exporter can be deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanDelete")]
            [Validation(Required=false)]
            public bool? CanDelete { get; set; }

            /// <summary>
            /// <para>Indicates whether the exporter can be edited.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("CanEditor")]
            [Validation(Required=false)]
            public bool? CanEditor { get; set; }

            /// <summary>
            /// <para>The ID of the Prometheus instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c589a1b8db05c4561aefbb898ca8fb1cf</para>
            /// </summary>
            [NameInMap("ClusterId")]
            [Validation(Required=false)]
            public string ClusterId { get; set; }

            /// <summary>
            /// <para>The name of the container.</para>
            /// 
            /// <b>Example:</b>
            /// <para>container-1</para>
            /// </summary>
            [NameInMap("ContainerName")]
            [Validation(Required=false)]
            public string ContainerName { get; set; }

            /// <summary>
            /// <para>The description of the exporter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;{}&quot;</para>
            /// </summary>
            [NameInMap("Describe")]
            [Validation(Required=false)]
            public string Describe { get; set; }

            /// <summary>
            /// <para>The type of the exporter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-exporter</para>
            /// </summary>
            [NameInMap("ExporterType")]
            [Validation(Required=false)]
            public string ExporterType { get; set; }

            /// <summary>
            /// <para>The ID of the exporter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>29374</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// <para>The name of the exporter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>inet</para>
            /// </summary>
            [NameInMap("InstanceName")]
            [Validation(Required=false)]
            public string InstanceName { get; set; }

            /// <summary>
            /// <para>The integration type. Valid values: kafka, mysql, redis, snmp, emr, nubela, and tidb.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Kafka, mysql, redis, snmp, emr, nubela, and tidb</para>
            /// </summary>
            [NameInMap("IntegrationType")]
            [Validation(Required=false)]
            public string IntegrationType { get; set; }

            /// <summary>
            /// <para>The namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>arms-prom</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>Indicates whether an upgrade is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("NeedUpgrade")]
            [Validation(Required=false)]
            public bool? NeedUpgrade { get; set; }

            /// <summary>
            /// <para>The configurations of the exporter. The value is a JSON string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;port&quot;: &quot;5554&quot;,
            ///       &quot;name&quot;: &quot;kafka-test12&quot;,
            ///       &quot;kafka_instance&quot;: &quot;kafka-test&quot;,
            ///       &quot;__label_value&quot;: &quot;kafka-test&quot;,
            ///       &quot;scrape_interval&quot;: 33,
            ///       &quot;metrics_path&quot;: &quot;/metrics&quot;,
            ///       &quot;__label_key&quot;: &quot;kafka-test&quot;
            /// }</para>
            /// </summary>
            [NameInMap("Param")]
            [Validation(Required=false)]
            public string Param { get; set; }

            /// <summary>
            /// <para>The pod name of the exporter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>kafka-exporter-1</para>
            /// </summary>
            [NameInMap("PodName")]
            [Validation(Required=false)]
            public string PodName { get; set; }

            /// <summary>
            /// <para>Indicates whether the description is displayed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowDescribe")]
            [Validation(Required=false)]
            public bool? ShowDescribe { get; set; }

            /// <summary>
            /// <para>Indicates whether the exporter logs are displayed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ShowLog")]
            [Validation(Required=false)]
            public bool? ShowLog { get; set; }

            /// <summary>
            /// <para>The status of the exporter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>installed</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The monitored IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>121.40.62.240:3342</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

            /// <summary>
            /// <para>The version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.0.0</para>
            /// </summary>
            [NameInMap("Version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>The returned message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>message</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1F1D8840-5330-5804-A8DB-C3C5C5CED6BB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
