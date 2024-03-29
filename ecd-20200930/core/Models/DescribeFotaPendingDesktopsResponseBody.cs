// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DescribeFotaPendingDesktopsResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Details about the cloud desktops whose images can be but are not yet updated to the version that is described in an image update task (TaskUid).
        /// </summary>
        [NameInMap("FotaPendingDesktops")]
        [Validation(Required=false)]
        public List<DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops> FotaPendingDesktops { get; set; }
        public class DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktops : TeaModel {
            /// <summary>
            /// The current version of the image used by the cloud desktop.
            /// </summary>
            [NameInMap("CurrentAppVersion")]
            [Validation(Required=false)]
            public string CurrentAppVersion { get; set; }

            /// <summary>
            /// The cloud desktop ID.
            /// </summary>
            [NameInMap("DesktopId")]
            [Validation(Required=false)]
            public string DesktopId { get; set; }

            /// <summary>
            /// The cloud desktop name.
            /// </summary>
            [NameInMap("DesktopName")]
            [Validation(Required=false)]
            public string DesktopName { get; set; }

            [NameInMap("FotaProject")]
            [Validation(Required=false)]
            public string FotaProject { get; set; }

            /// <summary>
            /// The workspace ID.
            /// </summary>
            [NameInMap("OfficeSiteId")]
            [Validation(Required=false)]
            public string OfficeSiteId { get; set; }

            [NameInMap("Sessions")]
            [Validation(Required=false)]
            public List<DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktopsSessions> Sessions { get; set; }
            public class DescribeFotaPendingDesktopsResponseBodyFotaPendingDesktopsSessions : TeaModel {
                [NameInMap("EndUserId")]
                [Validation(Required=false)]
                public string EndUserId { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// The pagination token that is used in the next request to retrieve a new page of results. If the NextToken parameter is empty, no next page exists.
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
