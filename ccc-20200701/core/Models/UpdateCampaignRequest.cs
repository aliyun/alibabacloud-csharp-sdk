// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class UpdateCampaignRequest : TeaModel {
        /// <summary>
        /// <para>Callable time, supports multiple time segments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[
        ///       {
        ///             &quot;beginTime&quot;: &quot;09:00:00&quot;,
        ///             &quot;endTime&quot;: &quot;12:00:00&quot;
        ///       }
        /// ]</para>
        /// </summary>
        [NameInMap("CallableTime")]
        [Validation(Required=false)]
        public string CallableTime { get; set; }

        /// <summary>
        /// <para>Predictive outbound campaign ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ab11908b-6ebc-4b0c-b51e-3e17c7060</para>
        /// </summary>
        [NameInMap("CampaignId")]
        [Validation(Required=false)]
        public string CampaignId { get; set; }

        /// <summary>
        /// <para>Contact stream ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3a310f56-4d30-4081-ba24-5d87a3b7262e</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// <para>End time, in Unix timestamp format, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1689933600000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>Cloud Contact Center instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>Predictive outbound campaign name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>云联络中心测试</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Start time, in Unix timestamp format, in milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1689901200000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>Policy parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PACING策略，参考参数
        /// {
        ///       &quot;ratio&quot;: 2
        /// }</para>
        /// <para>PID策略，参考参数
        /// {
        ///     &quot;abandonRate&quot;:5,
        ///     &quot;historicalConnectedRate&quot;:45
        /// }</para>
        /// </summary>
        [NameInMap("StrategyParameters")]
        [Validation(Required=false)]
        public string StrategyParameters { get; set; }

    }

}
