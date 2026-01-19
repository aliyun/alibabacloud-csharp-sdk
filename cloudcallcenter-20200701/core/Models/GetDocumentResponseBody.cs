// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CloudCallCenter20200701.Models
{
    public class GetDocumentResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDocumentResponseBodyData Data { get; set; }
        public class GetDocumentResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{&quot;name&quot;:&quot;tom&quot;}</para>
            /// </summary>
            [NameInMap("Document")]
            [Validation(Required=false)]
            public Dictionary<string, object> Document { get; set; }

            /// <summary>
            /// <para>scheme</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public GetDocumentResponseBodyDataSchema Schema { get; set; }
            public class GetDocumentResponseBodyDataSchema : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-16T02:12:12Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>terraform-example</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>schame id</para>
                /// 
                /// <b>Example:</b>
                /// <para>400135</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>57236c4f-48e9-49ca-a560-8697ec6c185e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, DataSchemaPropertiesValue> Properties { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>2024-10-16T02:12:12Z</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

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
        /// <para>success</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>943D8EF3-3321-471F-A104-51C96FCA94D6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
