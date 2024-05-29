// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class UpdateScheduleConfSettingsRequest : TeaModel {
        [NameInMap("ScheduleConfSettingModel")]
        [Validation(Required=false)]
        public UpdateScheduleConfSettingsRequestScheduleConfSettingModel ScheduleConfSettingModel { get; set; }
        public class UpdateScheduleConfSettingsRequestScheduleConfSettingModel : TeaModel {
            [NameInMap("CohostUserIds")]
            [Validation(Required=false)]
            public List<string> CohostUserIds { get; set; }

            [NameInMap("ConfAllowedCorpId")]
            [Validation(Required=false)]
            public string ConfAllowedCorpId { get; set; }

            [NameInMap("HostUserId")]
            [Validation(Required=false)]
            public string HostUserId { get; set; }

            [NameInMap("LockRoom")]
            [Validation(Required=false)]
            public int? LockRoom { get; set; }

            [NameInMap("MoziConfVirtualExtraSetting")]
            [Validation(Required=false)]
            public UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting MoziConfVirtualExtraSetting { get; set; }
            public class UpdateScheduleConfSettingsRequestScheduleConfSettingModelMoziConfVirtualExtraSetting : TeaModel {
                [NameInMap("CloudRecordOwnerUserId")]
                [Validation(Required=false)]
                public string CloudRecordOwnerUserId { get; set; }

                [NameInMap("EnableChat")]
                [Validation(Required=false)]
                public int? EnableChat { get; set; }

                [NameInMap("EnableWebAnonymousJoin")]
                [Validation(Required=false)]
                public bool? EnableWebAnonymousJoin { get; set; }

                [NameInMap("JoinBeforeHost")]
                [Validation(Required=false)]
                public int? JoinBeforeHost { get; set; }

                [NameInMap("LockMediaStatusMicMute")]
                [Validation(Required=false)]
                public int? LockMediaStatusMicMute { get; set; }

                [NameInMap("LockNick")]
                [Validation(Required=false)]
                public int? LockNick { get; set; }

                [NameInMap("MinutesOwnerUserId")]
                [Validation(Required=false)]
                public string MinutesOwnerUserId { get; set; }

                [NameInMap("PushAllMeetingRecords")]
                [Validation(Required=false)]
                public bool? PushAllMeetingRecords { get; set; }

                [NameInMap("PushCloudRecordCard")]
                [Validation(Required=false)]
                public bool? PushCloudRecordCard { get; set; }

                [NameInMap("PushMinutesCard")]
                [Validation(Required=false)]
                public bool? PushMinutesCard { get; set; }

                [NameInMap("WaitingRoom")]
                [Validation(Required=false)]
                public int? WaitingRoom { get; set; }

            }

            [NameInMap("MuteOnJoin")]
            [Validation(Required=false)]
            public int? MuteOnJoin { get; set; }

            [NameInMap("ScreenShareForbidden")]
            [Validation(Required=false)]
            public int? ScreenShareForbidden { get; set; }

        }

        [NameInMap("ScheduleConferenceId")]
        [Validation(Required=false)]
        public string ScheduleConferenceId { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public UpdateScheduleConfSettingsRequestTenantContext TenantContext { get; set; }
        public class UpdateScheduleConfSettingsRequestTenantContext : TeaModel {
            [NameInMap("tenantId")]
            [Validation(Required=false)]
            public string TenantId { get; set; }

        }

    }

}
