// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ada20260701.Models
{
    public class GetTransitMetaRequest : TeaModel {
        /// <summary>
        /// <para>The validity period of the temporary download URL, in milliseconds. The value must be an integer greater than or equal to 1000 and is rounded down to the nearest whole second. If <c>ExpireMs</c> is not specified, the default validity period is <c>900000</c> milliseconds (15 minutes). A download URL is generated only when <c>Network</c> is specified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900000</para>
        /// </summary>
        [NameInMap("ExpireMs")]
        [Validation(Required=false)]
        public long? ExpireMs { get; set; }

        /// <summary>
        /// <para>The opaque object path returned by <c>CreateTransitUploadPolicy</c>. Specify at least one of this parameter and <c>TransitId</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skill-bundle/tenant-demo/user-demo/20260904120000_code-review.zip</para>
        /// </summary>
        [NameInMap("FilePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        /// <summary>
        /// <para>The network type for the download URL. Valid values: <c>public</c> and <c>internal</c>. If this parameter is not specified, no download URL is generated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>public</para>
        /// </summary>
        [NameInMap("Network")]
        [Validation(Required=false)]
        public string Network { get; set; }

        /// <summary>
        /// <para>The Transit ID. Specify at least one of this parameter and <c>FilePath</c>. If both are specified, this parameter takes precedence.</para>
        /// 
        /// <b>Example:</b>
        /// <para>transit_0123456789abcdef0123456789abcdef</para>
        /// </summary>
        [NameInMap("TransitId")]
        [Validation(Required=false)]
        public string TransitId { get; set; }

    }

}
