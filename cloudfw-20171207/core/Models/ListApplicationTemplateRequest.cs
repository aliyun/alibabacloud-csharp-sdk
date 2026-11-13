// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloudfw20171207.Models
{
    public class ListApplicationTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the application templates for batch exact matching.</para>
        /// </summary>
        [NameInMap("ApplicationTemplateIds")]
        [Validation(Required=false)]
        public List<string> ApplicationTemplateIds { get; set; }

        /// <summary>
        /// <para>The name of the application template for fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Application template</para>
        /// </summary>
        [NameInMap("ApplicationTemplateName")]
        [Validation(Required=false)]
        public string ApplicationTemplateName { get; set; }

        /// <summary>
        /// <para>The switch status of built-in application control for exact matching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("BuiltInApplicationStatus")]
        [Validation(Required=false)]
        public string BuiltInApplicationStatus { get; set; }

        /// <summary>
        /// <para>The switch status of custom application rules for exact matching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("CustomRuleStatus")]
        [Validation(Required=false)]
        public string CustomRuleStatus { get; set; }

        /// <summary>
        /// <para>The description of the application template for fuzzy matching.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Office network application control</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. The value must be greater than or equal to 1. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The overall switch status of the application template for exact matching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enabled.</description></item>
        /// <item><description><b>Disable</b>: Disabled.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("TemplateStatus")]
        [Validation(Required=false)]
        public string TemplateStatus { get; set; }

        /// <summary>
        /// <para>The action for unidentified applications for exact matching. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Allow</b>: Allow.</description></item>
        /// <item><description><b>Alert</b>: Monitor.</description></item>
        /// <item><description><b>Deny</b>: Block.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Alert</para>
        /// </summary>
        [NameInMap("UnknownAction")]
        [Validation(Required=false)]
        public string UnknownAction { get; set; }

    }

}
