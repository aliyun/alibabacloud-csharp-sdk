// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class ModifyGroupRequest : TeaModel {
        /// <summary>
        /// <para>Callback URL for device or stream status updates in the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>Description of the space.</para>
        /// 
        /// <b>Example:</b>
        /// <para>用于测试使用</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Indicates whether the space is enabled.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Enabled")]
        [Validation(Required=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// <para>The ID of the space.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>32388487739092994-cn-qingdao</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>Ingest protocol used by the group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>gb28181</para>
        /// </description></item>
        /// <item><description><para>rtmp</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>gb28181</para>
        /// </summary>
        [NameInMap("InProtocol")]
        [Validation(Required=false)]
        public string InProtocol { get; set; }

        /// <summary>
        /// <para>Whether on-demand stream pulling is enabled. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default)</para>
        /// </description></item>
        /// <item><description><para>true</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LazyPull")]
        [Validation(Required=false)]
        public bool? LazyPull { get; set; }

        /// <summary>
        /// <para>Space name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myGroup</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Playback protocols used by the group. Separate multiple values with commas. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>flv</para>
        /// </description></item>
        /// <item><description><para>hls</para>
        /// </description></item>
        /// <item><description><para>rtmp</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>flv,rtmp,hls</para>
        /// </summary>
        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Streaming domain used by the group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>myplay.com</para>
        /// </summary>
        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// <para>Ingest domain used by the group. Applies only to groups that use the RTMP ingest protocol.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mypush.com</para>
        /// </summary>
        [NameInMap("PushDomain")]
        [Validation(Required=false)]
        public string PushDomain { get; set; }

        /// <summary>
        /// <para>The region where the space is located. This region serves as the service center.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-qingdao</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
