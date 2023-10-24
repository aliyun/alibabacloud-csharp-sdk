// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribePropertyScaDetailRequest : TeaModel {
        /// <summary>
        /// The type of the asset fingerprint that you want to query. Default value: **sca**. Valid values:
        /// 
        /// *   **sca**: middleware
        /// *   **sca_database**: database
        /// *   **sca_web**: web service
        /// 
        /// >  If you do not specify this parameter, the default value **sca** is used, which indicates that middleware fingerprints are queried.
        /// </summary>
        [NameInMap("Biz")]
        [Validation(Required=false)]
        public string Biz { get; set; }

        /// <summary>
        /// The type of the middleware, database, or web service that you want to query. Valid values:
        /// 
        /// *   **system_service**: system service
        /// *   **software_library**: software library
        /// *   **docker_component**: container component
        /// *   **database**: database
        /// *   **web_container**: web container
        /// *   **jar**: JAR package
        /// *   **web_framework**: web framework
        /// </summary>
        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        /// <summary>
        /// The number of the page to return. Default value: **1**.
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

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
        /// The name of the middleware, database, or web service.
        /// 
        /// >  This parameter is deprecated. You can ignore it.
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public long? Name { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Default value: **10**.
        /// 
        /// >  We recommend that you do not leave this parameter empty.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The PID.
        /// </summary>
        [NameInMap("Pid")]
        [Validation(Required=false)]
        public string Pid { get; set; }

        /// <summary>
        /// The port that the process monitors.
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// The timestamp when the process ends. Unit: milliseconds.
        /// </summary>
        [NameInMap("ProcessStartedEnd")]
        [Validation(Required=false)]
        public long? ProcessStartedEnd { get; set; }

        /// <summary>
        /// The timestamp when the process starts. Unit: milliseconds.
        /// </summary>
        [NameInMap("ProcessStartedStart")]
        [Validation(Required=false)]
        public long? ProcessStartedStart { get; set; }

        /// <summary>
        /// The search condition, such as a server name or a server IP address.
        /// 
        /// >  Fuzzy match is supported.
        /// </summary>
        [NameInMap("Remark")]
        [Validation(Required=false)]
        public string Remark { get; set; }

        /// <summary>
        /// The name of the asset fingerprint that you want to query.
        /// </summary>
        [NameInMap("ScaName")]
        [Validation(Required=false)]
        public string ScaName { get; set; }

        /// <summary>
        /// The name of the process.
        /// </summary>
        [NameInMap("ScaNamePattern")]
        [Validation(Required=false)]
        public string ScaNamePattern { get; set; }

        /// <summary>
        /// The version of the middleware, database, or web service.
        /// </summary>
        [NameInMap("ScaVersion")]
        [Validation(Required=false)]
        public string ScaVersion { get; set; }

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
        /// >  You must specify both the **SearchItem** and **SearchInfo** parameters before you can query the asset fingerprints based on the specified name or type.
        /// </summary>
        [NameInMap("SearchInfo")]
        [Validation(Required=false)]
        public string SearchInfo { get; set; }

        /// <summary>
        /// The keyword of the subquery. You must specify this parameter based on the value of the **SearchItemSub** parameter.
        /// 
        /// *   If the **SearchItemSub** parameter is set to **port**, you must enter a port number.
        /// *   If the **SearchItemSub** parameter is set to **pid**, you must enter a process ID (PID).
        /// *   If the **SearchItemSub** parameter is set to **version**, you must enter the version of a database, middleware, or web service.
        /// *   If the **SearchItemSub** parameter is set to **user**, you must enter a username.
        /// 
        /// >  The subquery is used to search for data of a specified database, middleware, or web service.
        /// </summary>
        [NameInMap("SearchInfoSub")]
        [Validation(Required=false)]
        public string SearchInfoSub { get; set; }

        /// <summary>
        /// The type of the search condition. Valid values:
        /// 
        /// *   **name**: the name of a database, middleware, or web service
        /// *   **type**: the type of a database, middleware, or web service
        /// 
        /// >  You must specify both the **SearchItem** and **SearchInfo** parameters before you can query the asset fingerprints based on the specified name or type.
        /// </summary>
        [NameInMap("SearchItem")]
        [Validation(Required=false)]
        public string SearchItem { get; set; }

        /// <summary>
        /// The type of the subquery. Valid values:
        /// 
        /// *   **port**
        /// *   **pid**
        /// *   **version**
        /// *   **user**
        /// </summary>
        [NameInMap("SearchItemSub")]
        [Validation(Required=false)]
        public string SearchItemSub { get; set; }

        /// <summary>
        /// The user who runs the process.
        /// </summary>
        [NameInMap("User")]
        [Validation(Required=false)]
        public string User { get; set; }

        /// <summary>
        /// The UUID of the server on which the middleware, database, or web service is run.
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
