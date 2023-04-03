// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class DescribeDnsGtmAccessStrategyRequest : TeaModel {
        /// <summary>
        /// The language to return some response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The ID of the access policy.
        /// </summary>
        [NameInMap("StrategyId")]
        [Validation(Required=false)]
        public string StrategyId { get; set; }

    }

}
