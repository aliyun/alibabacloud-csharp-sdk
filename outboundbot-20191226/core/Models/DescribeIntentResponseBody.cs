// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class DescribeIntentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Intent")]
        [Validation(Required=false)]
        public DescribeIntentResponseBodyIntent Intent { get; set; }
        public class DescribeIntentResponseBodyIntent : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1578469042851</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("IntentDescription")]
            [Validation(Required=false)]
            public string IntentDescription { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a8494b35-eefb-4c8a-887b-b60d2f0fa57a</para>
            /// </summary>
            [NameInMap("IntentId")]
            [Validation(Required=false)]
            public string IntentId { get; set; }

            [NameInMap("IntentName")]
            [Validation(Required=false)]
            public string IntentName { get; set; }

            [NameInMap("Keywords")]
            [Validation(Required=false)]
            public string Keywords { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>6ef95fd5-558f-4ee8-af34-b2ede087a87c</para>
            /// </summary>
            [NameInMap("ScriptId")]
            [Validation(Required=false)]
            public string ScriptId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1578469042851</para>
            /// </summary>
            [NameInMap("UpdateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            [NameInMap("Utterances")]
            [Validation(Required=false)]
            public string Utterances { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>Success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>254EB995-DEDF-48A4-9101-9CA5B72FFBCC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
