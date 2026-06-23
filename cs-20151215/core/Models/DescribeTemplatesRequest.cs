// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The page number to return when paginating query results.</para>
        /// <para>Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_num")]
        [Validation(Required=false)]
        public long? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries per page when paginating query results.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The templatetype.</para>
        /// <list type="bullet">
        /// <item><description><para>If the value is set to <c>kubernetes</c>, the template is displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// <item><description><para>If this parameter is left empty or set to other values, the template is not displayed on the Orchestration Templates page in the console.</para>
        /// </description></item>
        /// </list>
        /// <para>Set this parameter to <c>kubernetes</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>kubernetes</para>
        /// </summary>
        [NameInMap("template_type")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
