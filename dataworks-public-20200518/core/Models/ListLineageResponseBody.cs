// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ListLineageResponseBody : TeaModel {
        /// <summary>
        /// The structure returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListLineageResponseBodyData Data { get; set; }
        public class ListLineageResponseBodyData : TeaModel {
            /// <summary>
            /// The array of the entity structure.
            /// </summary>
            [NameInMap("DataEntityList")]
            [Validation(Required=false)]
            public List<ListLineageResponseBodyDataDataEntityList> DataEntityList { get; set; }
            public class ListLineageResponseBodyDataDataEntityList : TeaModel {
                /// <summary>
                /// The time when the lineage was generated.
                /// </summary>
                [NameInMap("CreateTimestamp")]
                [Validation(Required=false)]
                public long? CreateTimestamp { get; set; }

                /// <summary>
                /// The information about the entity.
                /// </summary>
                [NameInMap("Entity")]
                [Validation(Required=false)]
                public Entity Entity { get; set; }

                /// <summary>
                /// The array of the relationship structure.
                /// </summary>
                [NameInMap("RelationList")]
                [Validation(Required=false)]
                public List<ListLineageResponseBodyDataDataEntityListRelationList> RelationList { get; set; }
                public class ListLineageResponseBodyDataDataEntityListRelationList : TeaModel {
                    /// <summary>
                    /// The data channel. Valid values:
                    /// 
                    ///     FIRST_PARTY: DataWorks platformTHIRD_PARTY: user registration
                    /// </summary>
                    [NameInMap("Channel")]
                    [Validation(Required=false)]
                    public string Channel { get; set; }

                    /// <summary>
                    /// The name of the data source.
                    /// </summary>
                    [NameInMap("Datasource")]
                    [Validation(Required=false)]
                    public string Datasource { get; set; }

                    /// <summary>
                    /// The unique relationship ID.
                    /// </summary>
                    [NameInMap("Guid")]
                    [Validation(Required=false)]
                    public string Guid { get; set; }

                    /// <summary>
                    /// The task type, which is used to describe the relationship between entities, such as SQL-based calculation, mapping based on report fields, or API operation definition.
                    /// </summary>
                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                }

            }

            /// <summary>
            /// A pagination token. It can be used in the next request to retrieve a new page of results.
            /// </summary>
            [NameInMap("NextToken")]
            [Validation(Required=false)]
            public string NextToken { get; set; }

        }

        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// true
        /// 
        /// false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
