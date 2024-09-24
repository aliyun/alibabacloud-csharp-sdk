// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListAITaskEventsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>Forbidden</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<ListAITaskEventsResponseBodyEvents> Events { get; set; }
        public class ListAITaskEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>GenerateTemplateAgent</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2019-08-01T04:07:39</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("EstimatedProcessingTime")]
            [Validation(Required=false)]
            public string EstimatedProcessingTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>Document template generator started.</para>
            /// </summary>
            [NameInMap("EventData")]
            [Validation(Required=false)]
            public string EventData { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("HandlerProcessStatus")]
            [Validation(Required=false)]
            public string HandlerProcessStatus { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ROSTemplateGenerator</para>
            /// </summary>
            [NameInMap("HandlerType")]
            [Validation(Required=false)]
            public string HandlerType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****w==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
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
        public string Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>t-asasas*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>GenerateTemplate</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
