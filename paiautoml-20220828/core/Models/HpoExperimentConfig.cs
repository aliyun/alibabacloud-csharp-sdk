// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class HpoExperimentConfig : TeaModel {
        [NameInMap("dlc_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigDlcConfig DlcConfig { get; set; }
        public class HpoExperimentConfigDlcConfig : TeaModel {
            [NameInMap("access_id")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            [NameInMap("access_key")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("protocol")]
            [Validation(Required=false)]
            public string Protocol { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

        }

        [NameInMap("k8s_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigK8sConfig K8sConfig { get; set; }
        public class HpoExperimentConfigK8sConfig : TeaModel {
            [NameInMap("nni_container_cpu_limit")]
            [Validation(Required=false)]
            public string NniContainerCpuLimit { get; set; }

            [NameInMap("nni_container_memory_limit")]
            [Validation(Required=false)]
            public string NniContainerMemoryLimit { get; set; }

            [NameInMap("nni_container_requested_cpu")]
            [Validation(Required=false)]
            public string NniContainerRequestedCpu { get; set; }

            [NameInMap("nni_container_requested_memory")]
            [Validation(Required=false)]
            public string NniContainerRequestedMemory { get; set; }

        }

        [NameInMap("metric_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigMetricConfig MetricConfig { get; set; }
        public class HpoExperimentConfigMetricConfig : TeaModel {
            [NameInMap("final_mode")]
            [Validation(Required=false)]
            public string FinalMode { get; set; }

            [NameInMap("metric_dict")]
            [Validation(Required=false)]
            public Dictionary<string, object> MetricDict { get; set; }

            [NameInMap("metric_source")]
            [Validation(Required=false)]
            public List<string> MetricSource { get; set; }

            [NameInMap("metric_type")]
            [Validation(Required=false)]
            public string MetricType { get; set; }

            [NameInMap("source_list_final_mode")]
            [Validation(Required=false)]
            public string SourceListFinalMode { get; set; }

        }

        [NameInMap("monitor_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigMonitorConfig MonitorConfig { get; set; }
        public class HpoExperimentConfigMonitorConfig : TeaModel {
            [NameInMap("at_mobiles")]
            [Validation(Required=false)]
            public string AtMobiles { get; set; }

            [NameInMap("at_user_ids")]
            [Validation(Required=false)]
            public string AtUserIds { get; set; }

            [NameInMap("is_at_all")]
            [Validation(Required=false)]
            public string IsAtAll { get; set; }

            [NameInMap("keyword")]
            [Validation(Required=false)]
            public string Keyword { get; set; }

            [NameInMap("url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("odps_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigOdpsConfig OdpsConfig { get; set; }
        public class HpoExperimentConfigOdpsConfig : TeaModel {
            [NameInMap("access_id")]
            [Validation(Required=false)]
            public string AccessId { get; set; }

            [NameInMap("access_key")]
            [Validation(Required=false)]
            public string AccessKey { get; set; }

            [NameInMap("end_point")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            [NameInMap("log_view_host")]
            [Validation(Required=false)]
            public string LogViewHost { get; set; }

            [NameInMap("project_name")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("role_arn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

        }

        [NameInMap("oss_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigOssConfig OssConfig { get; set; }
        public class HpoExperimentConfigOssConfig : TeaModel {
            [NameInMap("accessKeyID")]
            [Validation(Required=false)]
            public string AccessKeyID { get; set; }

            [NameInMap("accessKeySecret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("role_arn")]
            [Validation(Required=false)]
            public string RoleArn { get; set; }

        }

        [NameInMap("output_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigOutputConfig OutputConfig { get; set; }
        public class HpoExperimentConfigOutputConfig : TeaModel {
            [NameInMap("model_path")]
            [Validation(Required=false)]
            public string ModelPath { get; set; }

            [NameInMap("summary_path")]
            [Validation(Required=false)]
            public string SummaryPath { get; set; }

        }

        [NameInMap("paiflow_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigPaiflowConfig PaiflowConfig { get; set; }
        public class HpoExperimentConfigPaiflowConfig : TeaModel {
            [NameInMap("access_key_id")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("access_key_secret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("workspace_id")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

        [NameInMap("params_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigParamsConfig ParamsConfig { get; set; }
        public class HpoExperimentConfigParamsConfig : TeaModel {
            [NameInMap("params_src_dst_filepath")]
            [Validation(Required=false)]
            public List<string> ParamsSrcDstFilepath { get; set; }

        }

        [NameInMap("platform_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigPlatformConfig PlatformConfig { get; set; }
        public class HpoExperimentConfigPlatformConfig : TeaModel {
            [NameInMap("cmd")]
            [Validation(Required=false)]
            public List<string> Cmd { get; set; }

            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("resume")]
            [Validation(Required=false)]
            public string Resume { get; set; }

        }

        [NameInMap("schedule_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigScheduleConfig ScheduleConfig { get; set; }
        public class HpoExperimentConfigScheduleConfig : TeaModel {
            [NameInMap("day")]
            [Validation(Required=false)]
            public string Day { get; set; }

            [NameInMap("end_time")]
            [Validation(Required=false)]
            public string EndTime { get; set; }

            [NameInMap("start_time")]
            [Validation(Required=false)]
            public string StartTime { get; set; }

        }

        [NameInMap("search_space")]
        [Validation(Required=false)]
        public Dictionary<string, object> SearchSpace { get; set; }

        [NameInMap("ts_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigTsConfig TsConfig { get; set; }
        public class HpoExperimentConfigTsConfig : TeaModel {
            [NameInMap("access_key_id")]
            [Validation(Required=false)]
            public string AccessKeyId { get; set; }

            [NameInMap("access_key_secret")]
            [Validation(Required=false)]
            public string AccessKeySecret { get; set; }

            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            [NameInMap("region_id")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        [NameInMap("yml_config")]
        [Validation(Required=false)]
        public HpoExperimentConfigYmlConfig YmlConfig { get; set; }
        public class HpoExperimentConfigYmlConfig : TeaModel {
            [NameInMap("assessor")]
            [Validation(Required=false)]
            public HpoExperimentConfigYmlConfigAssessor Assessor { get; set; }
            public class HpoExperimentConfigYmlConfigAssessor : TeaModel {
                [NameInMap("class_args")]
                [Validation(Required=false)]
                public HpoExperimentConfigYmlConfigAssessorClassArgs ClassArgs { get; set; }
                public class HpoExperimentConfigYmlConfigAssessorClassArgs : TeaModel {
                    [NameInMap("earlystop")]
                    [Validation(Required=false)]
                    public bool? Earlystop { get; set; }

                    [NameInMap("moving_avg")]
                    [Validation(Required=false)]
                    public string MovingAvg { get; set; }

                    [NameInMap("optimize_mode")]
                    [Validation(Required=false)]
                    public string OptimizeMode { get; set; }

                    [NameInMap("proportion")]
                    [Validation(Required=false)]
                    public float? Proportion { get; set; }

                    [NameInMap("start_step")]
                    [Validation(Required=false)]
                    public int? StartStep { get; set; }

                }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("debug")]
            [Validation(Required=false)]
            public bool? Debug { get; set; }

            [NameInMap("experiment_name")]
            [Validation(Required=false)]
            public string ExperimentName { get; set; }

            [NameInMap("log_level")]
            [Validation(Required=false)]
            public string LogLevel { get; set; }

            [NameInMap("max_trial_number")]
            [Validation(Required=false)]
            public int? MaxTrialNumber { get; set; }

            [NameInMap("trial_concurrency")]
            [Validation(Required=false)]
            public int? TrialConcurrency { get; set; }

            [NameInMap("tuner")]
            [Validation(Required=false)]
            public HpoExperimentConfigYmlConfigTuner Tuner { get; set; }
            public class HpoExperimentConfigYmlConfigTuner : TeaModel {
                [NameInMap("class_args")]
                [Validation(Required=false)]
                public Dictionary<string, object> ClassArgs { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

    }

}
