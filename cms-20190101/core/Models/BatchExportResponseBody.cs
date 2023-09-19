// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class BatchExportResponseBody : TeaModel {
        /// <summary>
        /// The timestamp of the data requested by the backend. A larger timestamp indicates that the data export time is closer to the current time.
        /// </summary>
        [NameInMap("Anchor")]
        [Validation(Required=false)]
        public long? Anchor { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// 
        /// >  The status code 200 indicates that the request was successful.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        /// <summary>
        /// The Cursor information that is used to call this operation again.
        /// 
        /// >  If `null` is returned, the monitoring data is exported.
        /// </summary>
        [NameInMap("Cursor")]
        [Validation(Required=false)]
        public string Cursor { get; set; }

        /// <summary>
        /// The data returned in this call.
        /// </summary>
        [NameInMap("DataResults")]
        [Validation(Required=false)]
        public List<MetricStat> DataResults { get; set; }

        /// <summary>
        /// Indicates whether the data has been exported. Valid values:
        /// 
        /// *   true: Some data is not exported.
        /// *   false: All the data is exported.
        /// </summary>
        [NameInMap("HasNext")]
        [Validation(Required=false)]
        public bool? HasNext { get; set; }

        /// <summary>
        /// The number of data entries returned in this call.
        /// </summary>
        [NameInMap("Length")]
        [Validation(Required=false)]
        public int? Length { get; set; }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
