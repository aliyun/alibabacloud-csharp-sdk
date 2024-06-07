// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20180601.Models
{
    public class ListHiveColumnLineagesResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListHiveColumnLineagesResponseBodyData Data { get; set; }
        public class ListHiveColumnLineagesResponseBodyData : TeaModel {
            [NameInMap("DownstreamLineages")]
            [Validation(Required=false)]
            public List<ListHiveColumnLineagesResponseBodyDataDownstreamLineages> DownstreamLineages { get; set; }
            public class ListHiveColumnLineagesResponseBodyDataDownstreamLineages : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("DirectDownColumnNumber")]
                [Validation(Required=false)]
                public int? DirectDownColumnNumber { get; set; }

                [NameInMap("DirectDownTableNumber")]
                [Validation(Required=false)]
                public int? DirectDownTableNumber { get; set; }

                [NameInMap("DirectUpperColumnNumber")]
                [Validation(Required=false)]
                public int? DirectUpperColumnNumber { get; set; }

                [NameInMap("DirectUpperTableNumber")]
                [Validation(Required=false)]
                public int? DirectUpperTableNumber { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("DownstreamNumber")]
            [Validation(Required=false)]
            public int? DownstreamNumber { get; set; }

            [NameInMap("UpstreamLineages")]
            [Validation(Required=false)]
            public List<ListHiveColumnLineagesResponseBodyDataUpstreamLineages> UpstreamLineages { get; set; }
            public class ListHiveColumnLineagesResponseBodyDataUpstreamLineages : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ColumnName")]
                [Validation(Required=false)]
                public string ColumnName { get; set; }

                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("DatabaseName")]
                [Validation(Required=false)]
                public string DatabaseName { get; set; }

                [NameInMap("DirectDownColumnNumber")]
                [Validation(Required=false)]
                public int? DirectDownColumnNumber { get; set; }

                [NameInMap("DirectDownTableNumber")]
                [Validation(Required=false)]
                public int? DirectDownTableNumber { get; set; }

                [NameInMap("DirectUpperColumnNumber")]
                [Validation(Required=false)]
                public int? DirectUpperColumnNumber { get; set; }

                [NameInMap("DirectUpperTableNumber")]
                [Validation(Required=false)]
                public int? DirectUpperTableNumber { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public string ModifiedTime { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("TableName")]
                [Validation(Required=false)]
                public string TableName { get; set; }

            }

            [NameInMap("UpstreamNumber")]
            [Validation(Required=false)]
            public int? UpstreamNumber { get; set; }

        }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
