// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateSourceLocationRequest : TeaModel {
        /// <summary>
        /// <para>The protocol and hostname of the source location.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxx.com">http://xxx.com</a></para>
        /// </summary>
        [NameInMap("BaseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <para>Specifies whether to use an independent domain name to access the segments.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSegmentDelivery")]
        [Validation(Required=false)]
        public bool? EnableSegmentDelivery { get; set; }

        /// <summary>
        /// <para>The domain name used to access the segments.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://xxxx.com">http://xxxx.com</a></para>
        /// </summary>
        [NameInMap("SegmentDeliveryUrl")]
        [Validation(Required=false)]
        public string SegmentDeliveryUrl { get; set; }

        /// <summary>
        /// <para>The name of the source location.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MySourceLocation</para>
        /// </summary>
        [NameInMap("SourceLocationName")]
        [Validation(Required=false)]
        public string SourceLocationName { get; set; }

    }

}
