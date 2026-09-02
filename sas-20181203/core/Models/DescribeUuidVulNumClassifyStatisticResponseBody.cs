// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeUuidVulNumClassifyStatisticResponseBody : TeaModel {
        /// <summary>
        /// <para>The vulnerability statistics returned by asset unique identifier. The key of the map is the host UUID or image ID specified in the request.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public Dictionary<string, DataValue> Data { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FDF7B8D9-8493-4B90-8D13-E0C1FFCE5F97</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
