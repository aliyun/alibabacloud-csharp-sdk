// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class UpdateSourceLocationRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxx.com">http://xxx.com</a></para>
        /// </summary>
        [NameInMap("BaseUrl")]
        [Validation(Required=false)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("EnableSegmentDelivery")]
        [Validation(Required=false)]
        public bool? EnableSegmentDelivery { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="http://xxxx.com">http://xxxx.com</a></para>
        /// </summary>
        [NameInMap("SegmentDeliveryUrl")]
        [Validation(Required=false)]
        public string SegmentDeliveryUrl { get; set; }

        /// <summary>
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
