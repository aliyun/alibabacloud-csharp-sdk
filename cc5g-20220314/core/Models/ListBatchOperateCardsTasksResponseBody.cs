// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CC5G20220314.Models
{
    public class ListBatchOperateCardsTasksResponseBody : TeaModel {
        [NameInMap("BatchOperateCardsTasks")]
        [Validation(Required=false)]
        public List<ListBatchOperateCardsTasksResponseBodyBatchOperateCardsTasks> BatchOperateCardsTasks { get; set; }
        public class ListBatchOperateCardsTasksResponseBodyBatchOperateCardsTasks : TeaModel {
            /// <summary>
            /// 代表资源一级ID的资源属性字段
            /// </summary>
            [NameInMap("BatchOperateCardsTaskId")]
            [Validation(Required=false)]
            public string BatchOperateCardsTaskId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("EffectType")]
            [Validation(Required=false)]
            public string EffectType { get; set; }

            [NameInMap("IccidsOssFilePath")]
            [Validation(Required=false)]
            public string IccidsOssFilePath { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("OperateResultOssFilePath")]
            [Validation(Required=false)]
            public string OperateResultOssFilePath { get; set; }

            /// <summary>
            /// 代表创建时间的资源属性字段
            /// </summary>
            [NameInMap("OperateType")]
            [Validation(Required=false)]
            public string OperateType { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("Threshold")]
            [Validation(Required=false)]
            public string Threshold { get; set; }

            [NameInMap("WirelessCloudConnectors")]
            [Validation(Required=false)]
            public List<ListBatchOperateCardsTasksResponseBodyBatchOperateCardsTasksWirelessCloudConnectors> WirelessCloudConnectors { get; set; }
            public class ListBatchOperateCardsTasksResponseBodyBatchOperateCardsTasksWirelessCloudConnectors : TeaModel {
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("WirelessCloudConnectorId")]
                [Validation(Required=false)]
                public string WirelessCloudConnectorId { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public string TotalCount { get; set; }

    }

}
