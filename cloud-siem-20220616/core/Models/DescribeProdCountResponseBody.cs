// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeProdCountResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeProdCountResponseBodyData Data { get; set; }
        public class DescribeProdCountResponseBodyData : TeaModel {
            /// <summary>
            /// The number of Alibaba Cloud services.
            /// </summary>
            [NameInMap("AliyunProdCount")]
            [Validation(Required=false)]
            public int? AliyunProdCount { get; set; }

            /// <summary>
            /// The number of Huawei Cloud services.
            /// </summary>
            [NameInMap("HcloudProdCount")]
            [Validation(Required=false)]
            public int? HcloudProdCount { get; set; }

            /// <summary>
            /// The number of Tencent Cloud services.
            /// </summary>
            [NameInMap("QcloudProdCount")]
            [Validation(Required=false)]
            public int? QcloudProdCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
