// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DataSetBloodResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>46e537a5****,3dadsu****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<DataSetBloodResponseBodyResult> Result { get; set; }
        public class DataSetBloodResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>ccd3428c-<b><b>-</b></b>-a608-26bae29dffee</para>
            /// </summary>
            [NameInMap("WorksId")]
            [Validation(Required=false)]
            public string WorksId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>PAGE</para>
            /// </summary>
            [NameInMap("WorksType")]
            [Validation(Required=false)]
            public string WorksType { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
