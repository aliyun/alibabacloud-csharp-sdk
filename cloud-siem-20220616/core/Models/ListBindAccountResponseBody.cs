// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListBindAccountResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListBindAccountResponseBodyData> Data { get; set; }
        public class ListBindAccountResponseBodyData : TeaModel {
            /// <summary>
            /// The AccessKey ID of the cloud account.
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// The ID of the cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The username of the cloud account.
            /// </summary>
            [NameInMap("AccountName")]
            [Validation(Required=false)]
            public string AccountName { get; set; }

            /// <summary>
            /// The ID that is generated when the cloud account is added.
            /// </summary>
            [NameInMap("BindId")]
            [Validation(Required=false)]
            public long? BindId { get; set; }

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
            /// The ID of the account that is used to add the cloud account.
            /// </summary>
            [NameInMap("CreateUser")]
            [Validation(Required=false)]
            public string CreateUser { get; set; }

            /// <summary>
            /// The number of data sources that are added to the threat analysis feature within the cloud account.
            /// </summary>
            [NameInMap("DataSourceCount")]
            [Validation(Required=false)]
            public long? DataSourceCount { get; set; }

            /// <summary>
            /// The modification time.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
