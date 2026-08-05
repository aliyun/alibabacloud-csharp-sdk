// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveInteractionMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The ARTC application ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e4d7f08a-01fe-41b5-a091-fe41060a****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The start time of the query, specified as a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698195600000</para>
        /// </summary>
        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public long? BeginTs { get; set; }

        /// <summary>
        /// <para>The channel ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>770513</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The end time of the query, specified as a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698201013000</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// <para>The metric type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><c>JoinChannelSucRate</c>: the success rate of joining a channel within 5 seconds.</para>
        /// </description></item>
        /// <item><description><para><c>VideoStuckRate</c>: the video stuttering rate.</para>
        /// </description></item>
        /// <item><description><para><c>AudioStuckRate</c>: the audio stuttering rate.</para>
        /// </description></item>
        /// <item><description><para><c>FirstFrameCost</c>: the time to first frame.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FirstFrameCost</para>
        /// </summary>
        [NameInMap("MetricType")]
        [Validation(Required=false)]
        public string MetricType { get; set; }

        /// <summary>
        /// <para>The operating system. Valid values: <c>iOS</c> and <c>Android</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The terminal type. Valid values: <c>web</c> and <c>mobile</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobile</para>
        /// </summary>
        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

    }

}
