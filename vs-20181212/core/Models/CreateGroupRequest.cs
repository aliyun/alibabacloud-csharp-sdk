// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class CreateGroupRequest : TeaModel {
        /// <summary>
        /// <para>Application name used by the workspace. Default value: live</para>
        /// 
        /// <b>Example:</b>
        /// <para>live</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>Callback URL triggered when device or stream status updates in the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://example.com/callback">http://example.com/callback</a></para>
        /// </summary>
        [NameInMap("Callback")]
        [Validation(Required=false)]
        public string Callback { get; set; }

        /// <summary>
        /// <para>Workspace description</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的视频监控</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Ingest protocol used by the workspace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>gb28181</para>
        /// </description></item>
        /// <item><description><para>rtmp</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("InProtocol")]
        [Validation(Required=false)]
        public string InProtocol { get; set; }

        /// <summary>
        /// <para>Whether to enable on-demand stream pulling. Valid values:</para>
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
        /// <para>Workspace name</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>我的视频监控</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Playback protocols used by the workspace. Separate multiple values with commas. Valid values:</para>
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
        /// <para>flv,rtmp</para>
        /// </summary>
        [NameInMap("OutProtocol")]
        [Validation(Required=false)]
        public string OutProtocol { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Streaming domain used by the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>demo.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PlayDomain")]
        [Validation(Required=false)]
        public string PlayDomain { get; set; }

        /// <summary>
        /// <para>Ingest domain used by the workspace</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PushDomain")]
        [Validation(Required=false)]
        public string PushDomain { get; set; }

        /// <summary>
        /// <para>Region where the workspace is located, that is, the service center</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

    }

}
