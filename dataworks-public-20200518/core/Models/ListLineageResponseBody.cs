// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListLineageResponseBody : TeaModel {
        /// <summary>
        /// <para>The response structure.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLineageResponseBodyData Data { get; set; }
        public class ListLineageResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The array of entity structures.</para>
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<ListLineageResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class ListLineageResponseBodyDataDataEntityList : TeaModel {
                /// <summary>
                /// <para>The time when the lineage was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1686215809269</para>
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// <para>The entity information.</para>
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public Entity Entity { get; set; }

                /// <summary>
                /// <para>The array of relation structures.</para>
                /// </summary>
                [NameInMap("RelationList")]
                [Validation(Required=false)]
                public List<ListLineageResponseBodyDataDataEntityListRelationList> RelationList { get; set; }
                public class ListLineageResponseBodyDataDataEntityListRelationList : TeaModel {
                    /// <summary>
                    /// <para>The data channel. Valid values:</para>
                    /// <list type="bullet">
                    /// <item><description><b>FIRST_PARTY</b>: DataWorks platform data.</description></item>
                    /// <item><description><b>THIRD_PARTY</b>: User-registered data.</description></item>
                    /// </list>
                    /// 
                    /// <b>Example:</b>
                    /// <para>THIRD_PARTY</para>
                    /// </summary>
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// <para>The data source.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>maxcompute,mysql</para>
                    /// </summary>
                    [NameInMap("Datasource")]
                    [Validation(Required=false)]
                    public string Datasource { get; set; }

                    /// <summary>
                    /// <para>The unique ID of the relation.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>aaabbccddguid</para>
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// <para>The task type, which describes the relationship type between entities. For example, computed by SQL, mapped by report fields, or defined by API.</para>
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
            /// <para>The pagination token that specifies the starting point of the next read operation.</para>
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
        /// <para>The request ID. Used to locate logs and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>64B-587A-8CED-969E1973887FXXX-TT</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
