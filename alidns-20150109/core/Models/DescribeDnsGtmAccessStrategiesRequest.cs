// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategiesRequest : TeaModel {
        /// <summary>
        /// The ID of the instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language to return some response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The number of entries to return on each page.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The type of the access policy. Valid values:
        /// 
        /// *   GEO: geographical location-based
        /// *   LATENCY: latency-based
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

    }

}
