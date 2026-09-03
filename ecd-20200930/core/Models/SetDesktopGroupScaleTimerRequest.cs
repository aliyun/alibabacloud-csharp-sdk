// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class SetDesktopGroupScaleTimerRequest : TeaModel {
        /// <summary>
        /// <para>The cloud computer pool ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dg-2i8qxpv6t1a03****</para>
        /// </summary>
        [NameInMap("DesktopGroupId")]
        [Validation(Required=false)]
        public string DesktopGroupId { get; set; }

        /// <summary>
        /// <para>The region ID. You can call <a href="https://help.aliyun.com/document_detail/196646.html">DescribeRegions</a> to query the regions supported by Elastic Desktop Service.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The list of scheduled task information for automatic scaling.</para>
        /// </summary>
        [NameInMap("ScaleTimerInfos")]
        [Validation(Required=false)]
        public List<SetDesktopGroupScaleTimerRequestScaleTimerInfos> ScaleTimerInfos { get; set; }
        public class SetDesktopGroupScaleTimerRequestScaleTimerInfos : TeaModel {
            /// <summary>
            /// <para>The number of cloud computers to purchase, which is one of the scaling policy parameters. Valid values: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("BuyResAmount")]
            [Validation(Required=false)]
            public int? BuyResAmount { get; set; }

            /// <summary>
            /// <para>The cron expression for the trigger time.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0 0 12 ? * 1</para>
            /// </summary>
            [NameInMap("Cron")]
            [Validation(Required=false)]
            public string Cron { get; set; }

            /// <summary>
            /// <para>The duration for which a session is retained after disconnection. Unit: milliseconds. Valid values: 180000 (3 minutes) to 345600000 (4 days). A value of 0 indicates that the session is always retained.</para>
            /// <para>When a session is disconnected because the user actively disconnects or because of other unexpected factors, the timer starts from the moment of disconnection. If the user does not reconnect to the session within this retention duration, the session is logged off and all unsaved data is destroyed. If the user successfully reconnects within this retention duration, the user can still access the original session and the data that existed before the disconnection.</para>
            /// 
            /// <b>Example:</b>
            /// <para>180000</para>
            /// </summary>
            [NameInMap("KeepDuration")]
            [Validation(Required=false)]
            public long? KeepDuration { get; set; }

            /// <summary>
            /// <para>The load balancing policy for the multi-session cloud computer pool.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("LoadPolicy")]
            [Validation(Required=false)]
            public int? LoadPolicy { get; set; }

            /// <summary>
            /// <para>The maximum number of cloud computers, which is one of the scaling policy parameters. Valid values: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100</para>
            /// </summary>
            [NameInMap("MaxResAmount")]
            [Validation(Required=false)]
            public int? MaxResAmount { get; set; }

            /// <summary>
            /// <para>The minimum number of cloud computers, which is one of the scaling policy parameters. Valid values: 0 to 200.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MinResAmount")]
            [Validation(Required=false)]
            public int? MinResAmount { get; set; }

            /// <summary>
            /// <para>The session occupancy threshold, which is used as the trigger condition for automatic scaling of the multi-session cloud computer pool. The session occupancy is calculated by using the following formula:</para>
            /// <para><c>Session occupancy = Number of attached sessions / (Total number of cloud computer resources × Maximum number of sessions supported per cloud computer) × 100%</c></para>
            /// <para>When the session occupancy reaches this threshold, new cloud computers are created. When the session occupancy does not reach this threshold, excess cloud computers are deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0.85</para>
            /// </summary>
            [NameInMap("RatioThreshold")]
            [Validation(Required=false)]
            public float? RatioThreshold { get; set; }

            /// <summary>
            /// <para>The policy type.</para>
            /// 
            /// <b>Example:</b>
            /// <para>rise</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

    }

}
