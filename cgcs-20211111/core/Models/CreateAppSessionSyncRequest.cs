// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CGCS20211111.Models
{
    public class CreateAppSessionSyncRequest : TeaModel {
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

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("CustomSessionId")]
        [Validation(Required=false)]
        public string CustomSessionId { get; set; }

        [NameInMap("CustomUserId")]
        [Validation(Required=false)]
        public string CustomUserId { get; set; }

        [NameInMap("DistrictId")]
        [Validation(Required=false)]
        public string DistrictId { get; set; }

        [NameInMap("MatchRules")]
        [Validation(Required=false)]
        public List<CreateAppSessionSyncRequestMatchRules> MatchRules { get; set; }
        public class CreateAppSessionSyncRequestMatchRules : TeaModel {
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
        public List<CreateAppSessionSyncRequestStartParameters> StartParameters { get; set; }
        public class CreateAppSessionSyncRequestStartParameters : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("SystemInfo")]
        [Validation(Required=false)]
        public List<CreateAppSessionSyncRequestSystemInfo> SystemInfo { get; set; }
        public class CreateAppSessionSyncRequestSystemInfo : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        [NameInMap("Tags")]
        [Validation(Required=false)]
        public List<CreateAppSessionSyncRequestTags> Tags { get; set; }
        public class CreateAppSessionSyncRequestTags : TeaModel {
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

    }

}
