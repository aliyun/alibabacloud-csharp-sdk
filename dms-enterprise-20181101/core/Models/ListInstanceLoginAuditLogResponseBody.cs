// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListInstanceLoginAuditLogResponseBody : TeaModel {
        /// <summary>
        /// The ID of the user.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The number of the page to return.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The database account that is used to log on to the instance.
        /// </summary>
        [NameInMap("InstanceLoginAuditLogList")]
        [Validation(Required=false)]
        public ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogList InstanceLoginAuditLogList { get; set; }
        public class ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogList : TeaModel {
            [NameInMap("InstanceLoginAuditLog")]
            [Validation(Required=false)]
            public List<ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogListInstanceLoginAuditLog> InstanceLoginAuditLog { get; set; }
            public class ListInstanceLoginAuditLogResponseBodyInstanceLoginAuditLogListInstanceLoginAuditLog : TeaModel {
                [NameInMap("DbUser")]
                [Validation(Required=false)]
                public string DbUser { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public long? InstanceId { get; set; }

                /// <summary>
                /// The ID of the request.
                /// </summary>
                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                /// <summary>
                /// The name of the instance.
                /// </summary>
                [NameInMap("OpTime")]
                [Validation(Required=false)]
                public string OpTime { get; set; }

                [NameInMap("RequestIp")]
                [Validation(Required=false)]
                public string RequestIp { get; set; }

                /// <summary>
                /// The source IP address of the request.
                /// </summary>
                [NameInMap("UserId")]
                [Validation(Required=false)]
                public long? UserId { get; set; }

                /// <summary>
                /// The alias of the user.
                /// </summary>
                [NameInMap("UserName")]
                [Validation(Required=false)]
                public string UserName { get; set; }

            }

        }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The beginning of the time range to query.
        /// 
        /// >  The start time supports fuzzy match. Specify the time in the YYYY-MM-DD hh:mm:ss format.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// The number of entries to return on each page. Maximum value: 100.
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
