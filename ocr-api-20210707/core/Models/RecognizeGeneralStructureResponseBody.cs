// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ocr_api20210707.Models
{
    public class RecognizeGeneralStructureResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>LLMTimeout</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeGeneralStructureResponseBodyData Data { get; set; }
        public class RecognizeGeneralStructureResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2000</para>
            /// </summary>
            [NameInMap("Height")]
            [Validation(Required=false)]
            public int? Height { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SubImageCount")]
            [Validation(Required=false)]
            public int? SubImageCount { get; set; }

            [NameInMap("SubImages")]
            [Validation(Required=false)]
            public List<RecognizeGeneralStructureResponseBodyDataSubImages> SubImages { get; set; }
            public class RecognizeGeneralStructureResponseBodyDataSubImages : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Angle")]
                [Validation(Required=false)]
                public int? Angle { get; set; }

                [NameInMap("KvInfo")]
                [Validation(Required=false)]
                public RecognizeGeneralStructureResponseBodyDataSubImagesKvInfo KvInfo { get; set; }
                public class RecognizeGeneralStructureResponseBodyDataSubImagesKvInfo : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public object Data { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>6</para>
                    /// </summary>
                    [NameInMap("KvCount")]
                    [Validation(Required=false)]
                    public int? KvCount { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("SubImageId")]
                [Validation(Required=false)]
                public int? SubImageId { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1000</para>
            /// </summary>
            [NameInMap("Width")]
            [Validation(Required=false)]
            public int? Width { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Large language model timeout, please try again with fewer keys.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2F86F9B6-CF68-1574-860C-7CC5E46F14BC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
