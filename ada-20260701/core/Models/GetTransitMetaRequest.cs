// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetTransitMetaRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the temporary download URL generated for the current request, in milliseconds. The value must be an integer greater than or equal to 1000 and is rounded down to the nearest whole second. If ExpireMs is omitted, the default validity period is 900000 milliseconds (15 minutes). A download URL is generated only when Network is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900000</para>
        /// </summary>
        [NameInMap("ExpireMs")]
        [Validation(Required=false)]
        public long? ExpireMs { get; set; }

        /// <summary>
        /// <para>The opaque object path returned by CreateTransitUploadPolicy. Specify at least one of this parameter and TransitId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-bundle/tenant-demo/user-demo/20260904120000_code-review.zip</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The network type used for the download URL. Valid values: public and internal. If this parameter is omitted, no download URL is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The transit ID. Specify at least one of this parameter and FilePath. If both are provided, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transit_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("TransitId")]
        [Validation(Required=false)]
        public string TransitId { get; set; }

    }

}
