// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetAssetsPropertyItemRequest : TeaModel {
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
        /// Specifies whether to forcefully refresh the data that you want to query. Valid values:
        /// 
        /// *   **true**: yes
        /// *   **false**: no
        /// </summary>
        [NameInMap("ForceFlush")]
        [Validation(Required=false)]
        public bool? ForceFlush { get; set; }

        /// <summary>
        /// The language of the content within the request and response. Default value: **zh**. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The value of the search condition. You must specify this parameter based on the value of the **SearchItem** parameter.
        /// 
        /// *   If you set **SearchItem** to **domain**, you must enter the domain name.
        /// *   If you set **SearchItem** to **module_name**, you must enter the module name.
        /// *   If you set **SearchItem** to **path**, you must enter the path to the self-starting item.
        /// 
        /// >  You must specify both the **SearchItem** and **SearchInfo** parameters before you can query the information about asset fingerprints by asset fingerprint name.
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// The type of the search condition. You must specify this parameter based on the value of the **Biz** parameter. Valid values:
        /// 
        /// *   If you set **Biz** to **web_server**, set **SearchItem** to the following value:
        /// 
        ///     *   **domain**: the domain name
        /// 
        /// *   If you set **Biz** to **lkm**, set **SearchItem** to the following value:
        /// 
        ///     *   **module_name**: the name of the module
        /// 
        /// *   If you set **Biz** to **autorun**, set **SearchItem** to the following value:
        /// 
        ///     *   **path**: the path to the self-starting item
        /// 
        /// >  You must specify both the **SearchItem** and **SearchInfo** parameters before you can query the information about asset fingerprints by asset fingerprint name.
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

    }

}
