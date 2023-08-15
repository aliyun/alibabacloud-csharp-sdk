// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreSchemaDetailsResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("RestoreSchema")]
        [Validation(Required=false)]
        public DescribeRestoreSchemaDetailsResponseBodyRestoreSchema RestoreSchema { get; set; }
        public class DescribeRestoreSchemaDetailsResponseBodyRestoreSchema : TeaModel {
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }

            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("RestoreSchemaDetails")]
            [Validation(Required=false)]
            public DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetails RestoreSchemaDetails { get; set; }
            public class DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetails : TeaModel {
                [NameInMap("RestoreSchemaDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail> RestoreSchemaDetail { get; set; }
                public class DescribeRestoreSchemaDetailsResponseBodyRestoreSchemaRestoreSchemaDetailsRestoreSchemaDetail : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

            }

            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

    }

}
