// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListAccountAccessIdResponseBody : TeaModel {
        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListAccountAccessIdResponseBodyData> Data { get; set; }
        public class ListAccountAccessIdResponseBodyData : TeaModel {
            /// <summary>
            /// The AccessKey ID of the cloud account that is added to the threat analysis feature.
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// The MD5 hash value of the AccessKey ID.
            /// </summary>
            [NameInMap("AccessIdMd5")]
            [Validation(Required=false)]
            public string AccessIdMd5 { get; set; }

            /// <summary>
            /// The ID of the cloud account.
            /// </summary>
            [NameInMap("AccountId")]
            [Validation(Required=false)]
            public string AccountId { get; set; }

            /// <summary>
            /// The information about the cloud account to which the AccessKey ID belongs. The value is in the following format: Alibaba Cloud account ID|Alibaba Cloud account username|AccessKey ID.
            /// </summary>
            [NameInMap("AccountStr")]
            [Validation(Required=false)]
            public string AccountStr { get; set; }

            /// <summary>
            /// Indicates whether the cloud account to which the AccessKey ID belongs is added to the threat analysis feature. Valid values:
            /// 
            /// *   0: no
            /// *   1: yes
            /// </summary>
            [NameInMap("Bound")]
            [Validation(Required=false)]
            public int? Bound { get; set; }

            /// <summary>
            /// The code of the cloud service provider.
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// The ID of the Alibaba Cloud account that is used to add the third-party cloud account.
            /// </summary>
            [NameInMap("SubUserId")]
            [Validation(Required=false)]
            public long? SubUserId { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
