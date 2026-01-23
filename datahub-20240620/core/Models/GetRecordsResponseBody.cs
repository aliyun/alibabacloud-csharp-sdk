// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class GetRecordsResponseBody : TeaModel {
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<GetRecordsResponseBodyRecords> Records { get; set; }
        public class GetRecordsResponseBodyRecords : TeaModel {
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<string> Data { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1769065251123</para>
            /// </summary>
            [NameInMap("SystemTime")]
            [Validation(Required=false)]
            public long? SystemTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>A20A7093-8FE0-058C-BE0C-3C8057D5F1A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
