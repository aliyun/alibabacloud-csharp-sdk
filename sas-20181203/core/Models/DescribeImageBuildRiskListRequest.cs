// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeImageBuildRiskListRequest : TeaModel {
        /// <summary>
        /// <para>The <b>rule name</b> or <b>category name</b> of the build risk. You can call the <a href="~~~~">DescribeImageBuildRiskList</a> operation to obtain the value. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>If <b>CriteriaType</b> is set to <b>RiskKeyName</b>, the value is the <b>rule name</b> of the build risk.</description></item>
        /// <item><description>If <b>CriteriaType</b> is set to <b>RiskClassName</b>, the value is the <b>category name</b> of the build risk.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no_user</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The query type of the build risk. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>RiskKeyName</b>: build risk rule name.</description></item>
        /// <item><description><b>RiskClassName</b>: build risk category name.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>RiskKeyName</para>
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// <para>The page number of the current page when paging is used. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The language of the content in the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese.</description></item>
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
        /// <para>The maximum number of entries per page when paging is used. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
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
        /// <para>The risk level. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>high</b>: High.</para>
        /// </description></item>
        /// <item><description><para><b>medium</b>: Medium.</para>
        /// </description></item>
        /// <item><description><para><b>low</b>: Low.</para>
        /// </description></item>
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
