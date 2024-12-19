// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetTemplateParameterConstraintsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;endDate\&quot;: \&quot;2022-04-13T03:31:20Z\&quot;, \&quot;Status\&quot;: \&quot;Stopped\&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The content of the template in the JSON or YAML format. This parameter is the same as the Content parameter that you can specify when you call the CreateTemplate operation. You can use this parameter to specify the tasks that you want to run. This way, you do not need to create a template before you start an execution. If you select an existing template, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;Description&quot;: &quot;Example template, describe instances in some status&quot;,
        ///     &quot;FormatVersion&quot;: &quot;OOS-2019-06-01&quot;,
        ///     &quot;Parameters&quot;: {},
        ///     &quot;Tasks&quot;: [{
        ///         &quot;Name&quot;: &quot;describeInstances&quot;,
        ///         &quot;Action&quot;: &quot;ACS::ExecuteAPI&quot;,
        ///         &quot;Description&quot;: &quot;desc-en&quot;,
        ///         &quot;Properties&quot;: {
        ///             &quot;Service&quot;: &quot;ECS&quot;,
        ///             &quot;API&quot;: &quot;DescribeInstances&quot;,
        ///             &quot;Parameters&quot;: {
        ///                 &quot;Status&quot;: &quot;Running&quot;
        ///             }
        ///         }
        ///     }]
        /// }</para>
        /// </summary>
        [NameInMap("TemplateContent")]
        [Validation(Required=false)]
        public string TemplateContent { get; set; }

        /// <summary>
        /// <para>The name of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyTemplate</para>
        /// </summary>
        [NameInMap("TemplateName")]
        [Validation(Required=false)]
        public string TemplateName { get; set; }

        /// <summary>
        /// <para>The URL that is used to store the content of the Operation Orchestration Service (OOS) template in the Alibaba Cloud Object Storage Service (OSS). Only the public-read URL is supported. You can use this parameter to specify the tasks that you want to run. This way, you do not need to create a template before you start an execution. If you select an existing template, you do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://oos-template.cn-hangzhou.oss.aliyun-inc.com/oos-test-template.json">http://oos-template.cn-hangzhou.oss.aliyun-inc.com/oos-test-template.json</a></para>
        /// </summary>
        [NameInMap("TemplateURL")]
        [Validation(Required=false)]
        public string TemplateURL { get; set; }

        /// <summary>
        /// <para>The version of the template. The default value is the latest version of the template.</para>
        /// 
        /// <b>Example:</b>
        /// <para>v1</para>
        /// </summary>
        [NameInMap("TemplateVersion")]
        [Validation(Required=false)]
        public string TemplateVersion { get; set; }

    }

}
