// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyDetailRequest : TeaModel {
        /// <summary>
        /// The type of the asset fingerprint that you want to query. Default value: **sca**. Valid values:
        /// 
        /// *   **lkm**: kernel module
        /// *   **autorun**: startup item
        /// *   **web_server**: website
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// The name of the aggregation item for the asset fingerprint that you want to query.
        /// 
        /// > You can call the [GetAssetsPropertyItem](~~GetAssetsPropertyItem~~) operation to query the names of aggregation items.
        /// </summary>
        [NameInMap("ItemName")]
        [Validation(Required=false)]
        public string ItemName { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Valid values:
        /// 
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The name or IP address of the server.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The conditions that are used to query the details about the asset fingerprint.
        /// </summary>
        [NameInMap("SearchCriteriaList")]
        [Validation(Required=false)]
        public List<GetAssetsPropertyDetailRequestSearchCriteriaList> SearchCriteriaList { get; set; }
        public class GetAssetsPropertyDetailRequestSearchCriteriaList : TeaModel {
            /// <summary>
            /// The name of the condition. Valid values:
            /// 
            /// *   **remarkItemName**: the aggregation item of the asset fingerprints. Fuzzy match is supported.
            /// 
            /// > *   If **Biz** is set to **web_server**, **remarkItemName** specifies a domain name. 
            /// > *   If **Biz** is set to **lkm**, **remarkItemName** specifies a module name.
            /// > *   If **Biz** is set to **autorun**, **remarkItemName** specifies the path to a startup item.
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The value of the condition.
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The UUID of the server.
        /// 
        /// > You can call the [DescribeCloudCenterInstances](~~DescribeCloudCenterInstances~~) operation to query the UUIDs of servers.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
