// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Adb20211201.Models
{
    public class ModifyLakeCacheSizeResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ModifyLakeCacheSizeResponseBodyData Data { get; set; }
        public class ModifyLakeCacheSizeResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("DataSize")]
            [Validation(Required=false)]
            public long? DataSize { get; set; }

            [NameInMap("Instances")]
            [Validation(Required=false)]
            public List<string> Instances { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>494486CE-6F49-574E-B304-29127EA12E36</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
