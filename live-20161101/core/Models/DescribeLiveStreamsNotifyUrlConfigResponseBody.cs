// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsNotifyUrlConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The callback configuration.</para>
        /// </summary>
        [NameInMap("LiveStreamsNotifyConfig")]
        [Validation(Required=false)]
        public DescribeLiveStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig LiveStreamsNotifyConfig { get; set; }
        public class DescribeLiveStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig : TeaModel {
            /// <summary>
            /// <para>The ingest domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>demo.aliyundoc.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Exception event callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://4a7e5f08.r37.cpolar.top/live/Record/call-back/streamException">https://4a7e5f08.r37.cpolar.top/live/Record/call-back/streamException</a></para>
            /// </summary>
            [NameInMap("ExceptionNotifyUrl")]
            [Validation(Required=false)]
            public string ExceptionNotifyUrl { get; set; }

            /// <summary>
            /// <para>The authentication key.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("NotifyAuthKey")]
            [Validation(Required=false)]
            public string NotifyAuthKey { get; set; }

            /// <summary>
            /// <para>Indicates whether callback authentication is enabled. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>yes</description></item>
            /// <item><description>no</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>yes</para>
            /// </summary>
            [NameInMap("NotifyReqAuth")]
            [Validation(Required=false)]
            public string NotifyReqAuth { get; set; }

            /// <summary>
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://guide.aliyundoc.com/notify">http://guide.aliyundoc.com/notify</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40A4F36D-A7CC-473A-88E7-154F92242566</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
