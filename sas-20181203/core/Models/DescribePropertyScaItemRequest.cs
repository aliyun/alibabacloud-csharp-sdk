// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaItemRequest : TeaModel {
        /// <summary>
        /// The type of the asset fingerprint that you want to query. Default value: **sca**. Valid values:
        /// 
        /// *   **sca**: middleware
        /// *   **sca_database**: database
        /// *   **sca_web**: web service
        /// 
        /// > If you do not specify this parameter, the default value **sca** is used, which indicates that middleware fingerprints are queried.
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
        /// *   **zh**: Chinese
        /// *   **en**: English
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// 
        /// > We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The search keyword. You must specify this parameter based on the value of the **SearchItem** parameter.
        /// 
        /// *   If the **SearchItem** parameter is set to **name**, you must enter the name of an asset fingerprint.
        /// 
        /// *   If the **SearchItem** parameter is set to **type**, you must enter the type of an asset fingerprint. Valid values:
        /// 
        ///     *   **system_service**: system service
        ///     *   **software_library**: software library
        ///     *   **docker_component**: container component
        ///     *   **database**: database
        ///     *   **web_container**: web container
        ///     *   **jar**: JAR package
        ///     *   **web_framework**: web framework
        /// 
        /// > You must specify both the **SearchItem** and **SearchInfo** parameters before you can query the asset fingerprints based on the specified name or type.
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// The type of the search condition. Valid values:
        /// 
        /// *   **name**: the name of a database, middleware, or web service
        /// *   **type**: the type of a database, middleware, or web service
        /// 
        /// > You must specify both the **SearchItem** and **SearchInfo** parameters before you can query the asset fingerprints based on the specified name or type.
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

    }

}
