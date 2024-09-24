// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListInterceptionRulePageRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the container cluster.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cc41de13ab5474210bc0ce772a009****</para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The type of the query condition. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ID</b></description></item>
        /// <item><description><b>RULE_NAME</b></description></item>
        /// <item><description><b>SRC_TARGET</b></description></item>
        /// <item><description><b>DST_TARGET</b></description></item>
        /// <item><description><b>DST_PORT</b></description></item>
        /// <item><description><b>RULE_SWITCH</b></description></item>
        /// <item><description><b>INTERCEPTOR_TYPE</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>DST_PORT</para>
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

    }

}
