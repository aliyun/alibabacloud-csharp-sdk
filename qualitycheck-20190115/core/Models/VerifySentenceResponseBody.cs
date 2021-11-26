// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class VerifySentenceResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public VerifySentenceResponseBodyData Data { get; set; }
        public class VerifySentenceResponseBodyData : TeaModel {
            [NameInMap("Delta")]
            [Validation(Required=false)]
            public List<VerifySentenceResponseBodyDataDelta> Delta { get; set; }
            public class VerifySentenceResponseBodyDataDelta : TeaModel {
                public VerifySentenceResponseBodyDataDeltaSource Source { get; set; }
                public class VerifySentenceResponseBodyDataDeltaSource : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public VerifySentenceResponseBodyDataDeltaSourceLine Line { get; set; }
                    public class VerifySentenceResponseBodyDataDeltaSourceLine : TeaModel {
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public List<string> Line { get; set; }
                    };

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                }
                public VerifySentenceResponseBodyDataDeltaTarget Target { get; set; }
                public class VerifySentenceResponseBodyDataDeltaTarget : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public VerifySentenceResponseBodyDataDeltaTargetLine Line { get; set; }
                    public class VerifySentenceResponseBodyDataDeltaTargetLine : TeaModel {
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public List<string> Line { get; set; }
                    };

                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                }
                public string Type { get; set; }
            }
        };

        [NameInMap("IncorrectWords")]
        [Validation(Required=false)]
        public int? IncorrectWords { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SourceRole")]
        [Validation(Required=false)]
        public int? SourceRole { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TargetRole")]
        [Validation(Required=false)]
        public int? TargetRole { get; set; }

    }

}
