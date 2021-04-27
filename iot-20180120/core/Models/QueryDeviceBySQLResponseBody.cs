// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QueryDeviceBySQLResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<QueryDeviceBySQLResponseBodyData> Data { get; set; }
        public class QueryDeviceBySQLResponseBodyData : TeaModel {
            [NameInMap("ProductKey")]
            [Validation(Required=false)]
            public string ProductKey { get; set; }

            [NameInMap("DeviceName")]
            [Validation(Required=false)]
            public string DeviceName { get; set; }

            [NameInMap("Nickname")]
            [Validation(Required=false)]
            public string Nickname { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("ActiveTime")]
            [Validation(Required=false)]
            public string ActiveTime { get; set; }

            [NameInMap("IotId")]
            [Validation(Required=false)]
            public string IotId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Groups")]
            [Validation(Required=false)]
            public List<QueryDeviceBySQLResponseBodyDataGroups> Groups { get; set; }
            public class QueryDeviceBySQLResponseBodyDataGroups : TeaModel {
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

            }

            [NameInMap("Tags")]
            [Validation(Required=false)]
            public List<QueryDeviceBySQLResponseBodyDataTags> Tags { get; set; }
            public class QueryDeviceBySQLResponseBodyDataTags : TeaModel {
                [NameInMap("TagName")]
                [Validation(Required=false)]
                public string TagName { get; set; }

                [NameInMap("TagValue")]
                [Validation(Required=false)]
                public string TagValue { get; set; }

            }

            [NameInMap("OTAModules")]
            [Validation(Required=false)]
            public List<QueryDeviceBySQLResponseBodyDataOTAModules> OTAModules { get; set; }
            public class QueryDeviceBySQLResponseBodyDataOTAModules : TeaModel {
                [NameInMap("ModuleName")]
                [Validation(Required=false)]
                public string ModuleName { get; set; }

                [NameInMap("FirmwareVersion")]
                [Validation(Required=false)]
                public string FirmwareVersion { get; set; }

            }

        }

    }

}
