// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryGuidTaskListResponseBody : TeaModel {
        /// <summary>
        /// The list of beginner tasks.
        /// </summary>
        [NameInMap("GuideTaskConfigList")]
        [Validation(Required=false)]
        public List<QueryGuidTaskListResponseBodyGuideTaskConfigList> GuideTaskConfigList { get; set; }
        public class QueryGuidTaskListResponseBodyGuideTaskConfigList : TeaModel {
            /// <summary>
            /// The information about the reward for a complete task.
            /// </summary>
            [NameInMap("RewardData")]
            [Validation(Required=false)]
            public QueryGuidTaskListResponseBodyGuideTaskConfigListRewardData RewardData { get; set; }
            public class QueryGuidTaskListResponseBodyGuideTaskConfigListRewardData : TeaModel {
                /// <summary>
                /// Indicates whether the reward is claimed. Valid values:
                /// 
                /// *   **1**: no.
                /// *   **2**: yes.
                /// </summary>
                [NameInMap("IsRewardTaked")]
                [Validation(Required=false)]
                public string IsRewardTaked { get; set; }

                /// <summary>
                /// The name of the reward. Valid values:
                /// 
                /// *   **addTrialDay**: the days of trial use.
                /// *   **addAntiRansomwareCapacity**: the anti-ransomware capacity.
                /// *   **addImageScanAuthCount**: the quota for container image scan.
                /// *   **addWebLockAuthCount**: the quota for web tamper proofing.
                /// *   **addSlsCapacity**: the log storage capacity.
                /// </summary>
                [NameInMap("Reward")]
                [Validation(Required=false)]
                public string Reward { get; set; }

                /// <summary>
                /// The reward configuration. The value of this parameter is in the JSON format.
                /// 
                /// >  The key indicates the reward type, and the value indicates the number of rewards. Valid values of key:
                /// 
                /// *   **webLockAuthCount**: the quota for web tamper proofing.
                /// *   **webLockAuthCount**: the anti-ransomware capacity. Unit: GB.
                /// *   **slsCapacity**: the log storage capacity. Unit: GB.
                /// *   **days**: the days of trial use.
                /// *   **imageScanAuthCount**: the quota for container image scan.
                /// *   **honeypotAuthCount**: the quota for cloud honeypot.
                /// </summary>
                [NameInMap("RewardConfig")]
                [Validation(Required=false)]
                public string RewardConfig { get; set; }

            }

            /// <summary>
            /// The security score that is increased after you complete the task.
            /// </summary>
            [NameInMap("SecurityScore")]
            [Validation(Required=false)]
            public int? SecurityScore { get; set; }

            /// <summary>
            /// The status of the beginner task. Valid values:
            /// 
            /// *   **0**: disabled.
            /// *   **1**: in progress.
            /// *   **2**: complete.
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// The ID of the beginner task.
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// The name of the task type. Valid values:
            /// 
            /// *   **guid_task_security_score_promote_video**: the task of viewing a video tutorial for beginners.
            /// *   **guide_sub_task_config_defence_hbr**: the task of configuring anti-ransomware for servers.
            /// *   **guide_sub_task_config_uni_defence_hbr**: the task of configuring anti-ransomware for databases.
            /// *   **guid_task_log_analysis_config**: the task of configuring log analysis.
            /// *   **guide_sub_task_web_lock_config**: the task of configuring web tamper proofing.
            /// *   **guide_sub_task_config_anti_crack**: the task of configuring protection against brute-force attacks.
            /// *   **guid_task_container_security_video**: the task of viewing the video on how to protect containers.
            /// *   **guid_task_container_image_scan_config**: the task of configuring container image scan.
            /// *   **guid_task_k8s_log_analysis_config**: the task of configuring threat detection on Kubernetes containers.
            /// *   **guid_task_container_network**: the task of configuring container network visualization.
            /// *   **guide_sub_task_config_add_collection**: the task of saving a console URL.
            /// *   **guide_sub_task_vul_scan**: the task of scanning for vulnerabilities.
            /// *   **guide_sub_task_virusKill**: the task of configuring virus detection and removal.
            /// </summary>
            [NameInMap("TaskTypeName")]
            [Validation(Required=false)]
            public string TaskTypeName { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
