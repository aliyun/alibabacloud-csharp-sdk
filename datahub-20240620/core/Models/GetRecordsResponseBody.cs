// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Datahub20240620.Models
{
    public class GetRecordsResponseBody : TeaModel {
        /// <summary>
        /// <para>The records that were read.</para>
        /// </summary>
        [NameInMap("Records")]
        [Validation(Required=false)]
        public List<GetRecordsResponseBodyRecords> Records { get; set; }
        public class GetRecordsResponseBodyRecords : TeaModel {
            /// <summary>
            /// <para>The additional information of the record. This value is empty if no additional information exists.</para>
            /// </summary>
            [NameInMap("Attributes")]
            [Validation(Required=false)]
            public Dictionary<string, string> Attributes { get; set; }

            /// <summary>
            /// <para>The data content of the record.</para>
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<string> Data { get; set; }

            /// <summary>
            /// <para>The write time of the record.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1769065251123</para>
            /// </summary>
            [NameInMap("SystemTime")]
            [Validation(Required=false)]
            public long? SystemTime { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A20A7093-8FE0-058C-BE0C-3C8057D5F1A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call was successful.</description></item>
        /// <item><description>false: The call failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
