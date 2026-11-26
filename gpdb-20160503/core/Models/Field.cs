// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class Field : TeaModel {
        /// <summary>
        /// <para>The Base64-encoded binary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aGVsbG8=</para>
        /// </summary>
        [NameInMap("BlobValue")]
        [Validation(Required=false)]
        public string BlobValue { get; set; }

        /// <summary>
        /// <para>The Boolean value.</para>
        /// </summary>
        [NameInMap("BooleanValue")]
        [Validation(Required=false)]
        public bool? BooleanValue { get; set; }

        /// <summary>
        /// <para>The Double value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.25</para>
        /// </summary>
        [NameInMap("DoubleValue")]
        [Validation(Required=false)]
        public double? DoubleValue { get; set; }

        /// <summary>
        /// <para>The null status.</para>
        /// </summary>
        [NameInMap("IsNull")]
        [Validation(Required=false)]
        public bool? IsNull { get; set; }

        /// <summary>
        /// <para>The Long value.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456789</para>
        /// </summary>
        [NameInMap("LongValue")]
        [Validation(Required=false)]
        public long? LongValue { get; set; }

        /// <summary>
        /// <para>The string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Sample text</para>
        /// </summary>
        [NameInMap("StringValue")]
        [Validation(Required=false)]
        public string StringValue { get; set; }

    }

}
