// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class GetPrometheusMonitoringResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// <para>The returned struct.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetPrometheusMonitoringResponseBodyData Data { get; set; }
        public class GetPrometheusMonitoringResponseBodyData : TeaModel {
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
            /// <para>The monitoring configuration. The value is a YAML string.</para>
            /// 
            /// <b>Example:</b>
            /// <para>apiVersion: monitoring.coreos.com/v1
            /// kind: ServiceMonitor
            /// metadata:
            ///   name: tomcat-demo
            ///   namespace: default
            /// spec:
            ///   endpoints:
            ///     - interval: 30s
            ///       path: /metrics
            ///       port: tomcat-monitor
            ///   namespaceSelector:
            ///     any: true
            ///   selector:
            ///     matchLabels:
            ///       app: tomcat</para>
            /// </summary>
            [NameInMap("ConfigYaml")]
            [Validation(Required=false)]
            public string ConfigYaml { get; set; }

            /// <summary>
            /// <para>The name of the monitoring configuration.</para>
            /// 
            /// <b>Example:</b>
            /// <para>customJob1</para>
            /// </summary>
            [NameInMap("MonitoringName")]
            [Validation(Required=false)]
            public string MonitoringName { get; set; }

            /// <summary>
            /// <para>The status of the monitoring configuration. Valid values: run and stop.</para>
            /// 
            /// <b>Example:</b>
            /// <para>run</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The type of the monitoring configuration. Valid values: serviceMonitor, podMonitor, customJob, and probe.</para>
            /// 
            /// <b>Example:</b>
            /// <para>serviceMonitor</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

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
        /// <para>78901766-3806-4E96-8E47-CFEF59E4****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
