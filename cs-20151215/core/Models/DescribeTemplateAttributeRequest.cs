// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The type of template. The value can be a custom value.</para>
        /// <list type="bullet">
        /// <item><description>If the parameter is set to <c>kubernetes</c>, the template is displayed on the Templates page in the console.</description></item>
        /// <item><description>If the parameter is set to <c>compose</c>, the template is displayed on the Container Service - Swarm page in the console. Container Service for Swarm is deprecated.</description></item>
        /// <item><description>If the value of the parameter is not <c>kubernetes</c>, the template is not displayed on the Templates page in the console. We recommend that you set the parameter to <c>kubernetes</c>.</description></item>
        /// </list>
        /// <para>Default value: <c>kubernetes</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes</para>
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
