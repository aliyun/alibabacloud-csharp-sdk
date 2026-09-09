// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningSummaryResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of check item risk statistics information.</para>
        /// </summary>
        [NameInMap("List")]
        [Validation(Required=false)]
        public List<ListCheckItemWarningSummaryResponseBodyList> List { get; set; }
        public class ListCheckItemWarningSummaryResponseBodyList : TeaModel {
            /// <summary>
            /// <para>The suggestion for the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>In the Administrative Tools window, double-click Local Security Policy. In the Local Security Policy window that appears, choose Security Settings\\Local Policies\\Audit Policy, configure all audit policies as: <c>Success, Failure</c>.</para>
            /// </summary>
            [NameInMap("Advice")]
            [Validation(Required=false)]
            public string Advice { get; set; }

            /// <summary>
            /// <para>The list of affiliated baseline categories.</para>
            /// </summary>
            [NameInMap("AffiliatedRiskTypes")]
            [Validation(Required=false)]
            public List<string> AffiliatedRiskTypes { get; set; }

            /// <summary>
            /// <para>The list of affiliated baselines.</para>
            /// </summary>
            [NameInMap("AffiliatedRisks")]
            [Validation(Required=false)]
            public List<string> AffiliatedRisks { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The baseline category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>week_pa****</para>
            /// </summary>
            [NameInMap("Alias")]
            [Validation(Required=false)]
            [Obsolete]
            public string Alias { get; set; }

            /// <summary>
            /// <para>The check item ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>696</para>
            /// </summary>
            [NameInMap("CheckId")]
            [Validation(Required=false)]
            public long? CheckId { get; set; }

            /// <summary>
            /// <para>The check item description.</para>
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
            /// <item><description><b>high</b>: High.</description></item>
            /// <item><description><b>medium</b>: Medium.</description></item>
            /// <item><description><b>low</b>: Low.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>high</para>
            /// </summary>
            [NameInMap("CheckLevel")]
            [Validation(Required=false)]
            public string CheckLevel { get; set; }

            /// <summary>
            /// <para>The check item category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Security audit</para>
            /// </summary>
            [NameInMap("CheckType")]
            [Validation(Required=false)]
            public string CheckType { get; set; }

            /// <summary>
            /// <para>Indicates whether the check item belongs to the container runtime category. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>true</b>: Yes.</description></item>
            /// <item><description><b>false</b>: No.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ContainerCheckItem")]
            [Validation(Required=false)]
            public bool? ContainerCheckItem { get; set; }

            /// <summary>
            /// <para>The detailed description of the check item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Config the Event Audit policys</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The list of baselines enabled for the check item.</para>
            /// </summary>
            [NameInMap("EnableRisks")]
            [Validation(Required=false)]
            public List<string> EnableRisks { get; set; }

            /// <term><b>Obsolete</b></term>
            /// 
            /// <summary>
            /// <para>The baseline category.</para>
            /// 
            /// <b>Example:</b>
            /// <para>weak_password</para>
            /// </summary>
            [NameInMap("RiskType")]
            [Validation(Required=false)]
            [Obsolete]
            public string RiskType { get; set; }

            /// <summary>
            /// <para>The risk status of the check item. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>1</b>: Failed.</description></item>
            /// <item><description><b>3</b>: Passed.</description></item>
            /// <item><description><b>6</b>: Whitelisted.</description></item>
            /// <item><description><b>8</b>: Fixed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The number of machines affected by the check item risk.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("WarningMachineCount")]
            [Validation(Required=false)]
            public int? WarningMachineCount { get; set; }

        }

        /// <summary>
        /// <para>The pagination information of the query result.</para>
        /// </summary>
        [NameInMap("PageInfo")]
        [Validation(Required=false)]
        public ListCheckItemWarningSummaryResponseBodyPageInfo PageInfo { get; set; }
        public class ListCheckItemWarningSummaryResponseBodyPageInfo : TeaModel {
            /// <summary>
            /// <para>The number of check items displayed on the current page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>The page number of the current page when paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// <para>The maximum number of entries per page when paging.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of check items returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>149</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which is a unique identifier generated by Alibaba Cloud for the request. You can use this ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>DC97C9EC-4B7D-5EFF-8A5E-A5CCC9ED****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
