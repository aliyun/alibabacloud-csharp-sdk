// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListLineageResponseBody : TeaModel {
        /// <summary>
        /// <para>The structure returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLineageResponseBodyData Data { get; set; }
        public class ListLineageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The array of the entity structure.</para>
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<ListLineageResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class ListLineageResponseBodyDataDataEntityList : TeaModel {
                /// <summary>
                /// <para>The time when the lineage was generated.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1686215809269</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The information about the entity.</para>
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public Entity Entity { get; set; }

                /// <summary>
                /// <para>The array of the relationship structure.</para>
                /// </summary>
                [NameInMap("RelationList")]
                [Validation(Required=false)]
                public List<ListLineageResponseBodyDataDataEntityListRelationList> RelationList { get; set; }
                public class ListLineageResponseBodyDataDataEntityListRelationList : TeaModel {
                    /// <summary>
                    /// <para>The data channel. Valid values:</para>
                    /// <pre><c>FIRST_PARTY: DataWorks platformTHIRD_PARTY: user registration
                    /// </c></pre>
                    /// 
                    /// <b>Example:</b>
                    /// <para>THIRD_PARTY</para>
                    /// </summary>
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// <para>The name of the data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>mysql</para>
                    /// </summary>
                    [NameInMap("Datasource")]
                    [Validation(Required=false)]
                    public string Datasource { get; set; }

                    /// <summary>
                    /// <para>The unique relationship ID.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aaabbccddguid</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <para>The task type, which is used to describe the relationship between entities, such as SQL-based calculation, mapping based on report fields, or API operation definition.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>sql</para>
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// <para>A pagination token. It can be used in the next request to retrieve a new page of results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>nextTokenFromRequest-xxxsd-ff</para>
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1010040007</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>qualifiedName should be in format as entity-table.entity-guid</para>
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64B-587A-8CED-969E1973887FXXX-TT</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <para>true</para>
        /// <para>false</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
