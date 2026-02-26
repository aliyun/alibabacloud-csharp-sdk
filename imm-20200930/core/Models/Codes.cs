// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class Codes : TeaModel {
        /// <summary>
        /// <para>The boundary of the code.</para>
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// <para>The confidence level of the code. A greater value indicates a higher confidence level. A value exceeding 0.8 signifies a high degree of confidence in the result.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.9</para>
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public float? Confidence { get; set; }

        /// <summary>
        /// <para>The content of the code.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://www.example.com">https://www.example.com</a></para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <para>The type of the code.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>qrcode</description></item>
        /// <item><description>barcode</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>qrcode</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
