// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaPendingDesktopsResponseBody : TeaModel {
        /// <summary>
        /// The response code.
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// The cloud computers whose images can be and are pending to be updated to the version specified in `TaskUid`.
        /// </summary>
        [NameInMap("FotaPendingDesktops")]
        [Validation(Required=false)]
        public List<DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops> FotaPendingDesktops { get; set; }
        public class DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops : TeaModel {
            /// <summary>
            /// The current version of the image used by the cloud computer.
            /// </summary>
            [NameInMap("CurrentAppVersion")]
            [Validation(Required=false)]
            public string CurrentAppVersion { get; set; }

            /// <summary>
            /// The ID of the cloud computer.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The name of the cloud computer.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            /// <summary>
            /// > This parameter is not publicly available.
            /// </summary>
            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            /// <summary>
            /// The ID of the office network.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            /// <summary>
            /// The connected sessions.
            /// </summary>
            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktopsSessions> Sessions { get; set; }
            public class DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktopsSessions : TeaModel {
                /// <summary>
                /// The ID of the end user that connects to the cloud computer.
                /// </summary>
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

            }

            /// <summary>
            /// The status of the cloud computer.
            /// 
            /// Valid values:
            /// 
            /// *   0: The cloud computer is being created.
            /// *   1: The cloud computer is being started.
            /// *   2: The cloud computer is running.
            /// *   3: The cloud computer is being stopped.
            /// *   5: The cloud computer is stopped.
            /// *   6: The cloud computer expires.
            /// *   7: The cloud computer is deleted.
            /// *   9: Failed to create the cloud computer.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        /// <summary>
        /// The returned message.
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// A pagination token. It can be used in the next request to retrieve a new page of results. If NextToken is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
