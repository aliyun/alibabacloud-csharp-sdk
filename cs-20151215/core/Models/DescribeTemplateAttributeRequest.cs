// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplateAttributeRequest : TeaModel {
        /// <summary>
        /// <para>The templatetype.</para>
        /// <list type="bullet">
        /// <item><description><para>If you set this parameter to <c>kubernetes</c>, the template is displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// <item><description><para>If you leave this parameter empty or set it to other values, the template is not displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// </list>
        /// <para>Settings this parameter to <c>kubernetes</c> is recommended.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes</para>
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
