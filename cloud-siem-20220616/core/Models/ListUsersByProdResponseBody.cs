// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListUsersByProdResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUsersByProdResponseBodyData> Data { get; set; }
        public class ListUsersByProdResponseBodyData : TeaModel {
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
            /// Indicates whether the log is added to the threat analysis feature.
            /// </summary>
            [NameInMap("Imported")]
            [Validation(Required=false)]
            public bool? Imported { get; set; }

            /// <summary>
            /// The display log code. The value is based on your console settings.
            /// </summary>
            [NameInMap("LogMdsCode")]
            [Validation(Required=false)]
            public string LogMdsCode { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to purchase the threat analysis feature.
            /// </summary>
            [NameInMap("MainUserId")]
            [Validation(Required=false)]
            public long? MainUserId { get; set; }

            /// <summary>
            /// The log code.
            /// </summary>
            [NameInMap("SourceLogCode")]
            [Validation(Required=false)]
            public string SourceLogCode { get; set; }

            /// <summary>
            /// The log name.
            /// </summary>
            [NameInMap("SourceLogName")]
            [Validation(Required=false)]
            public string SourceLogName { get; set; }

            /// <summary>
            /// The code of the cloud service.
            /// </summary>
            [NameInMap("SourceProdCode")]
            [Validation(Required=false)]
            public string SourceProdCode { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that can be used to perform operations supported by the threat analysis feature.
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

            /// <summary>
            /// The username of the Alibaba Cloud account that can be used to perform operations supported by the threat analysis feature.
            /// </summary>
            [NameInMap("SubUserName")]
            [Validation(Required=false)]
            public string SubUserName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
