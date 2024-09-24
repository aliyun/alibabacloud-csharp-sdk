// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ROS20190910.Models
{
    public class GenerateTemplatePolicyRequest : TeaModel {
        /// <summary>
        /// <para>The type of operation N for which you want to generate the policy information.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreateStack: creates a stack by calling the CreateStack operation.</description></item>
        /// <item><description>UpdateStack: updates a stack by calling the UpdateStack operation.</description></item>
        /// <item><description>DeleteStack: deletes a stack by calling the DeleteStack operation.</description></item>
        /// <item><description>DetectStackDrift: detects drifts on a stack by calling the DelectStackDrift operation.</description></item>
        /// <item><description>ListStackOperationRisks: lists the risks of a deletion operation on a stack by setting the OperationType parameter to DeleteStack in the ListStackOperationRisks operation.</description></item>
        /// <item><description>GetTemplateEstimateCost: queries the estimated prices of resources that you want to use in the template by calling the GetTemplateEstimateCost operation.</description></item>
        /// <item><description>GetTemplateParameterConstraints: queries the values of parameters in the template by calling the GetTemplateParameterConstraints operation.</description></item>
        /// <item><description>ImportResourcesToStack: imports resources to a stack by setting the ChangeSetType parameter to IMPORT in the CreateChangeSet operation.</description></item>
        /// <item><description>SignalResource: sends a signal to a stack.</description></item>
        /// </list>
        /// <remarks>
        /// <para> The default value is the combination of all valid values.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("OperationTypes")]
        [Validation(Required=false)]
        public List<string> OperationTypes { get; set; }

        /// <summary>
        /// <para>The structure that contains the template body. The template body must be 1 to 524,288 bytes in length.</para>
        /// <para>If the length of the template body exceeds the upper limit, we recommend that you add parameters to the HTTP POST request body to prevent request failures caused by excessively long URLs.</para>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ROSTemplateFormatVersion&quot;:&quot;2015-09-01&quot;}</para>
        /// </summary>
        [NameInMap("TemplateBody")]
        [Validation(Required=false)]
        public string TemplateBody { get; set; }

        /// <summary>
        /// <para>The ID of the template. This parameter applies to shared templates and private templates.</para>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ecd1e10-b0e9-4389-a565-e4c15efc****</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The URL of the file that contains the template body. The URL must point to a template that is located on an HTTP or HTTPS web server or in an Object Storage Service (OSS) bucket, such as oss://ros/template/demo or oss://ros/template/demo?RegionId=cn-hangzhou. The template body can be up to 524,288 bytes in length.</para>
        /// <remarks>
        /// <para> If you do not specify the region ID of the OSS bucket, the value of the RegionId parameter is used.</para>
        /// </remarks>
        /// <para>You can specify only one of the following parameters: TemplateBody, TemplateURL, and TemplateId.</para>
        /// <para>The URL can be up to 1,024 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://ros/template/demo</para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. This parameter takes effect only when the TemplateId parameter is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
