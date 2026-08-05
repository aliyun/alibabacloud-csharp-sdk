// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveLazyPullStreamInfoConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application.</para>
        /// <remarks>
        /// <para>To trigger origin fetch for all applications, set this parameter to <b>ali_all_app</b>.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ali_all_app</para>
        /// </summary>
        [NameInMap("AppName")]
        [Validation(Required=false)]
        public string AppName { get; set; }

        /// <summary>
        /// <para>The streaming domain name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("DomainName")]
        [Validation(Required=false)]
        public string DomainName { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The source application name.</para>
        /// <remarks>
        /// <para>Leave this parameter empty to use the application name from the playback URL of the source stream.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>livePullApp****</para>
        /// </summary>
        [NameInMap("PullAppName")]
        [Validation(Required=false)]
        public string PullAppName { get; set; }

        /// <summary>
        /// <para>The origin server that hosts the live stream. To specify multiple origin servers, separate them with semicolons (;).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>guide.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PullDomainName")]
        [Validation(Required=false)]
        public string PullDomainName { get; set; }

        /// <summary>
        /// <para>The protocol to use for pulling the stream from the source. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>rtmp</b></para>
        /// </description></item>
        /// <item><description><para><b>httpflv</b></para>
        /// </description></item>
        /// <item><description><para><b>hls</b></para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("PullProtocol")]
        [Validation(Required=false)]
        public string PullProtocol { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to trigger stream pulling when a request for a transcoded stream is made. Default value: <b>no</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>yes</b></para>
        /// </description></item>
        /// <item><description><para><b>no</b></para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>no</para>
        /// </summary>
        [NameInMap("TranscodeLazy")]
        [Validation(Required=false)]
        public string TranscodeLazy { get; set; }

    }

}
