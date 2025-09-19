// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>List of check item risk statistics.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCheckItemWarningSummaryResponseBodyList> List { get; set; }
        public class ListCheckItemWarningSummaryResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The suggestion on the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>In the Administrative Tools window, double-click Local Security Policy. In the Local Security Policy window that appears, choose Security Settings\\Local Policies\\Audit Policy, configure all audit policies as: <c>Success, Failure</c>.</para>
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// <para>The types of the baselines to which the check item belongs.</para>
            /// </summary>
            [NameInMap("AffiliatedRiskTypes")]
            [Validation(Required=false)]
            public List<string> AffiliatedRiskTypes { get; set; }

            /// <summary>
            /// <para>The baselines to which the check item belongs.</para>
            /// </summary>
            [NameInMap("AffiliatedRisks")]
            [Validation(Required=false)]
            public List<string> AffiliatedRisks { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The alias of the baseline type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>week_pa****</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            [Obsolete]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The ID of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>696</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Config the Event Audit policys</para>
            /// </summary>
            [NameInMap("CheckItem")]
            [Validation(Required=false)]
            public string CheckItem { get; set; }

            /// <summary>
            /// <para>The risk level of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>high</b></description></item>
            /// <item><description><b>medium</b></description></item>
            /// <item><description><b>low</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("CheckLevel")]
            [Validation(Required=false)]
            public string CheckLevel { get; set; }

            /// <summary>
            /// <para>The type of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security audit</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>Indicates whether the check item belongs to the container runtime type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContainerCheckItem")]
            [Validation(Required=false)]
            public bool? ContainerCheckItem { get; set; }

            /// <summary>
            /// <para>The description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Config the Event Audit policys</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The baselines in which the check item is enabled.</para>
            /// </summary>
            [NameInMap("EnableRisks")]
            [Validation(Required=false)]
            public List<string> EnableRisks { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The type of the baseline.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weak_password</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            [Obsolete]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>Risk status of check items. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: failed</description></item>
            /// <item><description><b>3</b>: passed</description></item>
            /// <item><description><b>6</b>: whitelisted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The number of servers that are affected by the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WarningMachineCount")]
            [Validation(Required=false)]
            public int? WarningMachineCount { get; set; }

        }

        /// <summary>
        /// <para>The pagination information.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemWarningSummaryResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemWarningSummaryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of entries returned on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of entries returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC97C9EC-4B7D-5EFF-8A5E-A5CCC9ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
