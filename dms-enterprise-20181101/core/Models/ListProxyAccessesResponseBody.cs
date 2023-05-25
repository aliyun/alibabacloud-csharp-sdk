// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListProxyAccessesResponseBody : TeaModel {
        /// <summary>
        /// The error code returned.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message returned.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The information about the users that are authorized to access the database instance by using the secure access proxy feature.
        /// </summary>
        [NameInMap("ProxyAccessList")]
        [Validation(Required=false)]
        public List<ListProxyAccessesResponseBodyProxyAccessList> ProxyAccessList { get; set; }
        public class ListProxyAccessesResponseBodyProxyAccessList : TeaModel {
            /// <summary>
            /// The username of the database account that is authorized to access the database instance by using the secure access proxy feature.
            /// </summary>
            [NameInMap("AccessId")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            /// <summary>
            /// The time when the user is authorized to access the database instance by using the secure access proxy feature.
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            /// <summary>
            /// The username of the independent database account.
            /// </summary>
            [NameInMap("IndepAccount")]
            [Validation(Required=false)]
            public string IndepAccount { get; set; }

            /// <summary>
            /// The ID of the database instance.
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public long? InstanceId { get; set; }

            /// <summary>
            /// The method that is used to authorize the user to access the database instance by using the secure access proxy feature. Valid values: 
            /// 
            /// - **Authorization by the Alibaba Cloud Account ()**: The information in the parentheses () indicates the user ID (UID) of the Alibaba Cloud account.
            /// - **Authorization by submitting the ticket ()**:The information in the parentheses () indicates the number of the ticket that the user submits to apply for permissions.
            /// </summary>
            [NameInMap("OriginInfo")]
            [Validation(Required=false)]
            public string OriginInfo { get; set; }

            /// <summary>
            /// The ID that DMS generates after the user is authorized to access the database instance by using the secure access proxy feature. The ID is unique in DMS.
            /// </summary>
            [NameInMap("ProxyAccessId")]
            [Validation(Required=false)]
            public long? ProxyAccessId { get; set; }

            /// <summary>
            /// The ID of the secure access proxy.
            /// </summary>
            [NameInMap("ProxyId")]
            [Validation(Required=false)]
            public long? ProxyId { get; set; }

            /// <summary>
            /// The ID of the user.
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }

            /// <summary>
            /// The nickname of the user.
            /// </summary>
            [NameInMap("UserName")]
            [Validation(Required=false)]
            public string UserName { get; set; }

            /// <summary>
            /// The UID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("UserUid")]
            [Validation(Required=false)]
            public string UserUid { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// - **true**: The request was successful.
        /// - **false**: The request failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
