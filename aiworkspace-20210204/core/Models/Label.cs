// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class Label : TeaModel {
        /// <summary>
        /// <para>The label key. The value can be up to 128 bytes in length and cannot contain equal signs (=) and commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>env</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The label value. The value can be up to 128 bytes in length and cannot contain equal signs (=) and commas (,).</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
