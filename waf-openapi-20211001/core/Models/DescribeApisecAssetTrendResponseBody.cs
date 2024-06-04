// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAssetTrendResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecAssetTrendResponseBodyData> Data { get; set; }
        public class DescribeApisecAssetTrendResponseBodyData : TeaModel {
            [NameInMap("AssetActive")]
            [Validation(Required=false)]
            public long? AssetActive { get; set; }

            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public long? AssetCount { get; set; }

            [NameInMap("AssetOffline")]
            [Validation(Required=false)]
            public long? AssetOffline { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
