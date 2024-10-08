// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteCustomLogShrinkRequest : TeaModel {
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public string CookiesShrink { get; set; }

        [NameInMap("RequestHeaders")]
        [Validation(Required=false)]
        public string RequestHeadersShrink { get; set; }

        [NameInMap("ResponseHeaders")]
        [Validation(Required=false)]
        public string ResponseHeadersShrink { get; set; }

        /// <summary>
        /// <para>site id</para>
        /// 
        /// <b>Example:</b>
        /// <para>11223****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
