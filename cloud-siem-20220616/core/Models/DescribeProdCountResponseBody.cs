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
            [NameInMap("AliyunImportedCount")]
            [Validation(Required=false)]
            public int? AliyunImportedCount { get; set; }

            /// <summary>
            /// The number of Alibaba Cloud services.
            /// </summary>
            [NameInMap("AliyunProdCount")]
            [Validation(Required=false)]
            public int? AliyunProdCount { get; set; }

            [NameInMap("HcloudImportedCount")]
            [Validation(Required=false)]
            public int? HcloudImportedCount { get; set; }

            /// <summary>
            /// The number of Huawei Cloud services.
            /// </summary>
            [NameInMap("HcloudProdCount")]
            [Validation(Required=false)]
            public int? HcloudProdCount { get; set; }

            [NameInMap("IdcImportedCount")]
            [Validation(Required=false)]
            public int? IdcImportedCount { get; set; }

            [NameInMap("IdcProdCount")]
            [Validation(Required=false)]
            public int? IdcProdCount { get; set; }

            [NameInMap("QcloudImportedCount")]
            [Validation(Required=false)]
            public int? QcloudImportedCount { get; set; }

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
