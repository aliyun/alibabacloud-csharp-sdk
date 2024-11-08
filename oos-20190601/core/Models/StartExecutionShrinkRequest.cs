// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class StartExecutionShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The access token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123e56767-e89b-12d3-a456-426655440000</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description of the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test execution.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The loop mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Automatic: does not suspend the execution of the template. This is the default value.</description></item>
        /// <item><description>FirstBatchPause: suspends the execution of the template after the first batch is complete.</description></item>
        /// <item><description>EveryBatchPause: suspends the execution of the template after each batch is complete.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Automatic</para>
        /// </summary>
        [NameInMap("LoopMode")]
        [Validation(Required=false)]
        public string LoopMode { get; set; }

        /// <summary>
        /// <para>The execution mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Automatic: automatically starts the execution of the template. This is the default value.</description></item>
        /// <item><description>FailurePause: suspends the execution of the template upon a failure.</description></item>
        /// <item><description>Debug: manually starts the execution of the template.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Automatic</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

        /// <summary>
        /// <para>The JSON string that consists of a set of parameters. Default value: {}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Status&quot;:&quot;Running&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The ID of the parent execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exec-xxx</para>
        /// </summary>
        [NameInMap("ParentExecutionId")]
        [Validation(Required=false)]
        public string ParentExecutionId { get; set; }

        /// <summary>
        /// <para>The ID of the region in which the execution resides.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The ID of the resource group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxsn4m4******</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The security check mode. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Skip: specifies that you are aware of the risks. The system performs all actions in the execution without manual confirmation, regardless of the risk level. This parameter is valid only if the <c>Mode</c> parameter is set to Automatic.</description></item>
        /// <item><description>ConfirmEveryHighRiskAction: requires you to confirm each high-risk action. This is the default value. You can call the <b>NotifyExecution</b> operation to confirm or cancel an action.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Skip</para>
        /// </summary>
        [NameInMap("SafetyCheck")]
        [Validation(Required=false)]
        public string SafetyCheck { get; set; }

        /// <summary>
        /// <para>The tags for the execution.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;k1&quot;:&quot;v2&quot;,&quot;k2&quot;:&quot;v2&quot;}</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string TagsShrink { get; set; }

        /// <summary>
        /// <para>The content of the template in the JSON or YAML format. This parameter is the same as the Content parameter that you can specify when you call the CreateTemplate operation. You can use this parameter to specify the tasks that you want to run. This way, you do not need to create a template before you start an execution. If you select an existing template, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;Description&quot;: &quot;Example template, describe instances in some status&quot;,   &quot;FormatVersion&quot;: &quot;OOS-2019-06-01&quot;,   &quot;Parameters&quot;: {},   &quot;Tasks&quot;: [     {       &quot;Name&quot;: &quot;describeInstances&quot;,       &quot;Action&quot;: &quot;ACS::ExecuteAPI&quot;,       &quot;Description&quot;: &quot;desc-en&quot;,       &quot;Properties&quot;: {         &quot;Service&quot;: &quot;ECS&quot;,         &quot;API&quot;: &quot;DescribeInstances&quot;,         &quot;Parameters&quot;: {           &quot;Status&quot;: &quot;Running&quot;         }       }     }   ] }</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The name of the template. The name must be 1 to 200 characters in length, and can contain letters, digits, hyphens (-), and underscores (_).</para>
        /// 
        /// <b>Example:</b>
        /// <para>vmeixme</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) URL of the object that stores the content of the Operation Orchestration Service (OOS) template. The access control list (ACL) of the object must be public-read. You can use this parameter to specify the tasks that you want to run. This way, you do not need to create a template before you start an execution. If you select an existing template, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oos-template.cn-hangzhou.oss.aliyun-inc.com/oos-test-template.json">http://oos-template.cn-hangzhou.oss.aliyun-inc.com/oos-test-template.json</a></para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version number of the template. If you do not specify this parameter, the system uses the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
