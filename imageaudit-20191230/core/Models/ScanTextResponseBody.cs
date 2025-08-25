// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imageaudit20191230.Models
{
    public class ScanTextResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ScanTextResponseBodyData Data { get; set; }
        public class ScanTextResponseBodyData : TeaModel {
            [NameInMap("Elements")]
            [Validation(Required=false)]
            public List<ScanTextResponseBodyDataElements> Elements { get; set; }
            public class ScanTextResponseBodyDataElements : TeaModel {
                [NameInMap("Results")]
                [Validation(Required=false)]
                public List<ScanTextResponseBodyDataElementsResults> Results { get; set; }
                public class ScanTextResponseBodyDataElementsResults : TeaModel {
                    [NameInMap("Details")]
                    [Validation(Required=false)]
                    public List<ScanTextResponseBodyDataElementsResultsDetails> Details { get; set; }
                    public class ScanTextResponseBodyDataElementsResultsDetails : TeaModel {
                        [NameInMap("Contexts")]
                        [Validation(Required=false)]
                        public List<ScanTextResponseBodyDataElementsResultsDetailsContexts> Contexts { get; set; }
                        public class ScanTextResponseBodyDataElementsResultsDetailsContexts : TeaModel {
                            [NameInMap("Context")]
                            [Validation(Required=false)]
                            public string Context { get; set; }

                        }

                        /// <summary>
                        /// <b>Example:</b>
                        /// <para>ad</para>
                        /// </summary>
                        [NameInMap("Label")]
                        [Validation(Required=false)]
                        public string Label { get; set; }

                    }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>ad</para>
                    /// </summary>
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>99.91</para>
                    /// </summary>
                    [NameInMap("Rate")]
                    [Validation(Required=false)]
                    public float? Rate { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>block</para>
                    /// </summary>
                    [NameInMap("Suggestion")]
                    [Validation(Required=false)]
                    public string Suggestion { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>txt6Vh5Fv0DAFy5hgdVRt3pqf-1s82jj</para>
                /// </summary>
                [NameInMap("TaskId")]
                [Validation(Required=false)]
                public string TaskId { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>C7CD87E3-57A5-4E2F-8A44-809F3554692C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
