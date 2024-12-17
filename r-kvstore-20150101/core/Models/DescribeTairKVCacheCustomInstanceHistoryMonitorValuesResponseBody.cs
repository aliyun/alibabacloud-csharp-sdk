// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class DescribeTairKVCacheCustomInstanceHistoryMonitorValuesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{ “timestamp”: 1490164200000, “Maximum”: 100, “userId”: “1234567898765432”, “Minimum”: 4.55, “instanceId”: “i-bp18abl200xk9599ck7c”, “Average”: 93.84 }</para>
        /// </summary>
        [NameInMap("Datapoints")]
        [Validation(Required=false)]
        public string Datapoints { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>212db86sca4384811e0b5e8707ec2****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>60</para>
        /// </summary>
        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>F3F44BE3-5419-4B61-9BAC-E66E295A****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
