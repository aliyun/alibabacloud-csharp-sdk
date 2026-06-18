// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetClientCaCertificateHostnamesRequest : TeaModel {
        /// <summary>
        /// <para>A list of hostnames.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Hostnames")]
        [Validation(Required=false)]
        public List<string> Hostnames { get; set; }

        /// <summary>
        /// <para>The client CA certificate ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>babaabcd****</para>
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public string Id { get; set; }

        /// <summary>
        /// <para>The site ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
