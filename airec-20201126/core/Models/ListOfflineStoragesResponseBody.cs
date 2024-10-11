// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListOfflineStoragesResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6839AE7C-A984-48C1-AC17-331BAC6D97BC</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public byte[] RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListOfflineStoragesResponseBodyResult> Result { get; set; }
        public class ListOfflineStoragesResponseBodyResult : TeaModel {
            [NameInMap("meta")]
            [Validation(Required=false)]
            public Dictionary<string, object> Meta { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("tableName")]
            [Validation(Required=false)]
            public byte[] TableName { get; set; }

        }

    }

}
