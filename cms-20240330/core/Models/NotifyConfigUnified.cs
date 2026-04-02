// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class NotifyConfigUnified : TeaModel {
        /// <summary>
        /// <para>一周中发送通知的星期，1-7</para>
        /// </summary>
        [NameInMap("activeDays")]
        [Validation(Required=false)]
        public List<int?> ActiveDays { get; set; }

        /// <summary>
        /// <para>每天通知生效结束时间</para>
        /// </summary>
        [NameInMap("activeEndTime")]
        [Validation(Required=false)]
        public string ActiveEndTime { get; set; }

        /// <summary>
        /// <para>每天通知生效开始时间</para>
        /// </summary>
        [NameInMap("activeStartTime")]
        [Validation(Required=false)]
        public string ActiveStartTime { get; set; }

        /// <summary>
        /// <para>通知渠道列表</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("channels")]
        [Validation(Required=false)]
        public List<DirectNotifyChannel> Channels { get; set; }

        /// <summary>
        /// <para>通道沉默周期（秒）</para>
        /// </summary>
        [NameInMap("silenceTimeSecs")]
        [Validation(Required=false)]
        public int? SilenceTimeSecs { get; set; }

        /// <summary>
        /// <para>通知配置类型</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>UTC 时区偏移量</para>
        /// </summary>
        [NameInMap("utcOffset")]
        [Validation(Required=false)]
        public string UtcOffset { get; set; }

    }

}
