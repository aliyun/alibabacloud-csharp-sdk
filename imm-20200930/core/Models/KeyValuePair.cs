// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class KeyValuePair : TeaModel {
        /// <summary>
        /// <para>The key.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bucket</para>
        /// </summary>
        [NameInMap("Key")]
        [Validation(Required=false)]
        public string Key { get; set; }

        /// <summary>
        /// <para>The value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testbucket</para>
        /// </summary>
        [NameInMap("Value")]
        [Validation(Required=false)]
        public string Value { get; set; }

    }

}
