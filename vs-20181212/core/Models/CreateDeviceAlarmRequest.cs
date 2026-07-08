// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateDeviceAlarmRequest : TeaModel {
        /// <summary>
        /// <para>The Alarm Metric. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: other</description></item>
        /// <item><description>1: motion detection alerting</description></item>
        /// <item><description>2: intelligent alerting</description></item>
        /// <item><description>3: switch alerting</description></item>
        /// <item><description>4: video loss alerting.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Alarm")]
        [Validation(Required=false)]
        public int? Alarm { get; set; }

        /// <summary>
        /// <para>The channel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public int? ChannelId { get; set; }

        /// <summary>
        /// <para>The end time. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1632314789000</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The expiration time of the media upload URL. Unit: seconds. Default value: 60.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3600</para>
        /// </summary>
        [NameInMap("Expire")]
        [Validation(Required=false)]
        public long? Expire { get; set; }

        /// <summary>
        /// <para>The device ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>348*****380-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The media object type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: none</description></item>
        /// <item><description>1: JPEG image</description></item>
        /// <item><description>2: video</description></item>
        /// <item><description>3: GIF image.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ObjectType")]
        [Validation(Required=false)]
        public int? ObjectType { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The start time. Unit: milliseconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1632121707000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

        /// <summary>
        /// <para>The alert subtype.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("SubAlarm")]
        [Validation(Required=false)]
        public int? SubAlarm { get; set; }

    }

}
