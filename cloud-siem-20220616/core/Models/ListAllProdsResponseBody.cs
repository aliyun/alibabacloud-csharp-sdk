// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAllProdsResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListAllProdsResponseBodyData Data { get; set; }
        public class ListAllProdsResponseBodyData : TeaModel {
            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("CurrentPage")]
            [Validation(Required=false)]
            public int? CurrentPage { get; set; }

            /// <summary>
            /// The number of entries per page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The cloud services.
            /// </summary>
            [NameInMap("ProdList")]
            [Validation(Required=false)]
            public List<ListAllProdsResponseBodyDataProdList> ProdList { get; set; }
            public class ListAllProdsResponseBodyDataProdList : TeaModel {
                /// <summary>
                /// The code of the cloud service provider. Valid values:
                /// 
                /// *   qcloud: Tencent Cloud
                /// *   aliyun: Alibaba Cloud
                /// *   hcloud: Huawei Cloud
                /// </summary>
                [NameInMap("CloudCode")]
                [Validation(Required=false)]
                public string CloudCode { get; set; }

                /// <summary>
                /// The number of logs within the cloud service that are added to the threat analysis feature.
                /// </summary>
                [NameInMap("ImportedLogCount")]
                [Validation(Required=false)]
                public int? ImportedLogCount { get; set; }

                /// <summary>
                /// The time when the logs within the cloud service were last added to the threat analysis feature.
                /// </summary>
                [NameInMap("ModifyTime")]
                [Validation(Required=false)]
                public string ModifyTime { get; set; }

                /// <summary>
                /// The code of the cloud service.
                /// </summary>
                [NameInMap("ProdCode")]
                [Validation(Required=false)]
                public string ProdCode { get; set; }

                /// <summary>
                /// The total number of logs within the cloud service.
                /// </summary>
                [NameInMap("TotalLogCount")]
                [Validation(Required=false)]
                public int? TotalLogCount { get; set; }

            }

            /// <summary>
            /// The total number of logs.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
