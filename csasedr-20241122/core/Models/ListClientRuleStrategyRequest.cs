// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CsasEdr20241122.Models
{
    public class ListClientRuleStrategyRequest : TeaModel {
        /// <summary>
        /// <para>The current page number for the paged query with paging. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The policy name for substring matching. If this parameter is not specified, policies are not filtered by name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The number of entries per page for the paged query with paging. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The policy type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Software hardening.</description></item>
        /// <item><description><b>1</b>: Firewall.</description></item>
        /// <item><description><b>2</b>: Proactive defense.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PolicyType")]
        [Validation(Required=false)]
        public int? PolicyType { get; set; }

    }

}
