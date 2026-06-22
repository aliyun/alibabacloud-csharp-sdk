// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListSystemClientRulesRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the aggregation types for rules.</para>
        /// </summary>
        [NameInMap("AggregationIds")]
        [Validation(Required=false)]
        public List<int?> AggregationIds { get; set; }

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
        /// <para>Specifies whether to query only container images. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>0</b>: no</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: yes</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("IsContainer")]
        [Validation(Required=false)]
        public int? IsContainer { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>zh</b>: Chinese</para>
        /// </description></item>
        /// <item><description><para><b>en</b>: English</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The name of the system defense rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>规则****</para>
        /// </summary>
        [NameInMap("RuleName")]
        [Validation(Required=false)]
        public string RuleName { get; set; }

        /// <summary>
        /// <para>The types of the system defense rules.</para>
        /// </summary>
        [NameInMap("RuleTypes")]
        [Validation(Required=false)]
        public List<int?> RuleTypes { get; set; }

        /// <summary>
        /// <para>The type of the OS. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>2</b>: Windows</para>
        /// </description></item>
        /// <item><description><para><b>1</b>: Linux</para>
        /// </description></item>
        /// <item><description><para><b>0</b>: all types</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SystemType")]
        [Validation(Required=false)]
        public int? SystemType { get; set; }

    }

}
