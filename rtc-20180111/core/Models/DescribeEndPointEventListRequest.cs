// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rtc20180111.Models
{
    public class DescribeEndPointEventListRequest : TeaModel {
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
        /// <para>The start time of the event query time range. This time cannot be earlier than the actual creation time of the channel or 30 days ago. The time is a UNIX timestamp in seconds.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("CreatedTs")]
        [Validation(Required=false)]
        public long? CreatedTs { get; set; }

        /// <summary>
        /// <para>The end time of the event query time range. This time cannot be later than the release time of the channel. The time is a UNIX timestamp in seconds. If this parameter is left empty, the current time is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1614936817</para>
        /// </summary>
        [NameInMap("DestroyedTs")]
        [Validation(Required=false)]
        public long? DestroyedTs { get; set; }

        /// <summary>
        /// <para>The list of user IDs. Separate multiple user IDs with commas (,).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testuserid1,testuserid2</para>
        /// </summary>
        [NameInMap("UserIdList")]
        [Validation(Required=false)]
        public string UserIdList { get; set; }

    }

}
