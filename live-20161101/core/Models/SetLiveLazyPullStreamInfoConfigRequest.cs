// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class SetLiveLazyPullStreamInfoConfigRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <remarks>
        /// <para> If you want to configure triggered stream pulling for all applications, set the value to <b>ali_all_app</b>.</para>
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
        /// <para>The main streaming domain.</para>
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
        /// <para>The name of the application for back-to-origin stream pulling.</para>
        /// <remarks>
        /// <para> If you want to use the application specified in the streaming URL, leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>livePullApp****</para>
        /// </summary>
        [NameInMap("PullAppName")]
        [Validation(Required=false)]
        public string PullAppName { get; set; }

        /// <summary>
        /// <para>The origin server address of the live stream. Separate multiple addresses with semicolons (;).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>guide.aliyundoc.com</para>
        /// </summary>
        [NameInMap("PullDomainName")]
        [Validation(Required=false)]
        public string PullDomainName { get; set; }

        /// <summary>
        /// <para>The protocol for back-to-origin stream pulling. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>rtmp</b></description></item>
        /// <item><description><b>httpflv</b></description></item>
        /// <item><description><b>hls</b></description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rtmp</para>
        /// </summary>
        [NameInMap("PullProtocol")]
        [Validation(Required=false)]
        public string PullProtocol { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to trigger stream pulling when the transcoded stream is played. The default value is <b>no</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b></description></item>
        /// <item><description><b>no</b></description></item>
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
