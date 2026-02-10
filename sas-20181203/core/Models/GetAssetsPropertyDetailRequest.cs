// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailRequest : TeaModel {
        /// <summary>
        /// <para>The type of asset fingerprint to be queried, with a default value of <b>sca</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>lkm</b>: Kernel module</description></item>
        /// <item><description><b>autorun</b>: Startup item</description></item>
        /// <item><description><b>web_server</b>: Web site</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lkm</para>
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// <para>Set the page number from which to start displaying the query results. The default value is <b>1</b>, indicating that the display starts from the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The aggregated item name of the asset fingerprint to be queried.</para>
        /// <remarks>
        /// <para>Call the <a href="~~GetAssetsPropertyItem~~">GetAssetsPropertyItem</a> API to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>virtio</para>
        /// </summary>
        [NameInMap("ItemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// <para>The language type for the request and response. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>Used to mark the current read position. Leave it empty to start from the beginning.</para>
        /// <remarks>
        /// <para>Do not fill in for the first call; the response will include the NextToken for the second call. Each subsequent call\&quot;s response will contain the NextToken for the next call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>71640f04f6e7b49764c8d08ae170xxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>Specify the maximum number of data entries per page in a paginated query. The default number of data entries per page is 20. If the PageSize parameter is empty, 20 data entries will be returned by default.</para>
        /// <remarks>
        /// <para>It is recommended that the PageSize value is not empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Server name or IP.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>A set of conditions for querying asset fingerprint details.</para>
        /// </summary>
        [NameInMap("SearchCriteriaList")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailRequestSearchCriteriaList> SearchCriteriaList { get; set; }
        public class GetAssetsPropertyDetailRequestSearchCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the condition to be queried. Values are as follows:</para>
            /// <list type="bullet">
            /// <item><description><b>remarkItemName</b>: The aggregated item name of the asset fingerprint, supporting fuzzy matching</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>When <b>Biz</b> is <b>web_server</b>, <b>remarkItemName</b> represents the domain name as the search condition.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>When <b>Biz</b> is <b>lkm</b>, <b>remarkItemName</b> represents the module name as the search condition.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>When <b>Biz</b> is <b>autorun</b>, <b>remarkItemName</b> represents the startup item path as the search condition.</description></item>
            /// </list>
            /// </description></item>
            /// </list>
            /// </remarks>
            /// 
            /// <b>Example:</b>
            /// <para>remarkItemName</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The value of the condition to be queried.</para>
            /// 
            /// <b>Example:</b>
            /// <para>virtio</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Whether to use the NextToken method to fetch the list of vulnerabilities. If this parameter is used, TotalCount will not be returned. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Use the NextToken method.</description></item>
        /// <item><description><b>false</b>: Do not use the NextToken method.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The UUID of the asset to be queried.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> API to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>38f72ea4-4c9f-4df1-bc6c-0f267614****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
