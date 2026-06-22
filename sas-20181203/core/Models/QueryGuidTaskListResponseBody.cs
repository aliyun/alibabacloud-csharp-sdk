// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class QueryGuidTaskListResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of beginner task information.</para>
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
                /// <item><description><b>1</b>: Not claimed.</description></item>
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
                /// <item><description><b>addTrialDay</b>: trial days reward</description></item>
                /// <item><description><b>addAntiRansomwareCapacity</b>: anti-ransomware capacity reward</description></item>
                /// <item><description><b>addImageScanAuthCount</b>: image scan authorization quota reward</description></item>
                /// <item><description><b>addWebLockAuthCount</b>: web tamper-proofing authorization quota reward</description></item>
                /// <item><description><b>addSlsCapacity</b>: log analysis storage capacity reward.</description></item>
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
                /// <para>The key in the JSON object indicates the reward content, and the value indicates the reward amount. Valid values of the key:</para>
                /// </remarks>
                /// <list type="bullet">
                /// <item><description><b>webLockAuthCount</b>: the web tamper-proofing authorization quota</description></item>
                /// <item><description><b>ransomwareCapacity</b>: the anti-ransomware capacity, in GB</description></item>
                /// <item><description><b>slsCapacity</b>: the log analysis capacity, in GB</description></item>
                /// <item><description><b>days</b>: the number of usage days</description></item>
                /// <item><description><b>imageScanAuthCount</b>: the image scan authorization quota</description></item>
                /// <item><description><b>honeypotAuthCount</b>: the cloud honeypot authorization quota.</description></item>
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
            /// <para>The security score increase that can be gained by completing this task.</para>
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
            /// <para>The node name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>guid_task_security_score_promote_video</b>: the node of watching the beginner quick start video</description></item>
            /// <item><description><b>guide_sub_task_config_defence_hbr</b>: the anti-ransomware configuration node for servers</description></item>
            /// <item><description><b>guide_sub_task_config_uni_defence_hbr</b>: the anti-ransomware configuration node for databases</description></item>
            /// <item><description><b>guid_task_log_analysis_config</b>: the log analysis node</description></item>
            /// <item><description><b>guide_sub_task_web_lock_config</b>: the web tamper-proofing node</description></item>
            /// <item><description><b>guide_sub_task_config_anti_crack</b>: the anti-brute-force attacks node</description></item>
            /// <item><description><b>guid_task_container_security_video</b>: the container security video node</description></item>
            /// <item><description><b>guid_task_container_image_scan_config</b>: the container image scan node</description></item>
            /// <item><description><b>guid_task_k8s_log_analysis_config</b>: the Kubernetes threat detection node</description></item>
            /// <item><description><b>guid_task_container_network</b>: the container visualization node</description></item>
            /// <item><description><b>guide_sub_task_config_add_collection</b>: the node of adding the console to favorites</description></item>
            /// <item><description><b>guide_sub_task_vul_scan</b>: the vulnerability scanning node</description></item>
            /// <item><description><b>guide_sub_task_virusKill</b>: the virus scan node.</description></item>
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
        /// <para>The request ID. Alibaba Cloud generates a unique ID for each request. You can use the ID to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7532B7EE-7CE7-5F4D-BF04-B12447D****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
