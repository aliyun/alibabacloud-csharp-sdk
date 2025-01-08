// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class SyncSensitiveWordResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>00000</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public SyncSensitiveWordResponseBodyData Data { get; set; }
        public class SyncSensitiveWordResponseBodyData : TeaModel {
            [NameInMap("SensitiveWordErrorList")]
            [Validation(Required=false)]
            public List<SyncSensitiveWordResponseBodyDataSensitiveWordErrorList> SensitiveWordErrorList { get; set; }
            public class SyncSensitiveWordResponseBodyDataSensitiveWordErrorList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>&quot;&quot;</para>
                /// </summary>
                [NameInMap("ErrMessage")]
                [Validation(Required=false)]
                public string ErrMessage { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("ErrStatus")]
                [Validation(Required=false)]
                public int? ErrStatus { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("Index")]
                [Validation(Required=false)]
                public long? Index { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>contraband</para>
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                [NameInMap("Word")]
                [Validation(Required=false)]
                public string Word { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>AAAAAA-BBBB-CCCCC-DDDD-EEEEEEEE****</para>
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
