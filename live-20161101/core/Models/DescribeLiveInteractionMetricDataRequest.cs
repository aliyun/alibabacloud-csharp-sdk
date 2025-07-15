// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveInteractionMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>e4d7f08a-01fe-41b5-a091-fe41060a****</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698195600000</para>
        /// </summary>
        [NameInMap("BeginTs")]
        [Validation(Required=false)]
        public long? BeginTs { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1698201013000</para>
        /// </summary>
        [NameInMap("EndTs")]
        [Validation(Required=false)]
        public long? EndTs { get; set; }

        /// <summary>
        /// <para>The metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>JoinChannelSucRate: the success rate of joining a channel within 5 seconds.</description></item>
        /// <item><description>VideoStuckRate: the video stuttering rate.</description></item>
        /// <item><description>AudioStuckRate: the audio stuttering rate.</description></item>
        /// <item><description>FirstFrameCost: the time to first frame.</description></item>
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
        /// <para>The operating system. Valid values: iOS and Android.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Android</para>
        /// </summary>
        [NameInMap("Os")]
        [Validation(Required=false)]
        public string Os { get; set; }

        /// <summary>
        /// <para>The terminal type. Valid values: web and mobile.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mobile</para>
        /// </summary>
        [NameInMap("TerminalType")]
        [Validation(Required=false)]
        public string TerminalType { get; set; }

    }

}
