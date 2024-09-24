// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskListRequest : TeaModel {
        /// <summary>
        /// <para>The <b>rule name</b> or <b>type name</b> of the risk. You can call the <a href="~~~~">DescribeImageBuildRiskList</a> operation to obtain the name. Optional parameters:</para>
        /// <list type="bullet">
        /// <item><description>If <b>CriteriaType</b> is set to <b>RiskKeyName</b>, you must specify a <b>rule name</b> for this parameter.</description></item>
        /// <item><description>If <b>CriteriaType</b> is set to<b>RiskClassName</b>, you must specify a <b>type name</b> for this parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no_user</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The query type.of the risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RiskKeyName</b>: the rule name of the risk</description></item>
        /// <item><description><b>RiskClassName</b>: the type name of the risk</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RiskKeyName</para>
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// <para>The page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

    }

}
