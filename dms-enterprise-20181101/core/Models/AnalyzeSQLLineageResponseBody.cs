// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class AnalyzeSQLLineageResponseBody : TeaModel {
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LineageResult")]
        [Validation(Required=false)]
        public AnalyzeSQLLineageResponseBodyLineageResult LineageResult { get; set; }
        public class AnalyzeSQLLineageResponseBodyLineageResult : TeaModel {
            [NameInMap("Lineages")]
            [Validation(Required=false)]
            public List<AnalyzeSQLLineageResponseBodyLineageResultLineages> Lineages { get; set; }
            public class AnalyzeSQLLineageResponseBodyLineageResultLineages : TeaModel {
                [NameInMap("Dst")]
                [Validation(Required=false)]
                public string Dst { get; set; }

                [NameInMap("LineageType")]
                [Validation(Required=false)]
                public string LineageType { get; set; }

                [NameInMap("OperType")]
                [Validation(Required=false)]
                public string OperType { get; set; }

                [NameInMap("ProcessDetail")]
                [Validation(Required=false)]
                public AnalyzeSQLLineageResponseBodyLineageResultLineagesProcessDetail ProcessDetail { get; set; }
                public class AnalyzeSQLLineageResponseBodyLineageResultLineagesProcessDetail : TeaModel {
                    [NameInMap("CalWay")]
                    [Validation(Required=false)]
                    public string CalWay { get; set; }

                    [NameInMap("Code")]
                    [Validation(Required=false)]
                    public string Code { get; set; }

                }

                [NameInMap("Src")]
                [Validation(Required=false)]
                public string Src { get; set; }

            }

            [NameInMap("ObjectMetadata")]
            [Validation(Required=false)]
            public List<AnalyzeSQLLineageResponseBodyLineageResultObjectMetadata> ObjectMetadata { get; set; }
            public class AnalyzeSQLLineageResponseBodyLineageResultObjectMetadata : TeaModel {
                [NameInMap("Fields")]
                [Validation(Required=false)]
                public List<AnalyzeSQLLineageResponseBodyLineageResultObjectMetadataFields> Fields { get; set; }
                public class AnalyzeSQLLineageResponseBodyLineageResultObjectMetadataFields : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                }

                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
