// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Qualitycheck20190115.Models
{
    public class VerifySentenceResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
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
                [NameInMap("Source")]
                [Validation(Required=false)]
                public VerifySentenceResponseBodyDataDeltaSource Source { get; set; }
                public class VerifySentenceResponseBodyDataDeltaSource : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public VerifySentenceResponseBodyDataDeltaSourceLine Line { get; set; }
                    public class VerifySentenceResponseBodyDataDeltaSourceLine : TeaModel {
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public List<string> Line { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                }

                [NameInMap("Target")]
                [Validation(Required=false)]
                public VerifySentenceResponseBodyDataDeltaTarget Target { get; set; }
                public class VerifySentenceResponseBodyDataDeltaTarget : TeaModel {
                    [NameInMap("Line")]
                    [Validation(Required=false)]
                    public VerifySentenceResponseBodyDataDeltaTargetLine Line { get; set; }
                    public class VerifySentenceResponseBodyDataDeltaTargetLine : TeaModel {
                        [NameInMap("Line")]
                        [Validation(Required=false)]
                        public List<string> Line { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>1</para>
                    /// </summary>
                    [NameInMap("Position")]
                    [Validation(Required=false)]
                    public int? Position { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CHANGE</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("IncorrectWords")]
        [Validation(Required=false)]
        public int? IncorrectWords { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>106C6CA0-282D-4AF7-85F0-D2D24F4CE647</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("SourceRole")]
        [Validation(Required=false)]
        public int? SourceRole { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TargetRole")]
        [Validation(Required=false)]
        public int? TargetRole { get; set; }

    }

}
