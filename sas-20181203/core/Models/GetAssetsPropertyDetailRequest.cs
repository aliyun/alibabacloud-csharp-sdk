// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailRequest : TeaModel {
        /// <summary>
        /// <para>The type of Asset Fingerprints to query. Default value: <b>sca</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lkm</b>: kernel module</description></item>
        /// <item><description><b>autorun</b>: startup item</description></item>
        /// <item><description><b>web_server</b>: web site.</description></item>
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
        /// <para>The page number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The aggregation item name of the Asset Fingerprints to query.</para>
        /// <remarks>
        /// <para>Call the <a href="~~GetAssetsPropertyItem~~">GetAssetsPropertyItem</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>virtio</para>
        /// </summary>
        [NameInMap("ItemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// <para>The language type of the request and response messages. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The token that marks the starting position for the query. Leave this parameter empty to query from the beginning.</para>
        /// <remarks>
        /// <para>Do not specify this parameter for the first call. The response includes the NextToken value for the next call. Each subsequent response contains the NextToken value for the following call.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>71640f04f6e7b49764c8d08ae170xxxx</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page for a paging query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page by default.</para>
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
        /// <para>The server name or IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The collection of search criteria for querying Asset Fingerprints details.</para>
        /// </summary>
        [NameInMap("SearchCriteriaList")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailRequestSearchCriteriaList> SearchCriteriaList { get; set; }
        public class GetAssetsPropertyDetailRequestSearchCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the search criterion. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>remarkItemName</b>: the aggregation item name of Asset Fingerprints. Fuzzy match is supported.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description><list type="bullet">
            /// <item><description>When <b>Biz</b> is set to <b>web_server</b>, <b>remarkItemName</b> indicates the domain name.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>When <b>Biz</b> is set to <b>lkm</b>, <b>remarkItemName</b> indicates the module name.</description></item>
            /// </list>
            /// </description></item>
            /// <item><description><list type="bullet">
            /// <item><description>When <b>Biz</b> is set to <b>autorun</b>, <b>remarkItemName</b> indicates the startup item path.</description></item>
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
            /// <para>The value of the search criterion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>virtio</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Specifies whether to use the NextToken method to retrieve the vulnerability list. If this parameter is used, TotalCount is no longer returned. Valid values:</para>
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
        /// <para>The UUID of the asset to query.</para>
        /// <remarks>
        /// <para>Call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to obtain this parameter.</para>
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
