// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryGuidTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of beginner tasks.</para>
        /// </summary>
        [NameInMap("GuideTaskConfigList")]
        [Validation(Required=false)]
        public List<QueryGuidTaskListResponseBodyGuideTaskConfigList> GuideTaskConfigList { get; set; }
        public class QueryGuidTaskListResponseBodyGuideTaskConfigList : TeaModel {
            /// <summary>
            /// <para>The information about the reward for a complete task.</para>
            /// </summary>
            [NameInMap("RewardData")]
            [Validation(Required=false)]
            public QueryGuidTaskListResponseBodyGuideTaskConfigListRewardData RewardData { get; set; }
            public class QueryGuidTaskListResponseBodyGuideTaskConfigListRewardData : TeaModel {
                /// <summary>
                /// <para>Indicates whether the reward is claimed. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: no.</description></item>
                /// <item><description><b>2</b>: yes.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsRewardTaked")]
                [Validation(Required=false)]
                public string IsRewardTaked { get; set; }

                /// <summary>
                /// <para>The name of the reward. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>addTrialDay</b>: the days of trial use.</description></item>
                /// <item><description><b>addAntiRansomwareCapacity</b>: the anti-ransomware capacity.</description></item>
                /// <item><description><b>addImageScanAuthCount</b>: the quota for container image scan.</description></item>
                /// <item><description><b>addWebLockAuthCount</b>: the quota for web tamper proofing.</description></item>
                /// <item><description><b>addSlsCapacity</b>: the log storage capacity.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>addWebLockAuthCount</para>
                /// </summary>
                [NameInMap("Reward")]
                [Validation(Required=false)]
                public string Reward { get; set; }

                /// <summary>
                /// <para>The reward configuration. The value of this parameter is in the JSON format.</para>
                /// <remarks>
                /// <para> The key indicates the reward type, and the value indicates the number of rewards. Valid values of key:</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>webLockAuthCount</b>: the quota for web tamper proofing.</description></item>
                /// <item><description><b>webLockAuthCount</b>: the anti-ransomware capacity. Unit: GB.</description></item>
                /// <item><description><b>slsCapacity</b>: the log storage capacity. Unit: GB.</description></item>
                /// <item><description><b>days</b>: the days of trial use.</description></item>
                /// <item><description><b>imageScanAuthCount</b>: the quota for container image scan.</description></item>
                /// <item><description><b>honeypotAuthCount</b>: the quota for cloud honeypot.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;days&quot;:60,&quot;ransomwareCapacity&quot;:100}</para>
                /// </summary>
                [NameInMap("RewardConfig")]
                [Validation(Required=false)]
                public string RewardConfig { get; set; }

            }

            /// <summary>
            /// <para>The security score that is increased after you complete the task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SecurityScore")]
            [Validation(Required=false)]
            public int? SecurityScore { get; set; }

            /// <summary>
            /// <para>The status of the beginner task. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: disabled.</description></item>
            /// <item><description><b>1</b>: in progress.</description></item>
            /// <item><description><b>2</b>: complete.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The ID of the beginner task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-000d8slfgx4p40kb64ad</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// <para>The name of the task type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>guid_task_security_score_promote_video</b>: the task of viewing a video tutorial for beginners.</description></item>
            /// <item><description><b>guide_sub_task_config_defence_hbr</b>: the task of configuring anti-ransomware for servers.</description></item>
            /// <item><description><b>guide_sub_task_config_uni_defence_hbr</b>: the task of configuring anti-ransomware for databases.</description></item>
            /// <item><description><b>guid_task_log_analysis_config</b>: the task of configuring log analysis.</description></item>
            /// <item><description><b>guide_sub_task_web_lock_config</b>: the task of configuring web tamper proofing.</description></item>
            /// <item><description><b>guide_sub_task_config_anti_crack</b>: the task of configuring protection against brute-force attacks.</description></item>
            /// <item><description><b>guid_task_container_security_video</b>: the task of viewing the video on how to protect containers.</description></item>
            /// <item><description><b>guid_task_container_image_scan_config</b>: the task of configuring container image scan.</description></item>
            /// <item><description><b>guid_task_k8s_log_analysis_config</b>: the task of configuring threat detection on Kubernetes containers.</description></item>
            /// <item><description><b>guid_task_container_network</b>: the task of configuring container network visualization.</description></item>
            /// <item><description><b>guide_sub_task_config_add_collection</b>: the task of saving a console URL.</description></item>
            /// <item><description><b>guide_sub_task_vul_scan</b>: the task of scanning for vulnerabilities.</description></item>
            /// <item><description><b>guide_sub_task_virusKill</b>: the task of configuring virus detection and removal.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>guide_sub_task_config_add_collection</para>
            /// </summary>
            [NameInMap("TaskTypeName")]
            [Validation(Required=false)]
            public string TaskTypeName { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
