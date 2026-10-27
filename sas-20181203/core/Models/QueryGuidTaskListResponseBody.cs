// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryGuidTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of onboarding task information.</para>
        /// </summary>
        [NameInMap("GuideTaskConfigList")]
        [Validation(Required=false)]
        public List<QueryGuidTaskListResponseBodyGuideTaskConfigList> GuideTaskConfigList { get; set; }
        public class QueryGuidTaskListResponseBodyGuideTaskConfigList : TeaModel {
            /// <summary>
            /// <para>The reward information for task completion.</para>
            /// </summary>
            [NameInMap("RewardData")]
            [Validation(Required=false)]
            public QueryGuidTaskListResponseBodyGuideTaskConfigListRewardData RewardData { get; set; }
            public class QueryGuidTaskListResponseBodyGuideTaskConfigListRewardData : TeaModel {
                /// <summary>
                /// <para>The claim status. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>1</b>: Unclaimed.</description></item>
                /// <item><description><b>2</b>: Claimed.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("IsRewardTaked")]
                [Validation(Required=false)]
                public string IsRewardTaked { get; set; }

                /// <summary>
                /// <para>The reward name. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><b>addTrialDay</b>: Add trial days</description></item>
                /// <item><description><b>addAntiRansomwareCapacity</b>: Add anti-ransomware capacity</description></item>
                /// <item><description><b>addImageScanAuthCount</b>: Add image scan authorizations</description></item>
                /// <item><description><b>addWebLockAuthCount</b>: Add web tamper-proofing authorizations</description></item>
                /// <item><description><b>addSlsCapacity</b>: Add log analysis storage space</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>addAntiRansomwareCapacity</para>
                /// </summary>
                [NameInMap("Reward")]
                [Validation(Required=false)]
                public string Reward { get; set; }

                /// <summary>
                /// <para>The reward configuration information. This parameter is in JSON format.</para>
                /// <remarks>
                /// <para>The JSON key indicates the reward content, and the value indicates the reward amount. Valid values for the key:</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>webLockAuthCount</b>: Web tamper-proofing authorizations</description></item>
                /// <item><description><b>ransomwareCapacity</b>: Anti-ransomware capacity, in GB</description></item>
                /// <item><description><b>slsCapacity</b>: Log analysis capacity, in GB</description></item>
                /// <item><description><b>days</b>: Number of days</description></item>
                /// <item><description><b>imageScanAuthCount</b>: Image scan authorizations</description></item>
                /// <item><description><b>honeypotAuthCount</b>: Cloud honeypot authorizations</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>{&quot;days&quot;:60,&quot;ransomwareCapacity&quot;:10}</para>
                /// </summary>
                [NameInMap("RewardConfig")]
                [Validation(Required=false)]
                public string RewardConfig { get; set; }

            }

            /// <summary>
            /// <para>The points added to the security score upon task completion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("SecurityScore")]
            [Validation(Required=false)]
            public int? SecurityScore { get; set; }

            /// <summary>
            /// <para>The task status. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>0</b>: Closed.</description></item>
            /// <item><description><b>1</b>: In progress.</description></item>
            /// <item><description><b>2</b>: Completed.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The task ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>t-000d8slfgx4p40kb64ad</para>
            /// </summary>
            [NameInMap("TaskId")]
            [Validation(Required=false)]
            public int? TaskId { get; set; }

            /// <summary>
            /// <para>The task name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>guid_task_security_score_promote_video</b>: Watch the quick start video task</description></item>
            /// <item><description><b>guide_sub_task_config_defence_hbr</b>: Server anti-ransomware configuration task</description></item>
            /// <item><description><b>guide_sub_task_config_uni_defence_hbr</b>: Database anti-ransomware configuration task</description></item>
            /// <item><description><b>guid_task_log_analysis_config</b>: Log analysis task</description></item>
            /// <item><description><b>guide_sub_task_web_lock_config</b>: Web tamper-proofing task</description></item>
            /// <item><description><b>guide_sub_task_config_anti_crack</b>: Anti-brute-force attacks task</description></item>
            /// <item><description><b>guid_task_container_security_video</b>: Container security video task</description></item>
            /// <item><description><b>guid_task_container_image_scan_config</b>: Container image scanning task</description></item>
            /// <item><description><b>guid_task_k8s_log_analysis_config</b>: Kubernetes threat detection task</description></item>
            /// <item><description><b>guid_task_container_network</b>: Container visualization task</description></item>
            /// <item><description><b>guide_sub_task_config_add_collection</b>: Add console to favorites task</description></item>
            /// <item><description><b>guide_sub_task_vul_scan</b>: Vulnerability scanning task</description></item>
            /// <item><description><b>guide_sub_task_virusKill</b>: Virus scan and removal task</description></item>
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
        /// <para>The ID of the request. The ID is a unique identifier generated by Alibaba Cloud for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
