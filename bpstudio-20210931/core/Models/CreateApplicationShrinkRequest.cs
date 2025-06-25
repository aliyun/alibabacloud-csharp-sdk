// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20210931.Models
{
    public class CreateApplicationShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the region.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("AreaId")]
        [Validation(Required=false)]
        public string AreaId { get; set; }

        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1600765710019</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The parameters that are used to configure the application you want to create. For example, enableMonitor specifies whether to automatically create a CloudMonitor task for the application, and enableReport specifies whether to generate reports.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;enableMonitor&quot;:&quot;0&quot;, &quot;enableReport&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Configuration")]
        [Validation(Required=false)]
        public string ConfigurationShrink { get; set; }

        /// <summary>
        /// <para>The instances in which you want to create the application. You can create applications in an existing virtual private cloud (VPC).</para>
        /// </summary>
        [NameInMap("Instances")]
        [Validation(Required=false)]
        public string InstancesShrink { get; set; }

        /// <summary>
        /// <para>The name of the application.</para>
        /// <list type="bullet">
        /// <item><description>The application name must be unique. You can call the <a href="https://www.alibabacloud.com/help/en/bp-studio/latest/api-bpstudio-2021-09-31-listapplication">ListApplication</a> operation to query the existing applications.</description></item>
        /// <item><description>The application name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http:// or https://</c>. The name can contain letters, digits, underscores (_), and hyphens (-).</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cadt-application</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("ProcessVariables")]
        [Validation(Required=false)]
        public string ProcessVariablesShrink { get; set; }

        /// <summary>
        /// <para>The ID of the resource group to which the application you want to create belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmyjt3c5om3hi</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>The ID of the template.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0KSHPM6SJU03TNZP</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The parameter values that are contained in the template. If the template contains no parameter values, the default values are used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;variable1&quot;:&quot;1&quot;}</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string VariablesShrink { get; set; }

    }

}
