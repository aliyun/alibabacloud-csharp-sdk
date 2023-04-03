// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alidns20150109.Models
{
    public class SwitchDnsGtmInstanceStrategyModeRequest : TeaModel {
        /// <summary>
        /// The ID of the GTM instance.
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The language of the values of specific response parameters. Default value: en. Valid values: en, zh, and ja.
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// The access policy type. Valid values:
        /// 
        /// *   GEO: geographical location-based
        /// *   LATENCY: latency-based
        /// </summary>
        [NameInMap("StrategyMode")]
        [Validation(Required=false)]
        public string StrategyMode { get; set; }

    }

}
