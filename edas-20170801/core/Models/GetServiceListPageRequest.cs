// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class GetServiceListPageRequest : TeaModel {
        /// <summary>
        /// The namespace.
        /// </summary>
        [NameInMap("namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// The source of the data. Valid values:
        /// 
        /// *   `agent`: Use this value if you use the service query feature of the latest version to pass the query result.
        /// *   `registry`: Use this value if you use the service query feature of the earlier version to pass the query result.
        /// </summary>
        [NameInMap("origin")]
        [Validation(Required=false)]
        public string Origin { get; set; }

        /// <summary>
        /// The number of the page to return. Pages start from Page 0.
        /// </summary>
        [NameInMap("page")]
        [Validation(Required=false)]
        public int? Page { get; set; }

        /// <summary>
        /// The ID of the region.
        /// </summary>
        [NameInMap("region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// The type of the service. Valid values:
        /// 
        /// *   `app`: searches by application.
        /// *   `service`: searches by service.
        /// *   `providerIp`: searches by IP address.
        /// </summary>
        [NameInMap("searchType")]
        [Validation(Required=false)]
        public string SearchType { get; set; }

        /// <summary>
        /// The keyword used for the search.
        /// 
        /// *   Set this parameter to the ID of the application if you set the searchType parameter to app.``
        /// *   Set this parameter to the name of the service if you set the serachType parameter to service.``
        /// *   Set this parameter to the IP address of the application if you set the searchType parameter to providerIp.
        /// </summary>
        [NameInMap("searchValue")]
        [Validation(Required=false)]
        public string SearchValue { get; set; }

        /// <summary>
        /// The type of the service. Valid values:
        /// 
        /// *   `dubbo`
        /// *   `springCloud`
        /// *   `hsf`
        /// *   `istio`
        /// </summary>
        [NameInMap("serviceType")]
        [Validation(Required=false)]
        public string ServiceType { get; set; }

        /// <summary>
        /// Specifies the provider side or the consumer side. Valid values:
        /// 
        /// *   provider
        /// *   consumer
        /// </summary>
        [NameInMap("side")]
        [Validation(Required=false)]
        public string Side { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public int? Size { get; set; }

    }

}
