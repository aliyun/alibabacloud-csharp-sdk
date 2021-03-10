// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceBySQLResponse : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=true)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=true)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=true)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=true)]
        public string ErrorMessage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=true)]
        public long? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=true)]
        public List<QueryDeviceBySQLResponseData> Data { get; set; }
        public class QueryDeviceBySQLResponseData : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=true)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=true)]
            public string DeviceName { get; set; }

            [NameInMap("Nickname")]
            [Validation(Required=true)]
            public string Nickname { get; set; }

            [NameInMap("Status")]
            [Validation(Required=true)]
            public string Status { get; set; }

            [NameInMap("ActiveTime")]
            [Validation(Required=true)]
            public string ActiveTime { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=true)]
            public string IotId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=true)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=true)]
            public string GmtModified { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=true)]
            public List<QueryDeviceBySQLResponseDataGroups> Groups { get; set; }
            public class QueryDeviceBySQLResponseDataGroups : TeaModel {
                [NameInMap("GroupId")]
                [Validation(Required=true)]
                public string GroupId { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=true)]
            public List<QueryDeviceBySQLResponseDataTags> Tags { get; set; }
            public class QueryDeviceBySQLResponseDataTags : TeaModel {
                [NameInMap("TagName")]
                [Validation(Required=true)]
                public string TagName { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=true)]
                public string TagValue { get; set; }

            }

            [NameInMap("OTAModules")]
            [Validation(Required=true)]
            public List<QueryDeviceBySQLResponseDataOTAModules> OTAModules { get; set; }
            public class QueryDeviceBySQLResponseDataOTAModules : TeaModel {
                [NameInMap("ModuleName")]
                [Validation(Required=true)]
                public string ModuleName { get; set; }

                [NameInMap("FirmwareVersion")]
                [Validation(Required=true)]
                public string FirmwareVersion { get; set; }

            }

        }

    }

}
