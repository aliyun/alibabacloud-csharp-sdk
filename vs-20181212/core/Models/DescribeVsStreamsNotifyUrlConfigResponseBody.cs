// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vs20181212.Models
{
    public class DescribeVsStreamsNotifyUrlConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>Configuration information.</para>
        /// </summary>
        [NameInMap("LiveStreamsNotifyConfig")]
        [Validation(Required=false)]
        public DescribeVsStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig LiveStreamsNotifyConfig { get; set; }
        public class DescribeVsStreamsNotifyUrlConfigResponseBodyLiveStreamsNotifyConfig : TeaModel {
            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            [NameInMap("AuthType")]
            [Validation(Required=false)]
            public string AuthType { get; set; }

            /// <summary>
            /// <para>Your ingest domain.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.aliyundoc.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <para>Webhook address.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://example.com/callback">https://example.com/callback</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>BEA5625F-8FCF-48F4-851B-CA63946DA664</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
