// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class ExportDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// The information about the export operation.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ExportDataSourcesResponseBodyData Data { get; set; }
        public class ExportDataSourcesResponseBodyData : TeaModel {
            /// <summary>
            /// The details of the exported data sources.
            /// 
            /// The value is an array. The following parameters are the elements in the array. The sample values of these parameters show the details of a sample data source.
            /// </summary>
            [NameInMap("DataSources")]
            [Validation(Required=false)]
            public List<ExportDataSourcesResponseBodyDataDataSources> DataSources { get; set; }
            public class ExportDataSourcesResponseBodyDataDataSources : TeaModel {
                /// <summary>
                /// The ID of the compute engine to which the data source is bound.
                /// </summary>
                [NameInMap("BindingCalcEngineId")]
                [Validation(Required=false)]
                public int? BindingCalcEngineId { get; set; }

                /// <summary>
                /// Indicates whether the data source is connected to an exclusive resource group. Valid values:
                /// 
                /// *   1: The data source is connected to at least one exclusive resource group.
                /// *   0: The data source is not connected to any exclusive resource group.
                /// </summary>
                [NameInMap("ConnectStatus")]
                [Validation(Required=false)]
                public int? ConnectStatus { get; set; }

                /// <summary>
                /// The configuration of the data source.
                /// </summary>
                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                /// <summary>
                /// The type of the data source. Valid values:
                /// 
                /// *   odps
                /// *   mysql
                /// *   rds
                /// *   oss
                /// *   sqlserver
                /// *   polardb
                /// *   oracle
                /// *   mongodb
                /// *   emr
                /// *   postgresql
                /// *   analyticdb_for_mysql
                /// *   hybriddb_for_postgresql
                /// *   holo
                /// </summary>
                [NameInMap("DataSourceType")]
                [Validation(Required=false)]
                public string DataSourceType { get; set; }

                /// <summary>
                /// Indicates whether the compute engine to which the data source is bound is the default compute engine. Valid values:
                /// 
                /// *   true: The compute engine is the default compute engine.
                /// *   false: The compute engine is not the default compute engine.
                /// </summary>
                [NameInMap("DefaultEngine")]
                [Validation(Required=false)]
                public bool? DefaultEngine { get; set; }

                /// <summary>
                /// The description of the data source.
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                /// <summary>
                /// The environment to which the data source belongs. Valid values:
                /// 
                /// *   0: development environment
                /// *   1: production environment
                /// </summary>
                [NameInMap("EnvType")]
                [Validation(Required=false)]
                public int? EnvType { get; set; }

                /// <summary>
                /// The time when the data source was created. Example: Mar 17, 2021 4:09:32 PM.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the data source was last modified. Example: Mar 17, 2021 4:09:32 PM.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the data source.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public int? Id { get; set; }

                /// <summary>
                /// The name of the data source.
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The ID of the user who exported the data source.
                /// </summary>
                [NameInMap("Operator")]
                [Validation(Required=false)]
                public string Operator { get; set; }

                /// <summary>
                /// The ID of the DataWorks workspace to which the data source belongs.
                /// </summary>
                [NameInMap("ProjectId")]
                [Validation(Required=false)]
                public int? ProjectId { get; set; }

                /// <summary>
                /// The sequence number of the data source.
                /// </summary>
                [NameInMap("Sequence")]
                [Validation(Required=false)]
                public int? Sequence { get; set; }

                /// <summary>
                /// Indicates whether the data source can be shared. Valid values:
                /// 
                /// *   true: The data source can be shared.
                /// *   false: The data source cannot be shared.
                /// </summary>
                [NameInMap("Shared")]
                [Validation(Required=false)]
                public bool? Shared { get; set; }

                /// <summary>
                /// Indicates whether the data source is available. Valid values:
                /// 
                /// *   1: The data source is available.
                /// *   0: The data source is unavailable.
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                /// <summary>
                /// The subtype of the data source. This parameter is returned only if the value of the DataSourceType parameter is rds.
                /// 
                /// If the value of the DataSourceType parameter is rds, the value of this parameter can be mysql, sqlserver, or postgresql.
                /// </summary>
                [NameInMap("SubType")]
                [Validation(Required=false)]
                public string SubType { get; set; }

                /// <summary>
                /// The ID of the Alibaba Cloud account to which the data source belongs.
                /// </summary>
                [NameInMap("TenantId")]
                [Validation(Required=false)]
                public long? TenantId { get; set; }

            }

            /// <summary>
            /// The page number of the returned page. The value of this parameter is a positive integer greater than or equal to 1.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries returned on each page.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The total number of entries returned.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The HTTP status code returned. Valid values:
        /// 
        /// *   200: The request was successful.
        /// *   Other values: The request failed. You can troubleshoot issues based on the HTTP status code returned.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The ID of the request. You can locate logs and troubleshoot issues based on the ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
