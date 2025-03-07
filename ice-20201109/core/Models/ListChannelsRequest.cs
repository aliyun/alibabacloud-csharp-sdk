// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListChannelsRequest : TeaModel {
        /// <summary>
        /// <para>The name of the channel.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MyChannel</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>The tier of the channel. Valid values: basic and standard.</para>
        /// 
        /// <b>Example:</b>
        /// <para>basic</para>
        /// </summary>
        [NameInMap("ChannelTier")]
        [Validation(Required=false)]
        public string ChannelTier { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The playback mode. Valid values: loop and linear.</para>
        /// 
        /// <b>Example:</b>
        /// <para>loop</para>
        /// </summary>
        [NameInMap("PlaybackMode")]
        [Validation(Required=false)]
        public string PlaybackMode { get; set; }

        /// <summary>
        /// <para>The sorting order by creation time. Valid values: asc and desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The sorting order by modification time. Valid values: asc and desc.</para>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortByModifiedTime")]
        [Validation(Required=false)]
        public string SortByModifiedTime { get; set; }

        /// <summary>
        /// <para>The channel status. A value of 0 specifies stopped. A value of 1 specifies started.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("State")]
        [Validation(Required=false)]
        public int? State { get; set; }

    }

}
