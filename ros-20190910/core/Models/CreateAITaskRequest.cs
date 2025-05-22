// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class CreateAITaskRequest : TeaModel {
        /// <summary>
        /// <para>The input description for the AI task.</para>
        /// <list type="bullet">
        /// <item><description>When the task type is Generate Template, this parameter specifies the functionality of the template to be generated.</description></item>
        /// <item><description>When the task type is FixTemplate, this parameter can describe how the template should be repaired.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>创建一台ECS，部署nignx服务</para>
        /// </summary>
        [NameInMap("Prompt")]
        [Validation(Required=false)]
        public string Prompt { get; set; }

        /// <summary>
        /// <para>The type of AI task. Values:</para>
        /// <list type="bullet">
        /// <item><description>GenerateTemplate: AI template generation</description></item>
        /// <item><description>FixTemplate: AI template repair</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>GenerateTemplate</para>
        /// </summary>
        [NameInMap("TaskType")]
        [Validation(Required=false)]
        public string TaskType { get; set; }

        /// <summary>
        /// <para>When the task type is AI template repair, specify the original template that needs to be fixed or modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;: &quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

        /// <summary>
        /// <para>The type of the template to be generated or repaired. Default is ROS.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ROS</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
