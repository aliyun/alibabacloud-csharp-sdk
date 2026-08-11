// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20251111.Models
{
    public class ListScriptProfileTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The return code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListScriptProfileTemplatesResponseBodyData> Data { get; set; }
        public class ListScriptProfileTemplatesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time, in millisecond-level timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735660800000</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public long? CreatedTime { get; set; }

            /// <summary>
            /// <para>The description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>As a survey specialist, sequentially ask about overall service satisfaction, service highlights, improvement suggestions, service efficiency, employee attitude, and willingness to choose again, and collect information</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The label definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;Overall Satisfaction\&quot;,\&quot;description\&quot;:\&quot;Collect evaluation information on overall service satisfaction\&quot;,\&quot;candidateValues\&quot;:[\&quot;Very Satisfied\&quot;,\&quot;Satisfied\&quot;,\&quot;Average\&quot;,\&quot;Dissatisfied\&quot;,\&quot;Very Dissatisfied\&quot;]},{\&quot;name\&quot;:\&quot;Service Highlights\&quot;,\&quot;description\&quot;:\&quot;Customer description of service highlights or satisfactory aspects\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;Improvement Suggestions\&quot;,\&quot;description\&quot;:\&quot;Customer description of improvement suggestions\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;Service Efficiency\&quot;,\&quot;description\&quot;:\&quot;Customer feedback on service response speed and timeliness of service completion\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;Employee Attitude\&quot;,\&quot;description\&quot;:\&quot;Customer evaluation of service personnel professionalism and attitude\&quot;,\&quot;candidateValues\&quot;:[]},{\&quot;name\&quot;:\&quot;Willingness to Choose Again\&quot;,\&quot;description\&quot;:\&quot;Whether the customer is willing to choose again\&quot;,\&quot;candidateValues\&quot;:[\&quot;Yes\&quot;,\&quot;No\&quot;]}]</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public string Labels { get; set; }

            /// <summary>
            /// <para>The name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Service Satisfaction Survey</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The template details.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{\&quot;name\&quot;:\&quot;Li Ming\&quot;,\&quot;gender\&quot;:\&quot;Male\&quot;}</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public string Schema { get; set; }

            /// <summary>
            /// <para>The template ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4f9a8e2b-6c1d-4a7e-9b3f-2d5c8a1e7b04</para>
            /// </summary>
            [NameInMap("TemplateId")]
            [Validation(Required=false)]
            public string TemplateId { get; set; }

            /// <summary>
            /// <para>The update time, in millisecond-level timestamp.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1735660800000</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public long? UpdatedTime { get; set; }

            /// <summary>
            /// <para>The variable definition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[{\&quot;name\&quot;:\&quot;name\&quot;,\&quot;description\&quot;:\&quot;Customer name\&quot;},{\&quot;name\&quot;:\&quot;gender\&quot;,\&quot;description\&quot;:\&quot;Customer gender\&quot;}]</para>
            /// </summary>
            [NameInMap("Variables")]
            [Validation(Required=false)]
            public string Variables { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Instance does not exist. Instance=ob-9876543210.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The list of variable values in the error message.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>019FDAC7-13C5-1B64-A853-999DF105B9EF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
