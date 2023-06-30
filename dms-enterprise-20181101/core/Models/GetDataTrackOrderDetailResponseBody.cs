// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class GetDataTrackOrderDetailResponseBody : TeaModel {
        /// <summary>
        /// The details of the ticket.
        /// </summary>
        [NameInMap("DataTrackOrderDetail")]
        [Validation(Required=false)]
        public GetDataTrackOrderDetailResponseBodyDataTrackOrderDetail DataTrackOrderDetail { get; set; }
        public class GetDataTrackOrderDetailResponseBodyDataTrackOrderDetail : TeaModel {
            /// <summary>
            /// The name that is used to search for the database.
            /// </summary>
            [NameInMap("DatabaseSearchName")]
            [Validation(Required=false)]
            public string DatabaseSearchName { get; set; }

            /// <summary>
            /// The ID of the database.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            /// <summary>
            /// The end time of the time range in which data operations are tracked. The time is in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("JobEndTime")]
            [Validation(Required=false)]
            public string JobEndTime { get; set; }

            /// <summary>
            /// The start time of the time range in which data operations are tracked. The time is in the yyyy-MM-dd HH:mm:ss format.
            /// </summary>
            [NameInMap("JobStartTime")]
            [Validation(Required=false)]
            public string JobStartTime { get; set; }

            /// <summary>
            /// The status of the data tracking task. Valid values:
            /// 
            /// *   **INIT**: The task is being initialized.
            /// *   **LISTING**: The binary logs are being obtained.
            /// *   **LIST_SUCCESS**: The binary logs are successfully obtained.
            /// *   **DOWNLOADING**: The binary logs are being downloaded.
            /// *   **DOWNLOAD_FAIL**: The binary logs failed to be downloaded.
            /// *   **DOWNLOAD_SUCCESS**: The binary logs are successfully downloaded.
            /// *   **FILTERING**: The binary logs are being parsed.
            /// *   **FILTER_FAIL**: The binary logs failed to be parsed.
            /// *   **FILTER_SUCCESS**: The binary logs are successfully parsed.
            /// </summary>
            [NameInMap("JobStatus")]
            [Validation(Required=false)]
            public string JobStatus { get; set; }

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
            /// The name of the database.
            /// </summary>
            [NameInMap("SchemaName")]
            [Validation(Required=false)]
            public string SchemaName { get; set; }

            /// <summary>
            /// The description of the task status.
            /// </summary>
            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            /// <summary>
            /// The names of the tables for which data operations are tracked.
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public List<string> TableNames { get; set; }

            /// <summary>
            /// The types of data operations that are tracked.
            /// </summary>
            [NameInMap("TrackTypes")]
            [Validation(Required=false)]
            public List<string> TrackTypes { get; set; }

        }

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
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   **true**: The request was successful.
        /// *   **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
