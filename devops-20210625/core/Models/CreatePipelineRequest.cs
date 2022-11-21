// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreatePipelineRequest : TeaModel {
        [NameInMap("basicInfo")]
        [Validation(Required=false)]
        public CreatePipelineRequestBasicInfo BasicInfo { get; set; }
        public class CreatePipelineRequestBasicInfo : TeaModel {
            [NameInMap("envId")]
            [Validation(Required=false)]
            public long? EnvId { get; set; }

            [NameInMap("groupId")]
            [Validation(Required=false)]
            public long? GroupId { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("tagIds")]
            [Validation(Required=false)]
            public string TagIds { get; set; }

        }

        [NameInMap("pipelineYaml")]
        [Validation(Required=false)]
        public string PipelineYaml { get; set; }

        [NameInMap("settings")]
        [Validation(Required=false)]
        public CreatePipelineRequestSettings Settings { get; set; }
        public class CreatePipelineRequestSettings : TeaModel {
            [NameInMap("caches")]
            [Validation(Required=false)]
            public List<CreatePipelineRequestSettingsCaches> Caches { get; set; }
            public class CreatePipelineRequestSettingsCaches : TeaModel {
                [NameInMap("desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                [NameInMap("directory")]
                [Validation(Required=false)]
                public string Directory { get; set; }

                [NameInMap("disable")]
                [Validation(Required=false)]
                public bool? Disable { get; set; }

            }

            [NameInMap("globalParams")]
            [Validation(Required=false)]
            public List<CreatePipelineRequestSettingsGlobalParams> GlobalParams { get; set; }
            public class CreatePipelineRequestSettingsGlobalParams : TeaModel {
                [NameInMap("key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                [NameInMap("mask")]
                [Validation(Required=false)]
                public bool? Mask { get; set; }

                [NameInMap("runningConfig")]
                [Validation(Required=false)]
                public bool? RunningConfig { get; set; }

                [NameInMap("value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            [NameInMap("runnerCacheMode")]
            [Validation(Required=false)]
            public string RunnerCacheMode { get; set; }

        }

        [NameInMap("triggerInfo")]
        [Validation(Required=false)]
        public CreatePipelineRequestTriggerInfo TriggerInfo { get; set; }
        public class CreatePipelineRequestTriggerInfo : TeaModel {
            [NameInMap("scheduled")]
            [Validation(Required=false)]
            public CreatePipelineRequestTriggerInfoScheduled Scheduled { get; set; }
            public class CreatePipelineRequestTriggerInfoScheduled : TeaModel {
                [NameInMap("daysOfWeek")]
                [Validation(Required=false)]
                public string DaysOfWeek { get; set; }

                [NameInMap("fixedTime")]
                [Validation(Required=false)]
                public string FixedTime { get; set; }

                [NameInMap("from")]
                [Validation(Required=false)]
                public string From { get; set; }

                [NameInMap("interval")]
                [Validation(Required=false)]
                public int? Interval { get; set; }

                [NameInMap("onlySourceChange")]
                [Validation(Required=false)]
                public bool? OnlySourceChange { get; set; }

                [NameInMap("to")]
                [Validation(Required=false)]
                public string To { get; set; }

                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("webhookEnable")]
            [Validation(Required=false)]
            public bool? WebhookEnable { get; set; }

        }

    }

}
