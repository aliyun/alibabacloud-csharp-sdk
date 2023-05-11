// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Iot20180120.Models
{
    public class QuerySuperDeviceGroupResponseBody : TeaModel {
        /// <summary>
        /// The error code returned if the call fails. For more information, see [Error codes](~~87387~~).
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The parent group information returned if the call succeeds. For more information, see the following **GroupInfo** parameter.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public QuerySuperDeviceGroupResponseBodyData Data { get; set; }
        public class QuerySuperDeviceGroupResponseBodyData : TeaModel {
            [NameInMap("GroupInfo")]
            [Validation(Required=false)]
            public List<QuerySuperDeviceGroupResponseBodyDataGroupInfo> GroupInfo { get; set; }
            public class QuerySuperDeviceGroupResponseBodyDataGroupInfo : TeaModel {
                /// <summary>
                /// The description of the parent group.
                /// </summary>
                [NameInMap("GroupDesc")]
                [Validation(Required=false)]
                public string GroupDesc { get; set; }

                /// <summary>
                /// The ID of the parent group.
                /// </summary>
                [NameInMap("GroupId")]
                [Validation(Required=false)]
                public string GroupId { get; set; }

                /// <summary>
                /// The name of the parent group.
                /// </summary>
                [NameInMap("GroupName")]
                [Validation(Required=false)]
                public string GroupName { get; set; }

            }

        }

        /// <summary>
        /// The error message returned if the call fails.
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
        /// Indicates whether the call was successful.
        /// 
        /// *   **true**: The call was successful.
        /// *   **false**: The call failed.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
