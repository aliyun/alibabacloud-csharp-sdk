// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateSiteCustomLogRequest : TeaModel {
        /// <summary>
        /// <para>The cookie fields.</para>
        /// </summary>
        [NameInMap("Cookies")]
        [Validation(Required=false)]
        public List<string> Cookies { get; set; }

        /// <summary>
        /// <para>The request header fields.</para>
        /// </summary>
        [NameInMap("RequestHeaders")]
        [Validation(Required=false)]
        public List<string> RequestHeaders { get; set; }

        /// <summary>
        /// <para>The response header fields.</para>
        /// </summary>
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
