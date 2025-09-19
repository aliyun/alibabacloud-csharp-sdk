// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckRuleRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the check item.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~ListCheckResult~~">ListCheckResult</a> API to get the check item ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>58</para>
        /// </summary>
        [NameInMap("CheckId")]
        [Validation(Required=false)]
        public long? CheckId { get; set; }

        /// <summary>
        /// <para>The name of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>checkName</para>
        /// </summary>
        [NameInMap("CheckName")]
        [Validation(Required=false)]
        public string CheckName { get; set; }

        /// <summary>
        /// <para>The page number displayed in a paginated query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>Set the language type for the request and response messages. The default is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description>zh: Chinese</description></item>
        /// <item><description>en: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of check items displayed per page in a paginated query. The default value is <b>20</b>, indicating 20 check items per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of rule. Default is <b>WHITE</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>WHITE</b>: Add to whitelist</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WHITE</para>
        /// </summary>
        [NameInMap("RuleType")]
        [Validation(Required=false)]
        public string RuleType { get; set; }

        /// <summary>
        /// <para>The scope where the rule applies. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>INSTNACE</b>: Instance</description></item>
        /// <item><description><b>ITEM</b>: Check item</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>INSTANCE</para>
        /// </summary>
        [NameInMap("ScopeType")]
        [Validation(Required=false)]
        public string ScopeType { get; set; }

        [NameInMap("TaskSources")]
        [Validation(Required=false)]
        public List<string> TaskSources { get; set; }

    }

}
