// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageCarsResponseBody : TeaModel {
        /// <summary>
        /// <para>The vehicles.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Cars")]
        [Validation(Required=false)]
        public List<Car> Cars { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A8745209-DD0E-027E-8ABA-085E0C******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
