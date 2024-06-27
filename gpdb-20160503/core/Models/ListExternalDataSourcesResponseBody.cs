// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ListExternalDataSourcesResponseBody : TeaModel {
        /// <summary>
        /// The Hadoop external table services.
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListExternalDataSourcesResponseBodyItems> Items { get; set; }
        public class ListExternalDataSourcesResponseBodyItems : TeaModel {
            /// <summary>
            /// The time when the service was created.
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// The description of the data source.
            /// </summary>
            [NameInMap("DataSourceDescription")]
            [Validation(Required=false)]
            public string DataSourceDescription { get; set; }

            /// <summary>
            /// The service directory in which Hadoop-related configuration files are stored.
            /// </summary>
            [NameInMap("DataSourceDir")]
            [Validation(Required=false)]
            public string DataSourceDir { get; set; }

            /// <summary>
            /// The service ID.
            /// </summary>
            [NameInMap("DataSourceId")]
            [Validation(Required=false)]
            public int? DataSourceId { get; set; }

            /// <summary>
            /// The name of the service.
            /// </summary>
            [NameInMap("DataSourceName")]
            [Validation(Required=false)]
            public string DataSourceName { get; set; }

            /// <summary>
            /// The status of the service. Valid values:
            /// 
            /// *   init
            /// *   running
            /// *   exception
            /// </summary>
            [NameInMap("DataSourceStatus")]
            [Validation(Required=false)]
            public string DataSourceStatus { get; set; }

            /// <summary>
            /// The type of the data source.
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            [NameInMap("ExternalDataServiceId")]
            [Validation(Required=false)]
            public int? ExternalDataServiceId { get; set; }

            /// <summary>
            /// The time when the service was last modified.
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// The information about the service status. For example, if the service is in the exception state, the cause of the exception is displayed. If the service is in the running state, this parameter is left empty.
            /// </summary>
            [NameInMap("StatusMessage")]
            [Validation(Required=false)]
            public string StatusMessage { get; set; }

        }

        /// <summary>
        /// The page number.
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The total number of entries returned.
        /// </summary>
        [NameInMap("TotalRecordCount")]
        [Validation(Required=false)]
        public int? TotalRecordCount { get; set; }

    }

}
