// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class UpdateWebFlowRuleResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public UpdateWebFlowRuleResponseBodyData Data { get; set; }
        public class UpdateWebFlowRuleResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>hkhon1XXXX@54e1f42f37cXXXX</para>
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>spring-cloud-a</para>
            /// </summary>
            [NameInMap("AppName")]
            [Validation(Required=false)]
            public string AppName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Burst")]
            [Validation(Required=false)]
            public int? Burst { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ControlBehavior")]
            [Validation(Required=false)]
            public int? ControlBehavior { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Enable")]
            [Validation(Required=false)]
            public bool? Enable { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>200</para>
            /// </summary>
            [NameInMap("MaxQueueingTimeMs")]
            [Validation(Required=false)]
            public int? MaxQueueingTimeMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MetricType")]
            [Validation(Required=false)]
            public int? MetricType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>default</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;fieldName&quot;:&quot;testKey&quot;,&quot;matchStrategy&quot;:2,&quot;parseStrategy&quot;:2,&quot;pattern&quot;:&quot;testValue&quot;}</para>
            /// </summary>
            [NameInMap("ParamItem")]
            [Validation(Required=false)]
            public string ParamItem { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ReourceMode")]
            [Validation(Required=false)]
            public int? ReourceMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>/flow</para>
            /// </summary>
            [NameInMap("Resource")]
            [Validation(Required=false)]
            public string Resource { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("StatIntervalMs")]
            [Validation(Required=false)]
            public int? StatIntervalMs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public float? Threshold { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>54973C90-F379-4372-9AA5-053A3F7****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
