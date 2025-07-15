// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveDetectNotifyConfigResponseBody : TeaModel {
        /// <summary>
        /// <para>The callback configuration.</para>
        /// </summary>
        [NameInMap("LiveDetectNotifyConfig")]
        [Validation(Required=false)]
        public DescribeLiveDetectNotifyConfigResponseBodyLiveDetectNotifyConfig LiveDetectNotifyConfig { get; set; }
        public class DescribeLiveDetectNotifyConfigResponseBodyLiveDetectNotifyConfig : TeaModel {
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
            /// <para>The callback URL.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://aliyundoc.com">http://aliyundoc.com</a></para>
            /// </summary>
            [NameInMap("NotifyUrl")]
            [Validation(Required=false)]
            public string NotifyUrl { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>16A96B9A-F203-4EC5-8E43-CB92E68F4CD8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
