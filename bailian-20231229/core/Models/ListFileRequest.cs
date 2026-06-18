// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Bailian20231229.Models
{
    public class ListFileRequest : TeaModel {
        /// <summary>
        /// <para>&lt;props=&quot;china&quot;&gt;</para>
        /// <para>The category ID, which is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also obtain it on the <a href="https://bailian.console.aliyun.com/?tab=app#/data-center">Application Data</a> - Files tab by clicking the ID icon next to the category name.</para>
        /// <para>&lt;props=&quot;intl&quot;&gt;</para>
        /// <para>The category ID, which is the <c>CategoryId</c> returned by the <b>AddCategory</b> operation. You can also obtain it on the <a href="https://modelstudio.console.alibabacloud.com/?tab=app#/data-center">Application Data</a> - Files tab by clicking the ID icon next to the category name.</para>
        /// <para>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cate_cdd11b1b79a74e8bbd675c356a91ee35xxxxxxxx</para>
        /// </summary>
        [NameInMap("CategoryId")]
        [Validation(Required=false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// <para>The list of file IDs to query. A maximum of 20 files can be queried per request.</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public List<string> FileIds { get; set; }

        /// <summary>
        /// <para>The file name (without extension). Only exact match is supported. Fuzzy search is not supported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>product-overview</para>
        /// </summary>
        [NameInMap("FileName")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <para>The number of entries per page for paging. Valid values: 1 to 200.</para>
        /// <para>Default value:
        /// If the value is not set or is less than 1, the default value is 20. If the value is greater than 200, the default value is 200.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token. Set this to the NextToken value returned by the previous API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAdH70eOCSCKtacdomNzak4U=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
