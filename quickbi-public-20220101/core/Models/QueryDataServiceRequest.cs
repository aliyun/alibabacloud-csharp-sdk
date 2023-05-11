// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryDataServiceRequest : TeaModel {
        /// <summary>
        /// Call an API that is created in DataService Studio.
        /// </summary>
        [NameInMap("ApiId")]
        [Validation(Required=false)]
        public string ApiId { get; set; }

        /// <summary>
        /// # Prerequisites
        /// 
        /// You can use the Quick BI data service to create an API for the data service. For more information, see [Data service](~~144980~~).
        /// 
        /// # Limits
        /// 
        /// *   The Data Service feature is available only to Professional customers.
        /// *   The timeout period for API calls is 60s. The QPS of a single API is 10 times per second.
        /// *   If row-level permissions are enabled for datasets that are referenced by a Data Service API, the API may be blocked by row-level permission policies.
        /// </summary>
        [NameInMap("Conditions")]
        [Validation(Required=false)]
        public string Conditions { get; set; }

        /// <summary>
        /// The query conditions of the data service. The query conditions are specified in the form of keys and values. A string of the map type. Key is the name of the request parameters parameter, and Value is the value of the request parameters parameter. Key and Value must appear in pairs.
        /// 
        /// **Note:**
        /// 
        /// *   If a value contains multiple values, the value is a List in the JSON format. Example: `area=["East China","North China","South China"]`
        /// 
        /// *   For dates, different input parameter formats are provided based on different types:
        /// 
        ///     *   Year: 2019
        ///     *   Season: 2019Q1
        ///     *   Month: 201901 (carry 0)
        ///     *   Week: 2019-52
        ///     *   Day: 20190101
        ///     *   Hours: 14:00:00 (minutes and seconds are 00)
        ///     *   Minutes: 14:12:00 (seconds are 00)
        ///     *   Seconds: 14:34:34
        /// </summary>
        [NameInMap("ReturnFields")]
        [Validation(Required=false)]
        public string ReturnFields { get; set; }

    }

}
