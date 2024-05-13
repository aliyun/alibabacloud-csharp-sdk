// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateDataTrackOrderRequest : TeaModel {
        /// <summary>
        /// The purpose or objective of the data tracking ticket. This parameter is used to help reduce unnecessary communication.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The parameters of the ticket.
        /// 
        /// This parameter is required.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public CreateDataTrackOrderRequestParam Param { get; set; }
        public class CreateDataTrackOrderRequestParam : TeaModel {
            /// <summary>
            /// The ID of the database. You can call the [SearchDatabases](https://help.aliyun.com/document_detail/141876.html) operation to query the ID of the database.
            /// 
            /// > You can call this operation to create a data tracking ticket for only physical databases. This operation is not applicable to logical databases.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public string DbId { get; set; }

            /// <summary>
            /// The end time of the time range in which you want to track data operations. The time must be in the yyyy-MM-dd HH:mm:ss format.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("JobEndTime")]
            [Validation(Required=false)]
            public string JobEndTime { get; set; }

            /// <summary>
            /// The start time of the time range in which you want to track data operations. The time must be in the yyyy-MM-dd HH:mm:ss format.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("JobStartTime")]
            [Validation(Required=false)]
            public string JobStartTime { get; set; }

            /// <summary>
            /// The names of the tables for which you want to track data operations.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TableNames")]
            [Validation(Required=false)]
            public List<string> TableNames { get; set; }

            /// <summary>
            /// The types of data operations that you want to track.
            /// 
            /// This parameter is required.
            /// </summary>
            [NameInMap("TrackTypes")]
            [Validation(Required=false)]
            public List<string> TrackTypes { get; set; }

        }

        /// <summary>
        /// The IDs of the operators that are related to the ticket.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public List<string> RelatedUserList { get; set; }

        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](https://help.aliyun.com/document_detail/198073.html) operation to query the tenant ID.
        /// </summary>
        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
