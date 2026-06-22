// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageListByBuildRiskRequest : TeaModel {
        /// <summary>
        /// <para>The value of the condition parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The name of the condition parameter. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RepoNamespace</b>: namespace.</description></item>
        /// <item><description><b>RepoName</b>: repository name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RepoNamespace</para>
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// <para>The page number of the current page in paging query. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in paging query. Default value: 20. If you leave this parameter empty, 20 entries are returned.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The key of the build risk rule. You can call the <a href="~~~~">DescribeImageBuildRiskList</a> operation to obtain the RiskKey.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no_user</para>
        /// </summary>
        [NameInMap("RiskKey")]
        [Validation(Required=false)]
        public string RiskKey { get; set; }

        /// <summary>
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        /// <summary>
        /// <para>The status of the alert event to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>0</b>: Unhandled.</description></item>
        /// <item><description><b>1</b>: Ignored.</description></item>
        /// <item><description><b>2</b>: False positive.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

    }

}
