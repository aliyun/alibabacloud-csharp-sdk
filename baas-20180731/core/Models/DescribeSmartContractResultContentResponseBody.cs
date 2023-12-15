// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Baas20180731.Models
{
    public class DescribeSmartContractResultContentResponseBody : TeaModel {
        [NameInMap("DynamicCode")]
        [Validation(Required=false)]
        public string DynamicCode { get; set; }

        [NameInMap("DynamicMessage")]
        [Validation(Required=false)]
        public string DynamicMessage { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public int? ErrorCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DescribeSmartContractResultContentResponseBodyResult> Result { get; set; }
        public class DescribeSmartContractResultContentResponseBodyResult : TeaModel {
            [NameInMap("Diagnostics")]
            [Validation(Required=false)]
            public List<DescribeSmartContractResultContentResponseBodyResultDiagnostics> Diagnostics { get; set; }
            public class DescribeSmartContractResultContentResponseBodyResultDiagnostics : TeaModel {
                [NameInMap("Advice")]
                [Validation(Required=false)]
                public string Advice { get; set; }

                [NameInMap("Code")]
                [Validation(Required=false)]
                public string Code { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                [NameInMap("Message")]
                [Validation(Required=false)]
                public string Message { get; set; }

                [NameInMap("Range")]
                [Validation(Required=false)]
                public List<DescribeSmartContractResultContentResponseBodyResultDiagnosticsRange> Range { get; set; }
                public class DescribeSmartContractResultContentResponseBodyResultDiagnosticsRange : TeaModel {
                    [NameInMap("Character")]
                    [Validation(Required=false)]
                    public int? Character { get; set; }

                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public int? Line { get; set; }

                }

                [NameInMap("Severity")]
                [Validation(Required=false)]
                public int? Severity { get; set; }

                [NameInMap("Source")]
                [Validation(Required=false)]
                public string Source { get; set; }

                [NameInMap("Trace")]
                [Validation(Required=false)]
                public List<DescribeSmartContractResultContentResponseBodyResultDiagnosticsTrace> Trace { get; set; }
                public class DescribeSmartContractResultContentResponseBodyResultDiagnosticsTrace : TeaModel {
                    [NameInMap("Location")]
                    [Validation(Required=false)]
                    public DescribeSmartContractResultContentResponseBodyResultDiagnosticsTraceLocation Location { get; set; }
                    public class DescribeSmartContractResultContentResponseBodyResultDiagnosticsTraceLocation : TeaModel {
                        [NameInMap("Range")]
                        [Validation(Required=false)]
                        public List<DescribeSmartContractResultContentResponseBodyResultDiagnosticsTraceLocationRange> Range { get; set; }
                        public class DescribeSmartContractResultContentResponseBodyResultDiagnosticsTraceLocationRange : TeaModel {
                            [NameInMap("Character")]
                            [Validation(Required=false)]
                            public int? Character { get; set; }

                            [NameInMap("Line")]
                            [Validation(Required=false)]
                            public int? Line { get; set; }

                        }

                        [NameInMap("Uri")]
                        [Validation(Required=false)]
                        public string Uri { get; set; }

                    }

                    [NameInMap("Message")]
                    [Validation(Required=false)]
                    public string Message { get; set; }

                }

            }

            [NameInMap("Uri")]
            [Validation(Required=false)]
            public string Uri { get; set; }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
