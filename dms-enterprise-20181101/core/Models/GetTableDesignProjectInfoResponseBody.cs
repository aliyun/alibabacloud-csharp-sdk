// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetTableDesignProjectInfoResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the request failed.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned if the request failed.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The information about the schema design project.
        /// </summary>
        [NameInMap("ProjectInfo")]
        [Validation(Required=false)]
        public GetTableDesignProjectInfoResponseBodyProjectInfo ProjectInfo { get; set; }
        public class GetTableDesignProjectInfoResponseBodyProjectInfo : TeaModel {
            /// <summary>
            /// The information about the change base database of the schema design ticket.
            /// </summary>
            [NameInMap("BaseDatabase")]
            [Validation(Required=false)]
            public GetTableDesignProjectInfoResponseBodyProjectInfoBaseDatabase BaseDatabase { get; set; }
            public class GetTableDesignProjectInfoResponseBodyProjectInfoBaseDatabase : TeaModel {
                /// <summary>
                /// The alias of the database instance.
                /// </summary>
                [NameInMap("Alias")]
                [Validation(Required=false)]
                public string Alias { get; set; }

                /// <summary>
                /// The database ID.
                /// </summary>
                [NameInMap("DbId")]
                [Validation(Required=false)]
                public int? DbId { get; set; }

                /// <summary>
                /// The type of the database. For more information about the valid values of this parameter, see [DbType parameter](https://help.aliyun.com/document_detail/198106.html).
                /// </summary>
                [NameInMap("DbType")]
                [Validation(Required=false)]
                public string DbType { get; set; }

                /// <summary>
                /// The type of the environment in which the database instance is deployed. Valid values:
                /// 
                /// *   **product**: production environment.
                /// *   **dev**: development environment.
                /// *   **pre**: pre-release environment.
                /// *   **test**: test environment.
                /// *   **sit**: system integration testing (SIT) environment.
                /// *   **uat**: user acceptance testing (UAT) environment.
                /// *   **pet**: stress testing environment.
                /// *   **stag**: staging environment.
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public string EnvType { get; set; }

                /// <summary>
                /// Indicates whether the database is a logical database. Valid values:
                /// 
                /// *   **true**
                /// *   **false**
                /// </summary>
                [NameInMap("Logic")]
                [Validation(Required=false)]
                public bool? Logic { get; set; }

                /// <summary>
                /// The database name.
                /// </summary>
                [NameInMap("SchemaName")]
                [Validation(Required=false)]
                public string SchemaName { get; set; }

                /// <summary>
                /// The name that is used to search for the database.
                /// </summary>
                [NameInMap("SearchName")]
                [Validation(Required=false)]
                public string SearchName { get; set; }

            }

            /// <summary>
            /// The ID of the user who created the ticket.
            /// </summary>
            [NameInMap("CreatorId")]
            [Validation(Required=false)]
            public long? CreatorId { get; set; }

            /// <summary>
            /// The description of the schema design project.
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// The time when the ticket was created.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The time when the ticket was last modified.
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            /// <summary>
            /// The ticket ID.
            /// </summary>
            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public long? OrderId { get; set; }

            /// <summary>
            /// The project ID.
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public long? ProjectId { get; set; }

            /// <summary>
            /// The state of the schema design project. Valid values:
            /// 
            /// *   **DESIGN**: The schema is being designed.
            /// *   **PUBLISHED**: The schema is published.
            /// *   **CLOSE**: The ticket is closed.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// The name of the schema design project.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the request ID to query logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**
        /// *   **false**
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
