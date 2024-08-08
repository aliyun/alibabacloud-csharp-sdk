/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiAutoML20220828.Models
{
    public class AutofeExperimentConfiguration : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("odps_config")]
        [Validation(Required=false)]
        public AutofeExperimentConfigurationOdpsConfig OdpsConfig { get; set; }
        public class AutofeExperimentConfigurationOdpsConfig : TeaModel {
            [NameInMap("odps_access_id")]
            [Validation(Required=false)]
            public string OdpsAccessId { get; set; }

            [NameInMap("odps_access_key")]
            [Validation(Required=false)]
            public string OdpsAccessKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("odps_endpoint")]
            [Validation(Required=false)]
            public string OdpsEndpoint { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("odps_project_name")]
            [Validation(Required=false)]
            public string OdpsProjectName { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("odps_region_id")]
            [Validation(Required=false)]
            public string OdpsRegionId { get; set; }

            [NameInMap("odps_role_arn")]
            [Validation(Required=false)]
            public string OdpsRoleArn { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("oss_config")]
        [Validation(Required=false)]
        public AutofeExperimentConfigurationOssConfig OssConfig { get; set; }
        public class AutofeExperimentConfigurationOssConfig : TeaModel {
            [NameInMap("oss_access_id")]
            [Validation(Required=false)]
            public string OssAccessId { get; set; }

            [NameInMap("oss_access_key")]
            [Validation(Required=false)]
            public string OssAccessKey { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("oss_bucket")]
            [Validation(Required=false)]
            public string OssBucket { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("oss_endpoint")]
            [Validation(Required=false)]
            public string OssEndpoint { get; set; }

            [NameInMap("oss_role_arn")]
            [Validation(Required=false)]
            public string OssRoleArn { get; set; }

        }

        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("yml_config")]
        [Validation(Required=false)]
        public AutofeExperimentConfigurationYmlConfig YmlConfig { get; set; }
        public class AutofeExperimentConfigurationYmlConfig : TeaModel {
            [NameInMap("action")]
            [Validation(Required=false)]
            public string Action { get; set; }

            [NameInMap("aggregate_only")]
            [Validation(Required=false)]
            public string AggregateOnly { get; set; }

            [NameInMap("analyze_exp_id")]
            [Validation(Required=false)]
            public string AnalyzeExpId { get; set; }

            [NameInMap("cpu")]
            [Validation(Required=false)]
            public string Cpu { get; set; }

            [NameInMap("data_partition")]
            [Validation(Required=false)]
            public string DataPartition { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("data_source")]
            [Validation(Required=false)]
            public string DataSource { get; set; }

            [NameInMap("data_type")]
            [Validation(Required=false)]
            public string DataType { get; set; }

            [NameInMap("debug_mode")]
            [Validation(Required=false)]
            public string DebugMode { get; set; }

            [NameInMap("exclude_columns")]
            [Validation(Required=false)]
            public string ExcludeColumns { get; set; }

            [NameInMap("feature_selection")]
            [Validation(Required=false)]
            public string FeatureSelection { get; set; }

            [NameInMap("filter_thresh")]
            [Validation(Required=false)]
            public string FilterThresh { get; set; }

            [NameInMap("iv_thresh")]
            [Validation(Required=false)]
            public string IvThresh { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("label")]
            [Validation(Required=false)]
            public string Label { get; set; }

            [NameInMap("memory")]
            [Validation(Required=false)]
            public string Memory { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("output_config_oss_dir")]
            [Validation(Required=false)]
            public string OutputConfigOssDir { get; set; }

            [NameInMap("pipeline_exp_id")]
            [Validation(Required=false)]
            public string PipelineExpId { get; set; }

            [NameInMap("reuse_results")]
            [Validation(Required=false)]
            public string ReuseResults { get; set; }

            [NameInMap("sample_ratio")]
            [Validation(Required=false)]
            public string SampleRatio { get; set; }

            [NameInMap("sample_size")]
            [Validation(Required=false)]
            public string SampleSize { get; set; }

            [NameInMap("selection_exp_id")]
            [Validation(Required=false)]
            public string SelectionExpId { get; set; }

            [NameInMap("skip_select")]
            [Validation(Required=false)]
            public string SkipSelect { get; set; }

            [NameInMap("workers")]
            [Validation(Required=false)]
            public string Workers { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("workspace_name")]
            [Validation(Required=false)]
            public string WorkspaceName { get; set; }

        }

    }

}
