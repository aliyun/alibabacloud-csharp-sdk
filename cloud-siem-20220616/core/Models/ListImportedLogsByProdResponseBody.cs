// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListImportedLogsByProdResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListImportedLogsByProdResponseBodyData> Data { get; set; }
        public class ListImportedLogsByProdResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the log is automatically added to the threat analysis feature within newly added accounts. Valid values:
            /// 
            /// *   1: yes.
            /// *   0: no.
            /// </summary>
            [NameInMap("AutoImported")]
            [Validation(Required=false)]
            public int? AutoImported { get; set; }

            /// <summary>
            /// The code of the cloud service provider. Valid values:
            /// 
            /// *   qcloud: Tencent Cloud.
            /// *   aliyun: Alibaba Cloud.
            /// *   hcloud: Huawei Cloud.
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// Indicates whether the log is added to the threat analysis feature. Valid values:
            /// 
            /// *   1: yes.
            /// *   0: no.
            /// </summary>
            [NameInMap("Imported")]
            [Validation(Required=false)]
            public int? Imported { get; set; }

            /// <summary>
            /// The number of users who have added the log.
            /// </summary>
            [NameInMap("ImportedUserCount")]
            [Validation(Required=false)]
            public int? ImportedUserCount { get; set; }

            /// <summary>
            /// The code of the log.
            /// </summary>
            [NameInMap("LogCode")]
            [Validation(Required=false)]
            public string LogCode { get; set; }

            /// <summary>
            /// The display code of the log.
            /// </summary>
            [NameInMap("LogMdsCode")]
            [Validation(Required=false)]
            public string LogMdsCode { get; set; }

            /// <summary>
            /// The type of log. Valid values:
            ///  - 1: the log produced by other product
            ///  - 2: the predefined log
            ///  - 3: the custom log
            /// </summary>
            [NameInMap("LogType")]
            [Validation(Required=false)]
            public int? LogType { get; set; }

            /// <summary>
            /// The time when the log was last added.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The code of the cloud service to which the log belongs.
            /// </summary>
            [NameInMap("ProdCode")]
            [Validation(Required=false)]
            public string ProdCode { get; set; }

            /// <summary>
            /// The total number of users who have the log.
            /// </summary>
            [NameInMap("TotalUserCount")]
            [Validation(Required=false)]
            public int? TotalUserCount { get; set; }

            /// <summary>
            /// The number of users who have not added the log.
            /// </summary>
            [NameInMap("UnImportedUserCount")]
            [Validation(Required=false)]
            public int? UnImportedUserCount { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
