// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IoTCC20210513.Models
{
    public class ListIoTCloudConnectorGroupsResponseBody : TeaModel {
        [NameInMap("IoTCloudConnectorGroups")]
        [Validation(Required=false)]
        public List<ListIoTCloudConnectorGroupsResponseBodyIoTCloudConnectorGroups> IoTCloudConnectorGroups { get; set; }
        public class ListIoTCloudConnectorGroupsResponseBodyIoTCloudConnectorGroups : TeaModel {
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            [NameInMap("IoTCloudConnectorGroupId")]
            [Validation(Required=false)]
            public string IoTCloudConnectorGroupId { get; set; }

            [NameInMap("IoTCloudConnectorGroupStatus")]
            [Validation(Required=false)]
            public string IoTCloudConnectorGroupStatus { get; set; }

            [NameInMap("IoTCloudConnectors")]
            [Validation(Required=false)]
            public List<ListIoTCloudConnectorGroupsResponseBodyIoTCloudConnectorGroupsIoTCloudConnectors> IoTCloudConnectors { get; set; }
            public class ListIoTCloudConnectorGroupsResponseBodyIoTCloudConnectorGroupsIoTCloudConnectors : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public long? CreateTime { get; set; }

                [NameInMap("IoTCloudConnectorDescription")]
                [Validation(Required=false)]
                public string IoTCloudConnectorDescription { get; set; }

                [NameInMap("IoTCloudConnectorId")]
                [Validation(Required=false)]
                public string IoTCloudConnectorId { get; set; }

                [NameInMap("IoTCloudConnectorName")]
                [Validation(Required=false)]
                public string IoTCloudConnectorName { get; set; }

                [NameInMap("IoTCloudConnectorStatus")]
                [Validation(Required=false)]
                public string IoTCloudConnectorStatus { get; set; }

            }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
