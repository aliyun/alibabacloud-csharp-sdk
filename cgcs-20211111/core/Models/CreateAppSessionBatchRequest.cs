// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionBatchRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("AppInfos")]
        [Validation(Required=false)]
        public List<CreateAppSessionBatchRequestAppInfos> AppInfos { get; set; }
        public class CreateAppSessionBatchRequestAppInfos : TeaModel {
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

            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            [NameInMap("DistrictId")]
            [Validation(Required=false)]
            public string DistrictId { get; set; }

            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

            [NameInMap("ResultStore")]
            [Validation(Required=false)]
            public CreateAppSessionBatchRequestAppInfosResultStore ResultStore { get; set; }
            public class CreateAppSessionBatchRequestAppInfosResultStore : TeaModel {
                [NameInMap("Need")]
                [Validation(Required=false)]
                public bool? Need { get; set; }

                [NameInMap("StoreInfo")]
                [Validation(Required=false)]
                public List<CreateAppSessionBatchRequestAppInfosResultStoreStoreInfo> StoreInfo { get; set; }
                public class CreateAppSessionBatchRequestAppInfosResultStoreStoreInfo : TeaModel {
                    [NameInMap("Key")]
                    [Validation(Required=false)]
                    public string Key { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("StartParameters")]
            [Validation(Required=false)]
            public List<CreateAppSessionBatchRequestAppInfosStartParameters> StartParameters { get; set; }
            public class CreateAppSessionBatchRequestAppInfosStartParameters : TeaModel {
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("SystemInfo")]
            [Validation(Required=false)]
            public List<CreateAppSessionBatchRequestAppInfosSystemInfo> SystemInfo { get; set; }
            public class CreateAppSessionBatchRequestAppInfosSystemInfo : TeaModel {
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
        [NameInMap("CustomTaskId")]
        [Validation(Required=false)]
        public string CustomTaskId { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("Timeout")]
        [Validation(Required=false)]
        public int? Timeout { get; set; }

    }

}
