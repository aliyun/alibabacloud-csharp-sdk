// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListUserProdLogsResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListUserProdLogsResponseBodyData> Data { get; set; }
        public class ListUserProdLogsResponseBodyData : TeaModel {
            /// <summary>
            /// The display details of the Logstore.
            /// </summary>
            [NameInMap("DisplayLine")]
            [Validation(Required=false)]
            public string DisplayLine { get; set; }

            /// <summary>
            /// Indicates whether the details of the added log are returned. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Displayed")]
            [Validation(Required=false)]
            public bool? Displayed { get; set; }

            /// <summary>
            /// Indicates whether the log is added to the threat analysis feature. Valid values:
            /// 
            /// *   true
            /// *   false
            /// </summary>
            [NameInMap("Imported")]
            [Validation(Required=false)]
            public bool? Imported { get; set; }

            /// <summary>
            /// Indicates whether the log is added to the threat analysis feature. Valid values:
            /// 
            /// *   0: yes
            /// *   1: no
            /// </summary>
            [NameInMap("IsDeleted")]
            [Validation(Required=false)]
            public int? IsDeleted { get; set; }

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
            /// The details of the Logstore. The value is a JSON string.
            /// </summary>
            [NameInMap("SourceLogInfo")]
            [Validation(Required=false)]
            public string SourceLogInfo { get; set; }

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
