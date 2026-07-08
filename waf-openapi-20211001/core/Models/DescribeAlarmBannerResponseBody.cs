// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeAlarmBannerResponseBody : TeaModel {
        /// <summary>
        /// <para>The status information of the alert banner.</para>
        /// </summary>
        [NameInMap("BannerStatus")]
        [Validation(Required=false)]
        public DescribeAlarmBannerResponseBodyBannerStatus BannerStatus { get; set; }
        public class DescribeAlarmBannerResponseBodyBannerStatus : TeaModel {
            /// <summary>
            /// <para>The cause of the alert. If <b>Type</b> is set to <b>sandbox</b>, valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>fivefold</b>: The queries per second (QPS) of your service exceeds five times the upper limit of your plan.</para>
            /// </description></item>
            /// <item><description><para><b>4count</b>: The QPS of your service has exceeded the upper limit of your plan for four or more days.</para>
            /// </description></item>
            /// <item><description><para><b>exceed10w</b>: The peak QPS of your service exceeds 100,000.</para>
            /// </description></item>
            /// <item><description><para><b>costProtection</b>: Billing protection is triggered.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>4count</para>
            /// </summary>
            [NameInMap("Cause")]
            [Validation(Required=false)]
            public string Cause { get; set; }

            /// <summary>
            /// <para>The count associated with the alert at the time it was triggered.</para>
            /// <list type="bullet">
            /// <item><description>If <b>Type</b> is set to <b>sandbox</b>, this parameter indicates the number of days that the QPS has exceeded the upper limit of your plan.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>9008</para>
            /// </summary>
            [NameInMap("Count")]
            [Validation(Required=false)]
            public int? Count { get; set; }

            /// <summary>
            /// <para>Indicates whether an alert is triggered. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: An alert is triggered. If <b>Type</b> is set to <b>sandbox</b>, the instance is in the sandbox.</para>
            /// </description></item>
            /// <item><description><para><b>false</b>: No alert is triggered. If <b>Type</b> is set to <b>sandbox</b>, the instance is not in the sandbox.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public bool? Status { get; set; }

            /// <summary>
            /// <para>The alert type. Valid value:</para>
            /// <list type="bullet">
            /// <item><description><b>sandbox</b>: a sandbox alert.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>sandbox</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5555DC36-0CF2-5AA3-B1C7-D6BD8****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
