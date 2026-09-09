// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The fuzzy match for the check item name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("CheckItemFuzzy")]
        [Validation(Required=false)]
        public string CheckItemFuzzy { get; set; }

        /// <summary>
        /// <para>The risk level. Default value: null, which indicates that all levels are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b>: High.</description></item>
        /// <item><description><b>medium</b>: Medium.</description></item>
        /// <item><description><b>low</b>: Low.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("CheckLevel")]
        [Validation(Required=false)]
        public string CheckLevel { get; set; }

        /// <summary>
        /// <para>The check item category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc.check.type.attack_defense</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public string CheckType { get; set; }

        /// <summary>
        /// <para>The risk status. Default value: null, which indicates that all statuses are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: Failed.</description></item>
        /// <item><description><b>3</b>: Passed.</description></item>
        /// <item><description><b>6</b>: Whitelisted.</description></item>
        /// <item><description><b>8</b>: Fixed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CheckWarningStatus")]
        [Validation(Required=false)]
        public int? CheckWarningStatus { get; set; }

        /// <summary>
        /// <para>The list of risk statuses. If both this parameter and CheckWarningStatus are specified, only CheckWarningStatus takes effect.</para>
        /// </summary>
        [NameInMap("CheckWarningStatusList")]
        [Validation(Required=false)]
        public List<int?> CheckWarningStatusList { get; set; }

        /// <summary>
        /// <para>The container security query parameter name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The container security query parameter value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c471f0f61b9c04f8380556e922cf1****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The page number of the page to return. Default value: <b>1</b>, which indicates that query results are displayed starting from page 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the asset group to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1161****</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The maximum number of entries per page when paging. Default value: 20. If the PageSize parameter is left empty, 20 entries are returned per page.</para>
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
        /// <para>The ID of the member accounts in the resource directory (Alibaba Cloud account).</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The baseline category name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weak_password</para>
        /// </summary>
        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

        /// <summary>
        /// <para>The data source. Default value: <b>default</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>agentless</b>: agentless detection.</description></item>
        /// <item><description><b>default</b>: host baseline.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The start time for filtering alerts. This parameter takes effect only when you query historical processed alerts. Specify a UNIX timestamp in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1732793158366</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The list of server UUIDs to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeCloudCenterInstances</a> operation to obtain the UUID of a server.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
