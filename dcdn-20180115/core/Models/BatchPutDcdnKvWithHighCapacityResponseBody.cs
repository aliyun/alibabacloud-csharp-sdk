// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchPutDcdnKvWithHighCapacityResponseBody : TeaModel {
        [NameInMap("FailKeys")]
        [Validation(Required=false)]
        public List<string> FailKeys { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SuccessKeys")]
        [Validation(Required=false)]
        public List<string> SuccessKeys { get; set; }

    }

}
