// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class GetOperationParamsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOperationParamsResponseBodyData Data { get; set; }
        public class GetOperationParamsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;tags&quot;: {
            ///         &quot;controlType&quot;: &quot;KeyValue&quot;,
            ///         &quot;display&quot;: &quot;Label&quot;,
            ///         &quot;orderBy&quot;: 0,
            ///         &quot;associatedLabel&quot;: true,
            ///         &quot;required&quot;: true
            ///       }
            ///     }</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, object> Attributes { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>rename</para>
            /// </summary>
            [NameInMap("Operation")]
            [Validation(Required=false)]
            public string Operation { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;instance_id&quot;: {
            ///         &quot;display&quot;: &quot;ECS instance ID&quot;,
            ///         &quot;dataType&quot;: &quot;String&quot;,
            ///         &quot;orderBy&quot;: 0,
            ///         &quot;attributeName&quot;: &quot;instance_id&quot;,
            ///         &quot;enableVariable&quot;: &quot;String&quot;,
            ///         &quot;required&quot;: true
            ///       },
            ///       &quot;instance_name&quot;: {
            ///         &quot;display&quot;: &quot;ECS name&quot;,
            ///         &quot;dataType&quot;: &quot;String&quot;,
            ///         &quot;orderBy&quot;: 0,
            ///         &quot;attributeName&quot;: &quot;instance_name&quot;,
            ///         &quot;required&quot;: true
            ///       },
            ///       &quot;private_ip&quot;: {
            ///         &quot;display&quot;: &quot;Intranet IP&quot;,
            ///         &quot;dataType&quot;: &quot;String&quot;,
            ///         &quot;orderBy&quot;: 0,
            ///         &quot;value&quot;: &quot;private_ip&quot;,
            ///         &quot;required&quot;: true
            ///       }
            ///     }</para>
            /// </summary>
            [NameInMap("Outputs")]
            [Validation(Required=false)]
            public Dictionary<string, object> Outputs { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{
            ///       &quot;instanceId&quot;: &quot;ResourceId&quot;,
            ///       &quot;regionId&quot;: &quot;region&quot;,
            ///       &quot;appId&quot;: &quot;appId&quot;
            ///     }</para>
            /// </summary>
            [NameInMap("Properties")]
            [Validation(Required=false)]
            public Dictionary<string, object> Properties { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ecs</para>
            /// </summary>
            [NameInMap("Service")]
            [Validation(Required=false)]
            public string Service { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>getBpmOperationParams errors</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F439A659-3B3D-50FB-A4BC-69FBF16413C8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
