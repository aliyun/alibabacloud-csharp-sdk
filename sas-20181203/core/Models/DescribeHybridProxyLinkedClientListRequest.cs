// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHybridProxyLinkedClientListRequest : TeaModel {
        /// <summary>
        /// <para>The name of the proxy cluster. You can view the name in the Security Center console.</para>
        /// <remarks>
        /// <para><b>ProxyUuid</b> and <b>ClusterName</b> cannot be left empty at the same time. If neither is provided, the API returns an HTTP 400 error with the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>office-proxy</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The page number of the current page returned in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paging query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The UUID of the proxy node.</para>
        /// <remarks>
        /// <para>You can call the <a href="~~DescribeHybridProxyList~~">DescribeHybridProxyList</a> operation to obtain this parameter from the ProxyList[].ProxyUuid field in the response.
        /// <b>ProxyUuid</b> and <b>ClusterName</b> cannot be left empty at the same time. If neither is provided, the API returns an HTTP 400 error with the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>inet-proxy-3bb11fad-37d6-4aee-9c37-b0ad1612XXXX</para>
        /// </summary>
        [NameInMap("ProxyUuid")]
        [Validation(Required=false)]
        public string ProxyUuid { get; set; }

        /// <summary>
        /// <para>The remarks.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The unique key of the Security Center client. You can obtain the UUID of the Security Center client installed on a server by querying the asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80d2f7d6-31a9-4d7f-8ff4-7ecc42f89ca****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
