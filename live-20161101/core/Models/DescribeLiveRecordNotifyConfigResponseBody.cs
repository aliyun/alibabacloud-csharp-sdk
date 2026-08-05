// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveRecordNotifyConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The recording callback configuration for the domain name.</para>
        /// </summary>
        [NameInMap("LiveRecordNotifyConfig")]
        [Validation(Required=false)]
        public DescribeLiveRecordNotifyConfigResponseBodyLiveRecordNotifyConfig LiveRecordNotifyConfig { get; set; }
        public class DescribeLiveRecordNotifyConfigResponseBodyLiveRecordNotifyConfig : TeaModel {
            /// <summary>
            /// <para>The streaming domain name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Specifies whether to receive callbacks for the status of recording tasks. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>true</b>: Yes.</para>
            /// </description></item>
            /// <item><description><para><b>false</b> (default): No.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>false</para>
            /// </summary>
            [NameInMap("NeedStatusNotify")]
            [Validation(Required=false)]
            public bool? NeedStatusNotify { get; set; }

            /// <summary>
            /// <para>The authentication key for the callback.</para>
            /// 
            /// <b>Example:</b>
            /// <para>KbT8mN2pQ9rS4vX7wZ1aB3cE5fG6hJ8kL</para>
            /// </summary>
            [NameInMap("NotifyAuthKey")]
            [Validation(Required=false)]
            public string NotifyAuthKey { get; set; }

            /// <summary>
            /// <para>Specifies whether to enable callback authentication. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>yes</b>: enabled.</para>
            /// </description></item>
            /// <item><description><para><b>no</b>: disabled.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>no</para>
            /// </summary>
            [NameInMap("NotifyReqAuth")]
            [Validation(Required=false)]
            public bool? NotifyReqAuth { get; set; }

            /// <summary>
            /// <para>The webhook address for recording callbacks.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://learn.aliyundoc.com/examplecallback.action">http://learn.aliyundoc.com/examplecallback.action</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

            /// <summary>
            /// <para>The callback URL for on-demand recording.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://guide.aliyundoc.com/ondemandcallback.action">http://guide.aliyundoc.com/ondemandcallback.action</a></para>
            /// </summary>
            [NameInMap("OnDemandUrl")]
            [Validation(Required=false)]
            public string OnDemandUrl { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5056369B-D337-499E-B8B7-B761BD37B08A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
