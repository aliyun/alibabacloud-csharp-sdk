// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeEndPointMetricDataRequest : TeaModel {
        /// <summary>
        /// <para>The app ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testappid</para>
        /// </summary>
        [NameInMap("AppId")]
        [Validation(Required=false)]
        public string AppId { get; set; }

        /// <summary>
        /// <para>The channel ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid</para>
        /// </summary>
        [NameInMap("ChannelId")]
        [Validation(Required=false)]
        public string ChannelId { get; set; }

        /// <summary>
        /// <para>The start time of the query time range. This time cannot be earlier than the actual creation time of the channel or more than 30 days ago. The time is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// <para>The end time of the query time range. This time cannot be later than the release time of the channel. The time is a UNIX timestamp in seconds. If this parameter is left empty, the current time is used.</para>
        /// <remarks>
        /// <para>If the specified end time is later than the release time of the channel, the data from the start time to the release time of the channel is returned, and a maximum of data from the last 3 hours is returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("DestroyedTs")]
        [Validation(Required=false)]
        public long? DestroyedTs { get; set; }

        /// <summary>
        /// <para>The list of metric enumerations. Separate multiple metrics with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VIDEO_STUCK_CAMERA</para>
        /// </summary>
        [NameInMap("Metrics")]
        [Validation(Required=false)]
        public string Metrics { get; set; }

        /// <summary>
        /// <para>The call IDs of the communication streams for the publisher. Separate multiple IDs with commas (,).</para>
        /// <remarks>
        /// <para>You can specify either PubUserId or PubCallIdList.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testcall1,testcall2</para>
        /// </summary>
        [NameInMap("PubCallIdList")]
        [Validation(Required=false)]
        public string PubCallIdList { get; set; }

        /// <summary>
        /// <para>The user ID of the publisher.</para>
        /// <remarks>
        /// <para>You can specify either PubUserId or PubCallIdList.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>testuserid2</para>
        /// </summary>
        [NameInMap("PubUserId")]
        [Validation(Required=false)]
        public string PubUserId { get; set; }

        /// <summary>
        /// <para>The user ID of the subscriber.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testuserid</para>
        /// </summary>
        [NameInMap("SubUserId")]
        [Validation(Required=false)]
        public string SubUserId { get; set; }

    }

}
