// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class QueryUserOmsDataRequest : TeaModel {
        /// <summary>
        /// The time type of the usage data. Set the parameter based on the description in the documentation of the specified service. Valid values:
        /// 
        /// *   Raw
        /// *   Hour
        /// *   Day
        /// *   Month
        /// </summary>
        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        /// <summary>
        /// The end of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// The name of the record from which the usage data starts to return. The usage data records whose names are alphabetically after the value of the Marker parameter are returned. By default, the usage data starts to return from the earliest record.
        /// </summary>
        [NameInMap("Marker")]
        [Validation(Required=false)]
        public string Marker { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Valid values: 1 to 200. Default value: 100.
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// The service whose usage data you want to query and the details of the usage data. The parameter value is usually set to the code of a service. Various usage models are provided for different services.
        /// </summary>
        [NameInMap("Table")]
        [Validation(Required=false)]
        public string Table { get; set; }

    }

}
