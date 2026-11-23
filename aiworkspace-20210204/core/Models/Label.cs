// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Label : TeaModel {
        /// <summary>
        /// <para>The tag key. It can be up to 128 bytes in length and cannot contain equal signs (=) or half-width commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The tag value. It can be up to 128 bytes in length and cannot contain equal signs (=) or half-width commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
