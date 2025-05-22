// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class ListAITaskEventsResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Forbidden</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The events.</para>
        /// </summary>
        [NameInMap("Events")]
        [Validation(Required=false)]
        public List<ListAITaskEventsResponseBodyEvents> Events { get; set; }
        public class ListAITaskEventsResponseBodyEvents : TeaModel {
            /// <summary>
            /// <para>The type of the agent that is used to execute the AI task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>GenerateTemplateAgent</description></item>
            /// <item><description>FixUserTemplateAgent</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GenerateTemplateAgent</para>
            /// </summary>
            [NameInMap("AgentType")]
            [Validation(Required=false)]
            public string AgentType { get; set; }

            /// <summary>
            /// <para>The time when the event was created. The time follows the ISO 8601 standard in the YYYY-MM-DDThh:mm:ss format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2019-08-01T04:07:39</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The estimated execution time of the handler. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("EstimatedProcessingTime")]
            [Validation(Required=false)]
            public string EstimatedProcessingTime { get; set; }

            /// <summary>
            /// <para>The details of the event.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Document template generator started.</para>
            /// </summary>
            [NameInMap("EventData")]
            [Validation(Required=false)]
            public string EventData { get; set; }

            /// <summary>
            /// <para>The execution state of the handler that process the AI task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>SUCCESS</description></item>
            /// <item><description>RUNNING</description></item>
            /// <item><description>FAILURE</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>RUNNING</para>
            /// </summary>
            [NameInMap("HandlerProcessStatus")]
            [Validation(Required=false)]
            public string HandlerProcessStatus { get; set; }

            /// <summary>
            /// <para>The type of the handler that is used to execute the task.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description>TerraformTemplateGenerator</description></item>
            /// <item><description>TemplateGenerator</description></item>
            /// <item><description>ROSTemplateModifier</description></item>
            /// <item><description>TerraformTemplateStaticFixer</description></item>
            /// <item><description>TerraformTemplateDynamicFixer</description></item>
            /// <item><description>DocumentTemplateGenerator</description></item>
            /// <item><description>TerraformTemplateModifier</description></item>
            /// <item><description>TemplateModifier</description></item>
            /// <item><description>FixTemplateInputPreprocessor</description></item>
            /// <item><description>TemplateStaticFixer</description></item>
            /// <item><description>GenerateTemplateInputPreprocessor</description></item>
            /// <item><description>ROSTemplateGenerator</description></item>
            /// <item><description>TemplateDynamicFixer</description></item>
            /// <item><description>BaseDynamicFixer</description></item>
            /// <item><description>ROSTemplateStaticFixer</description></item>
            /// <item><description>ROSTemplateDynamicFixer</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>ROSTemplateGenerator</para>
            /// </summary>
            [NameInMap("HandlerType")]
            [Validation(Required=false)]
            public string HandlerType { get; set; }

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
        /// <para>A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdDWBF2****w==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B288A0BE-D927-4888-B0F7-B35EF84B6E6F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

        /// <summary>
        /// <para>The ID of the AI task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>t-asasas*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

        /// <summary>
        /// <para>The state of the AI task.</para>
        /// <list type="bullet">
        /// <item><description>PENDING</description></item>
        /// <item><description>WAITING</description></item>
        /// <item><description>RUNNING</description></item>
        /// <item><description>SUCCESS</description></item>
        /// <item><description>FAILURE</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RUNNING</para>
        /// </summary>
        [NameInMap("TaskStatus")]
        [Validation(Required=false)]
        public string TaskStatus { get; set; }

        /// <summary>
        /// <para>The type of the AI task.</para>
        /// <list type="bullet">
        /// <item><description>GenerateTemplate: The AI task is used to generate a template.</description></item>
        /// <item><description>FixTemplate: The AI task is used to fix a template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GenerateTemplate</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

    }

}
