// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ListCheckItemWarningSummaryRequest : TeaModel {
        /// <summary>
        /// <para>The name of the check item. Fuzzy match is supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>password</para>
        /// </summary>
        [NameInMap("CheckItemFuzzy")]
        [Validation(Required=false)]
        public string CheckItemFuzzy { get; set; }

        /// <summary>
        /// <para>The risk level. Default value: null, which indicates that check items at all risk levels are queried.Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>high</b></description></item>
        /// <item><description><b>medium</b></description></item>
        /// <item><description><b>low</b></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>medium</para>
        /// </summary>
        [NameInMap("CheckLevel")]
        [Validation(Required=false)]
        public string CheckLevel { get; set; }

        /// <summary>
        /// <para>The type of the check item.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hc.check.type.attack_defense</para>
        /// </summary>
        [NameInMap("CheckType")]
        [Validation(Required=false)]
        public string CheckType { get; set; }

        /// <summary>
        /// <para>The risk status. Default value: null, which indicates that check items in all states are queried.Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>1</b>: failed</description></item>
        /// <item><description><b>3</b>: passed</description></item>
        /// <item><description><b>6</b>: Added to Whitelist</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("CheckWarningStatus")]
        [Validation(Required=false)]
        public int? CheckWarningStatus { get; set; }

        /// <summary>
        /// <para>The name of the field that is used to query containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>clusterId</para>
        /// </summary>
        [NameInMap("ContainerFieldName")]
        [Validation(Required=false)]
        public string ContainerFieldName { get; set; }

        /// <summary>
        /// <para>The value of the field that is used to query containers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c471f0f61b9c04f8380556e922cf1****</para>
        /// </summary>
        [NameInMap("ContainerFieldValue")]
        [Validation(Required=false)]
        public string ContainerFieldValue { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The ID of the asset group.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeAllGroups~~">DescribeAllGroups</a> operation to query the IDs of asset groups.</para>
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
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para>We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the baseline.</para>
        /// 
        /// <b>Example:</b>
        /// <para>weak_password</para>
        /// </summary>
        [NameInMap("RiskType")]
        [Validation(Required=false)]
        public string RiskType { get; set; }

        /// <summary>
        /// <para>The data source. Default value: <b>default</b>. Valid value:</para>
        /// <list type="bullet">
        /// <item><description><b>agentless</b>: The check items of baselines for agentless detection.</description></item>
        /// <item><description><b>default</b>: The check items of baselines for hosts.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>agentless</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public string Source { get; set; }

        /// <summary>
        /// <para>The UUIDs of the servers.</para>
        /// <remarks>
        /// <para> You can call the <a href="https://help.aliyun.com/document_detail/141932.html">DescribeCloudCenterInstances</a> operation to query the UUIDs of the servers.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("UuidList")]
        [Validation(Required=false)]
        public List<string> UuidList { get; set; }

    }

}
