// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class BatchPutDcdnKvResponseBody : TeaModel {
        /// <summary>
        /// <para>The keys that failed to be written.</para>
        /// </summary>
        [NameInMap("FailKeys")]
        [Validation(Required=false)]
        public List<string> FailKeys { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>156A6B-677B1A-4297B7-9187B7-2B44792</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The keys that were written.</para>
        /// </summary>
        [NameInMap("SuccessKeys")]
        [Validation(Required=false)]
        public List<string> SuccessKeys { get; set; }

    }

}
