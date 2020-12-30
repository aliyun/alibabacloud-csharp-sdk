// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.HBase20190101.Models
{
    public class DescribeRestoreFullDetailsResponseBody : TeaModel {
        [NameInMap("RestoreFull")]
        [Validation(Required=false)]
        public DescribeRestoreFullDetailsResponseBodyRestoreFull RestoreFull { get; set; }
        public class DescribeRestoreFullDetailsResponseBodyRestoreFull : TeaModel {
            [NameInMap("Succeed")]
            [Validation(Required=false)]
            public int? Succeed { get; set; }
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public string DataSize { get; set; }
            [NameInMap("Speed")]
            [Validation(Required=false)]
            public string Speed { get; set; }
            [NameInMap("RestoreFullDetails")]
            [Validation(Required=false)]
            public DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetails RestoreFullDetails { get; set; }
            public class DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetails : TeaModel {
                [NameInMap("RestoreFullDetail")]
                [Validation(Required=false)]
                public List<DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail> RestoreFullDetail { get; set; }
                public class DescribeRestoreFullDetailsResponseBodyRestoreFullRestoreFullDetailsRestoreFullDetail : TeaModel {
                    [NameInMap("EndTime")]
                    [Validation(Required=false)]
                    public string EndTime { get; set; }

                    [NameInMap("StartTime")]
                    [Validation(Required=false)]
                    public string StartTime { get; set; }

                    [NameInMap("Process")]
                    [Validation(Required=false)]
                    public string Process { get; set; }

                    [NameInMap("DataSize")]
                    [Validation(Required=false)]
                    public string DataSize { get; set; }

                    [NameInMap("Speed")]
                    [Validation(Required=false)]
                    public string Speed { get; set; }

                    [NameInMap("State")]
                    [Validation(Required=false)]
                    public string State { get; set; }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                    [NameInMap("Table")]
                    [Validation(Required=false)]
                    public string Table { get; set; }

                }

            }
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }
            [NameInMap("Fail")]
            [Validation(Required=false)]
            public int? Fail { get; set; }
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
