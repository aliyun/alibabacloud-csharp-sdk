// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Green20220926.Models
{
    public class GetKeywordLibRequest : TeaModel {
        /// <summary>
        /// <para>The keyword library ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>customxx_xxx</para>
        /// </summary>
        [NameInMap("LibId")]
        [Validation(Required=false)]
        public string LibId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The library code.</para>
        /// <list type="bullet">
        /// <item><description>desensitize: masking library</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desensitize</para>
        /// </summary>
        [NameInMap("TenantCode")]
        [Validation(Required=false)]
        public string TenantCode { get; set; }

    }

}
