// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class RestoreMediaResponseBody : TeaModel {
        /// <summary>
        /// The IDs of the media asset that failed to be processed.
        /// </summary>
        [NameInMap("ForbiddenList")]
        [Validation(Required=false)]
        public RestoreMediaResponseBodyForbiddenList ForbiddenList { get; set; }
        public class RestoreMediaResponseBodyForbiddenList : TeaModel {
            [NameInMap("MediaForbiddenReasonDTO")]
            [Validation(Required=false)]
            public List<RestoreMediaResponseBodyForbiddenListMediaForbiddenReasonDTO> MediaForbiddenReasonDTO { get; set; }
            public class RestoreMediaResponseBodyForbiddenListMediaForbiddenReasonDTO : TeaModel {
                /// <summary>
                /// The ID of the media asset.
                /// </summary>
                [NameInMap("MediaId")]
                [Validation(Required=false)]
                public string MediaId { get; set; }

                /// <summary>
                /// The reason for the failure.
                /// </summary>
                [NameInMap("Reason")]
                [Validation(Required=false)]
                public string Reason { get; set; }

            }

        }

        /// <summary>
        /// The IDs of the media assets that failed to be obtained.
        /// </summary>
        [NameInMap("IgnoredList")]
        [Validation(Required=false)]
        public RestoreMediaResponseBodyIgnoredList IgnoredList { get; set; }
        public class RestoreMediaResponseBodyIgnoredList : TeaModel {
            [NameInMap("MediaId")]
            [Validation(Required=false)]
            public List<string> MediaId { get; set; }

        }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
