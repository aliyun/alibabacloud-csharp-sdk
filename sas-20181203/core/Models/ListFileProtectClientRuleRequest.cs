// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListFileProtectClientRuleRequest : TeaModel {
        /// <summary>
        /// <para>The alert notification level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>0: no alert</para>
        /// </description></item>
        /// <item><description><para>1: reminder</para>
        /// </description></item>
        /// <item><description><para>2: suspicious</para>
        /// </description></item>
        /// <item><description><para>3: high-risk.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("AlertLevel")]
        [Validation(Required=false)]
        public int? AlertLevel { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The operating system type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>windows</b>: Windows</description></item>
        /// <item><description><b>linux</b>: Linux.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>linux</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <para>The rule action. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>block</b>: blocks the request.</para>
        /// </description></item>
        /// <item><description><para><b>monitor</b>: monitors the request.</para>
        /// </description></item>
        /// <item><description><para><b>pass</b>: allows the request.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>pass</para>
        /// </summary>
        [NameInMap("RuleAction")]
        [Validation(Required=false)]
        public string RuleAction { get; set; }

        /// <summary>
        /// <para>The rule name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tetsRule</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

    }

}
