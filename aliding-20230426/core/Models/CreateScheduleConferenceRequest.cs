// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class CreateScheduleConferenceRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687928400000L</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>预约会议设置</para>
        /// </summary>
        [NameInMap("ScheduleConfSettingModel")]
        [Validation(Required=false)]
        public CreateScheduleConferenceRequestScheduleConfSettingModel ScheduleConfSettingModel { get; set; }
        public class CreateScheduleConferenceRequestScheduleConfSettingModel : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("AiAgentSummarySetting")]
            [Validation(Required=false)]
            public CreateScheduleConferenceRequestScheduleConfSettingModelAiAgentSummarySetting AiAgentSummarySetting { get; set; }
            public class CreateScheduleConferenceRequestScheduleConfSettingModelAiAgentSummarySetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("AllowAllParticipantsStart")]
                [Validation(Required=false)]
                public int? AllowAllParticipantsStart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ReceiverType")]
                [Validation(Required=false)]
                public int? ReceiverType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RestrictShareMinutesSummaryOnly")]
                [Validation(Required=false)]
                public int? RestrictShareMinutesSummaryOnly { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>disable</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>[&quot;012345&quot;]</para>
            /// </summary>
            [NameInMap("CohostUserIds")]
            [Validation(Required=false)]
            public List<string> CohostUserIds { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>dingc02f685fa06381c44ac5d6980864d335</para>
            /// </summary>
            [NameInMap("ConfAllowedCorpId")]
            [Validation(Required=false)]
            public string ConfAllowedCorpId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
            /// </summary>
            [NameInMap("HostUserId")]
            [Validation(Required=false)]
            public string HostUserId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LockRoom")]
            [Validation(Required=false)]
            public int? LockRoom { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("MoziConfOpenRecordSetting")]
            [Validation(Required=false)]
            public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting MoziConfOpenRecordSetting { get; set; }
            public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfOpenRecordSetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsFollowHost")]
                [Validation(Required=false)]
                public bool? IsFollowHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>grid</para>
                /// </summary>
                [NameInMap("Mode")]
                [Validation(Required=false)]
                public string Mode { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RecordAutoStart")]
                [Validation(Required=false)]
                public int? RecordAutoStart { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RecordAutoStartType")]
                [Validation(Required=false)]
                public int? RecordAutoStartType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("RestrictShareMinutesSummaryOnly")]
                [Validation(Required=false)]
                public int? RestrictShareMinutesSummaryOnly { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("MoziConfVirtualExtraSetting")]
            [Validation(Required=false)]
            public CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting MoziConfVirtualExtraSetting { get; set; }
            public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSetting : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>2iPOLbpUNMLzB5LuwggiiqiPwiEiE</para>
                /// </summary>
                [NameInMap("CloudRecordOwnerUserId")]
                [Validation(Required=false)]
                public string CloudRecordOwnerUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("EnableChat")]
                [Validation(Required=false)]
                public int? EnableChat { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EnableWebAnonymousJoin")]
                [Validation(Required=false)]
                public bool? EnableWebAnonymousJoin { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("HiddenOwnerNick")]
                [Validation(Required=false)]
                public bool? HiddenOwnerNick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("JoinBeforeHost")]
                [Validation(Required=false)]
                public int? JoinBeforeHost { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockMediaStatusMicMute")]
                [Validation(Required=false)]
                public int? LockMediaStatusMicMute { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("LockNick")]
                [Validation(Required=false)]
                public int? LockNick { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("MinutesOwnerUserId")]
                [Validation(Required=false)]
                public string MinutesOwnerUserId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("MinutesSummaryDiyTemplateVersion")]
                [Validation(Required=false)]
                public string MinutesSummaryDiyTemplateVersion { get; set; }

                [NameInMap("MinutesSummaryTemplateId")]
                [Validation(Required=false)]
                public string MinutesSummaryTemplateId { get; set; }

                [NameInMap("MinutesSummaryTemplateType")]
                [Validation(Required=false)]
                public string MinutesSummaryTemplateType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>{}</para>
                /// </summary>
                [NameInMap("MoziConfExtensionAppSettings")]
                [Validation(Required=false)]
                public List<CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings> MoziConfExtensionAppSettings { get; set; }
                public class CreateScheduleConferenceRequestScheduleConfSettingModelMoziConfVirtualExtraSettingMoziConfExtensionAppSettings : TeaModel {
                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>0</para>
                    /// </summary>
                    [NameInMap("AutoOpenMode")]
                    [Validation(Required=false)]
                    public int? AutoOpenMode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxxx</para>
                    /// </summary>
                    [NameInMap("CoolAppCode")]
                    [Validation(Required=false)]
                    public string CoolAppCode { get; set; }

                    /// <summary>
                    /// <b>Example:</b>
                    /// <para>xxx</para>
                    /// </summary>
                    [NameInMap("ExtensionAppBizData")]
                    [Validation(Required=false)]
                    public string ExtensionAppBizData { get; set; }

                }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PushAllMeetingRecords")]
                [Validation(Required=false)]
                public bool? PushAllMeetingRecords { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PushCloudRecordCard")]
                [Validation(Required=false)]
                public bool? PushCloudRecordCard { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("PushMinutesCard")]
                [Validation(Required=false)]
                public bool? PushMinutesCard { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("WaitingRoom")]
                [Validation(Required=false)]
                public int? WaitingRoom { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("MuteOnJoin")]
            [Validation(Required=false)]
            public int? MuteOnJoin { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ScreenShareForbidden")]
            [Validation(Required=false)]
            public int? ScreenShareForbidden { get; set; }

        }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1687924800000L</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        [NameInMap("TenantContext")]
        [Validation(Required=false)]
        public CreateScheduleConferenceRequestTenantContext TenantContext { get; set; }
        public class CreateScheduleConferenceRequestTenantContext : TeaModel {
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
        /// <para>预约会议标题</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
