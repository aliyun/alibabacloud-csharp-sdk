// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20201002.Models
{
    public class IsKeepAliveResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsKeepAlive")]
        [Validation(Required=false)]
        public bool? IsKeepAlive { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou+dir-885351****</para>
        /// </summary>
        [NameInMap("OfficeSiteId")]
        [Validation(Required=false)]
        public string OfficeSiteId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1CBAFFAB-B697-4049-A9B1-67E1FC5F****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>141631846826****</para>
        /// </summary>
        [NameInMap("TenantId")]
        [Validation(Required=false)]
        public string TenantId { get; set; }

    }

}
