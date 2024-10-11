// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class GetContactFlowResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetContactFlowResponseBodyData Data { get; set; }
        public class GetContactFlowResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>274601be-a6d5-4429-bcef-32b51d031c6e</para>
            /// </summary>
            [NameInMap("ContactFlowId")]
            [Validation(Required=false)]
            public string ContactFlowId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("CreatedTime")]
            [Validation(Required=false)]
            public string CreatedTime { get; set; }

            [NameInMap("Definition")]
            [Validation(Required=false)]
            public string Definition { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1.0</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>566399d7-5558-447c-a72f-9be2768b6a82</para>
            /// </summary>
            [NameInMap("DraftId")]
            [Validation(Required=false)]
            public string DraftId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>editor-xxx</para>
            /// </summary>
            [NameInMap("Editor")]
            [Validation(Required=false)]
            public string Editor { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>ccc-test</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>False</para>
            /// </summary>
            [NameInMap("Published")]
            [Validation(Required=false)]
            public bool? Published { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MAIN_FLOW</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2021-07-14 10:48:43.0</para>
            /// </summary>
            [NameInMap("UpdatedTime")]
            [Validation(Required=false)]
            public string UpdatedTime { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2263B273-AC1B-44EB-BA98-87F2322C6780</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
