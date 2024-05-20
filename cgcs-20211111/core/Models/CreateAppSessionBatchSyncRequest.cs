// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionBatchSyncRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public List<CreateAppSessionBatchSyncRequestAppInfos> AppInfos { get; set; }
        public class CreateAppSessionBatchSyncRequestAppInfos : TeaModel {
            [NameInMap("AdapterFileId")]
            [Validation(Required=false)]
            public string AdapterFileId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("ClientIp")]
            [Validation(Required=false)]
            public string ClientIp { get; set; }

            [NameInMap("CustomUserId")]
            [Validation(Required=false)]
            public string CustomUserId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("CustomerSessionId")]
            [Validation(Required=false)]
            public string CustomerSessionId { get; set; }

            [NameInMap("DistrictId")]
            [Validation(Required=false)]
            public string DistrictId { get; set; }

            [NameInMap("MatchRules")]
            [Validation(Required=false)]
            public List<CreateAppSessionBatchSyncRequestAppInfosMatchRules> MatchRules { get; set; }
            public class CreateAppSessionBatchSyncRequestAppInfosMatchRules : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

                [NameInMap("Values")]
                [Validation(Required=false)]
                public List<string> Values { get; set; }

            }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("StartParameters")]
            [Validation(Required=false)]
            public List<CreateAppSessionBatchSyncRequestAppInfosStartParameters> StartParameters { get; set; }
            public class CreateAppSessionBatchSyncRequestAppInfosStartParameters : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("SystemInfo")]
            [Validation(Required=false)]
            public List<CreateAppSessionBatchSyncRequestAppInfosSystemInfo> SystemInfo { get; set; }
            public class CreateAppSessionBatchSyncRequestAppInfosSystemInfo : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<CreateAppSessionBatchSyncRequestAppInfosTags> Tags { get; set; }
            public class CreateAppSessionBatchSyncRequestAppInfosTags : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("BatchId")]
        [Validation(Required=false)]
        public string BatchId { get; set; }

    }

}
