// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveLazyPullStreamConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The configurations of triggered stream pulling.</para>
        /// </summary>
        [NameInMap("LiveLazyPullConfigList")]
        [Validation(Required=false)]
        public DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigList LiveLazyPullConfigList { get; set; }
        public class DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigList : TeaModel {
            [NameInMap("LiveLazyPullConfig")]
            [Validation(Required=false)]
            public List<DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigListLiveLazyPullConfig> LiveLazyPullConfig { get; set; }
            public class DescribeLiveLazyPullStreamConfigResponseBodyLiveLazyPullConfigListLiveLazyPullConfig : TeaModel {
                /// <summary>
                /// <para>The name of the application.</para>
                /// 
                /// <b>Example:</b>
                /// <para>liveApp****</para>
                /// </summary>
                [NameInMap("AppName")]
                [Validation(Required=false)]
                public string AppName { get; set; }

                /// <summary>
                /// <para>The main streaming domain.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The name of the application for back-to-origin stream pulling. If the application specified in the streaming URL is used, this parameter is left empty.</para>
                /// 
                /// <b>Example:</b>
                /// <para>livePullApp****</para>
                /// </summary>
                [NameInMap("PullAppName")]
                [Validation(Required=false)]
                public string PullAppName { get; set; }

                /// <summary>
                /// <para>The parameters of back-to-origin stream pulling.</para>
                /// 
                /// <b>Example:</b>
                /// <para>k=v</para>
                /// </summary>
                [NameInMap("PullArgs")]
                [Validation(Required=false)]
                public string PullArgs { get; set; }

                /// <summary>
                /// <para>The domain name for back-to-origin stream pulling.</para>
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
                /// 
                /// <b>Example:</b>
                /// <para>RTMP</para>
                /// </summary>
                [NameInMap("PullProtocol")]
                [Validation(Required=false)]
                public string PullProtocol { get; set; }

                /// <summary>
                /// <para>Indicates whether stream pulling is triggered when the transcoded stream is played. Default value: <b>no</b>. Valid values:</para>
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

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A3136B58-5876-4168-83CA-B562781981A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
