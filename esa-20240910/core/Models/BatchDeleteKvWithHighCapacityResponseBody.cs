// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class BatchDeleteKvWithHighCapacityResponseBody : TeaModel {
        /// <summary>
        /// <para>The keys that failed to be deleted.</para>
        /// </summary>
        [NameInMap("FailKeys")]
        [Validation(Required=false)]
        public List<string> FailKeys { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The keys that are deleted.</para>
        /// </summary>
        [NameInMap("SuccessKeys")]
        [Validation(Required=false)]
        public List<string> SuccessKeys { get; set; }

    }

}
