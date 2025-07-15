// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeChannelUsersResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of streamers/co-streamers.</para>
        /// </summary>
        [NameInMap("InteractiveUserList")]
        [Validation(Required=false)]
        public List<string> InteractiveUserList { get; set; }

        /// <summary>
        /// <para>The number of co-streamers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("InteractiveUserNumber")]
        [Validation(Required=false)]
        public int? InteractiveUserNumber { get; set; }

        /// <summary>
        /// <para>Indicates whether the channel exists. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>After all users leave the channel, the system requires a few seconds to clear the cache. If you call the operation during this period, the value of this parameter is true, and the value of InteractiveUserNumber and LiveUserNumber is 0.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("IsChannelExists")]
        [Validation(Required=false)]
        public bool? IsChannelExists { get; set; }

        /// <summary>
        /// <para>The list of viewers.</para>
        /// </summary>
        [NameInMap("LiveUserList")]
        [Validation(Required=false)]
        public List<string> LiveUserList { get; set; }

        /// <summary>
        /// <para>The number of viewers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("LiveUserNumber")]
        [Validation(Required=false)]
        public int? LiveUserNumber { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD86847D-1F36-18C8-A995-5EEA340B3202</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The UTC timestamp when the response is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1691027655</para>
        /// </summary>
        [NameInMap("Timestamp")]
        [Validation(Required=false)]
        public long? Timestamp { get; set; }

    }

}
