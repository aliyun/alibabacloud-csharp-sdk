// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetKvDetailResponseBody : TeaModel {
        /// <summary>
        /// <para>The expiration time of the key. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("ExpirationTtl")]
        [Validation(Required=false)]
        public string ExpirationTtl { get; set; }

        /// <summary>
        /// <para>The expiration time of the key. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CB1A380B-09F0-41BB-280B-72F8FD6DA2FE</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The value of the key. The value of the root node.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_value</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
