// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ListDocumentsResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>OK</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDocumentsResponseBodyData Data { get; set; }
        public class ListDocumentsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The list of documents.</para>
            /// </summary>
            [NameInMap("Documents")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> Documents { get; set; }

            /// <summary>
            /// <para>The token for the next page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>54d1a616d95a4a01ba58967a9115b649</para>
            /// </summary>
            [NameInMap("NextPageToken")]
            [Validation(Required=false)]
            public string NextPageToken { get; set; }

            /// <summary>
            /// <para>The schema.</para>
            /// </summary>
            [NameInMap("Schema")]
            [Validation(Required=false)]
            public ListDocumentsResponseBodyDataSchema Schema { get; set; }
            public class ListDocumentsResponseBodyDataSchema : TeaModel {
                /// <summary>
                /// <para>The time when the schema was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-14T09:53:53Z</para>
                /// </summary>
                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <para>Indicates whether the schema is deleted.</para>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("Deleted")]
                [Validation(Required=false)]
                public bool? Deleted { get; set; }

                /// <summary>
                /// <para>The description.</para>
                /// 
                /// <b>Example:</b>
                /// <list type="bullet">
                /// <item><description></description></item>
                /// </list>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// <para>The schema ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>profile</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The instance ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>87b12784-8ce2-40b6-b21f-c49cb3b5501e</para>
                /// </summary>
                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                /// <summary>
                /// <para>The list of fields.</para>
                /// </summary>
                [NameInMap("Properties")]
                [Validation(Required=false)]
                public Dictionary<string, DataSchemaPropertiesValue> Properties { get; set; }

                /// <summary>
                /// <para>The time when the schema was last updated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-10-14T09:53:53Z</para>
                /// </summary>
                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public string UpdatedTime { get; set; }

            }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public long? TotalCount { get; set; }

        }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<string> Params { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7BEEA660-A45A-45E3-98CC-AFC65E715C23</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
