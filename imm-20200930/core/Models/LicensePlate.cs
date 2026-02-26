// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class LicensePlate : TeaModel {
        /// <summary>
        /// <para>The boundary information of the license plate.</para>
        /// </summary>
        [NameInMap("Boundary")]
        [Validation(Required=false)]
        public Boundary Boundary { get; set; }

        /// <summary>
        /// <para>The confidence level.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0.789</para>
        /// </summary>
        [NameInMap("Confidence")]
        [Validation(Required=false)]
        public double? Confidence { get; set; }

        /// <summary>
        /// <para>The license plate number.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public string Content { get; set; }

    }

}
