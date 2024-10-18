// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateVideoConferenceSettingRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AllowUnmuteSelf")]
        [Validation(Required=false)]
        public bool? AllowUnmuteSelf { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AutoTransferHost")]
        [Validation(Required=false)]
        public bool? AutoTransferHost { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForbiddenShareScreen")]
        [Validation(Required=false)]
        public bool? ForbiddenShareScreen { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("LockConference")]
        [Validation(Required=false)]
        public bool? LockConference { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("MuteAll")]
        [Validation(Required=false)]
        public bool? MuteAll { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("OnlyInternalEmployeesJoin")]
        [Validation(Required=false)]
        public bool? OnlyInternalEmployeesJoin { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateVideoConferenceSettingRequestTenantContext TenantContext { get; set; }
        public class UpdateVideoConferenceSettingRequestTenantContext : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>xxxxxx</para>
            /// </summary>
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>61289fxxx</para>
        /// </summary>
        [NameInMap("conferenceId")]
        [Validation(Required=false)]
        public string ConferenceId { get; set; }

    }

}
