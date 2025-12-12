// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailRequest : TeaModel {
        /// <summary>
        /// <para>The type of the asset fingerprint that you want to query. Default value: <b>sca</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>lkm</b>: kernel module</description></item>
        /// <item><description><b>autorun</b>: startup item</description></item>
        /// <item><description><b>web_server</b>: website</description></item>
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
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The name of the aggregation item for the asset fingerprint that you want to query.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~GetAssetsPropertyItem~~">GetAssetsPropertyItem</a> operation to query the names of aggregation items.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>virtio</para>
        /// </summary>
        [NameInMap("ItemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
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

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

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
        /// <para>The name or IP address of the server.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The conditions that are used to query the details about the asset fingerprint.</para>
        /// </summary>
        [NameInMap("SearchCriteriaList")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailRequestSearchCriteriaList> SearchCriteriaList { get; set; }
        public class GetAssetsPropertyDetailRequestSearchCriteriaList : TeaModel {
            /// <summary>
            /// <para>The name of the condition. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>remarkItemName</b>: the aggregation item of the asset fingerprints. Fuzzy match is supported.</description></item>
            /// </list>
            /// <remarks>
            /// <list type="bullet">
            /// <item><description>If <b>Biz</b> is set to <b>web_server</b>, <b>remarkItemName</b> specifies a domain name. </description></item>
            /// <item><description>If <b>Biz</b> is set to <b>lkm</b>, <b>remarkItemName</b> specifies a module name.</description></item>
            /// <item><description>If <b>Biz</b> is set to <b>autorun</b>, <b>remarkItemName</b> specifies the path to a startup item.</description></item>
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
            /// <para>The value of the condition.</para>
            /// 
            /// <b>Example:</b>
            /// <para>virtio</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("UseNextToken")]
        [Validation(Required=false)]
        public bool? UseNextToken { get; set; }

        /// <summary>
        /// <para>The UUID of the server.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeCloudCenterInstances~~">DescribeCloudCenterInstances</a> operation to query the UUIDs of servers.</para>
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
