// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteCustomLogRequest : TeaModel {
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public List<string> Cookies { get; set; }

        [NameInMap("RequestHeaders")]
        [Validation(Required=false)]
        public List<string> RequestHeaders { get; set; }

        [NameInMap("ResponseHeaders")]
        [Validation(Required=false)]
        public List<string> ResponseHeaders { get; set; }

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
