// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class SetHttpDDoSAttackProtectionResponseBody : TeaModel {
        /// <summary>
        /// <para>The level of HTTP DDoS attack protection.</para>
        /// 
        /// <b>Example:</b>
        /// <para>default</para>
        /// </summary>
        [NameInMap("GlobalMode")]
        [Validation(Required=false)]
        public string GlobalMode { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C370DAF1-C838-4288-A1A0-9A87633D248E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The website ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123456****</para>
        /// </summary>
        [NameInMap("SiteId")]
        [Validation(Required=false)]
        public long? SiteId { get; set; }

    }

}
