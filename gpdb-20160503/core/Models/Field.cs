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
        /// </summary>
        [NameInMap("DoubleValue")]
        [Validation(Required=false)]
        public double? DoubleValue { get; set; }

        /// <summary>
        /// <para>Indicates whether the value is null.</para>
        /// </summary>
        [NameInMap("IsNull")]
        [Validation(Required=false)]
        public bool? IsNull { get; set; }

        /// <summary>
        /// <para>The Long value.</para>
        /// </summary>
        [NameInMap("LongValue")]
        [Validation(Required=false)]
        public long? LongValue { get; set; }

        /// <summary>
        /// <para>The string.</para>
        /// </summary>
        [NameInMap("StringValue")]
        [Validation(Required=false)]
        public string StringValue { get; set; }

    }

}
