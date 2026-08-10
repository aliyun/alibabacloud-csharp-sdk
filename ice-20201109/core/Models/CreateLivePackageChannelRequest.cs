// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class CreateLivePackageChannelRequest : TeaModel {
        /// <summary>
        /// <para>The channel name. The name can contain only uppercase and lowercase letters, digits, hyphens, and underscores. The name must be 1 to 200 characters in length. Format: [A-Za-z0-9_-]+</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel-1</para>
        /// </summary>
        [NameInMap("ChannelName")]
        [Validation(Required=false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// <para>The idempotency token.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>12e8864746a0a398</b></b></para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The description. The description can be up to 1000 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>This is a test channel.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The channel group name. The name can contain only uppercase and lowercase letters, digits, hyphens, and underscores. The name must be 1 to 200 characters in length. Format: [A-Za-z0-9_-]+</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>channel-group-1</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The input protocol. Currently, only HLS is supported.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>HLS</para>
        /// </summary>
        [NameInMap("Protocol")]
        [Validation(Required=false)]
        public string Protocol { get; set; }

        /// <summary>
        /// <para>The number of m3u8 segments for the input stream. Valid values: 2 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("SegmentCount")]
        [Validation(Required=false)]
        public int? SegmentCount { get; set; }

        /// <summary>
        /// <para>The segment duration of the input stream, in seconds. Valid values: 1 to 30.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6</para>
        /// </summary>
        [NameInMap("SegmentDuration")]
        [Validation(Required=false)]
        public int? SegmentDuration { get; set; }

    }

}
