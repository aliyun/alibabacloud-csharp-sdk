// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDingTalkRequest : TeaModel {
        /// <summary>
        /// <para>The page number of the current page to display in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of notifications to display per page in a paged query. Default value: <b>20</b>, which indicates that up to 20 entries are displayed per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The notification name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>TestRuleAction</para>
        /// </summary>
        [NameInMap("RuleActionName")]
        [Validation(Required=false)]
        public string RuleActionName { get; set; }

    }

}
