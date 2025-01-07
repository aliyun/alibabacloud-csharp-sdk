// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeHybridProxyLinkedClientListRequest : TeaModel {
        /// <summary>
        /// <para>The name of the proxy cluster. You can query the name of the proxy cluster in the Security Center console.</para>
        /// 
        /// <b>Example:</b>
        /// <para>office-proxy</para>
        /// </summary>
        [NameInMap("ClusterName")]
        [Validation(Required=false)]
        public string ClusterName { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The UUID of the proxy node. You can call the DescribeHybridProxyList operation to query the UUID of the proxy node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>inet-proxy-3bb11fad-37d6-4aee-9c37-b0ad1612XXXX</para>
        /// </summary>
        [NameInMap("ProxyUuid")]
        [Validation(Required=false)]
        public string ProxyUuid { get; set; }

        /// <summary>
        /// <para>The description of the proxy cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// <para>The UUID of the server on which the Security Center agent is installed. You can query the UUID by querying asset information.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80d2f7d6-31a9-4d7f-8ff4-7ecc42f89ca****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
