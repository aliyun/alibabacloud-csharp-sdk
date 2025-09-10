// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imagerecog20190930.Models
{
    public class RecognizeImageColorResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public RecognizeImageColorResponseBodyData Data { get; set; }
        public class RecognizeImageColorResponseBodyData : TeaModel {
            [NameInMap("ColorTemplateList")]
            [Validation(Required=false)]
            public List<RecognizeImageColorResponseBodyDataColorTemplateList> ColorTemplateList { get; set; }
            public class RecognizeImageColorResponseBodyDataColorTemplateList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>270315</para>
                /// </summary>
                [NameInMap("Color")]
                [Validation(Required=false)]
                public string Color { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>red</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0.459527</para>
                /// </summary>
                [NameInMap("Percentage")]
                [Validation(Required=false)]
                public float? Percentage { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>CCC7C1D9-8C0F-58AD-ADE3-C331B83BD6F2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
