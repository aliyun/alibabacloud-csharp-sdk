// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateVideoConferenceSettingShrinkRequest : TeaModel {
        [NameInMap("AllowUnmuteSelf")]
        [Validation(Required=false)]
        public bool? AllowUnmuteSelf { get; set; }

        [NameInMap("AutoTransferHost")]
        [Validation(Required=false)]
        public bool? AutoTransferHost { get; set; }

        [NameInMap("ForbiddenShareScreen")]
        [Validation(Required=false)]
        public bool? ForbiddenShareScreen { get; set; }

        [NameInMap("LockConference")]
        [Validation(Required=false)]
        public bool? LockConference { get; set; }

        [NameInMap("MuteAll")]
        [Validation(Required=false)]
        public bool? MuteAll { get; set; }

        [NameInMap("OnlyInternalEmployeesJoin")]
        [Validation(Required=false)]
        public bool? OnlyInternalEmployeesJoin { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public string TenantContextShrink { get; set; }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

    }

}
