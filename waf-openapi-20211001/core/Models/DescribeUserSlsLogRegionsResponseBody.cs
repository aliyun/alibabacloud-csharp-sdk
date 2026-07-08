// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserSlsLogRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of log storage region IDs.</para>
        /// </summary>
        [NameInMap("LogRegions")]
        [Validation(Required=false)]
        public List<string> LogRegions { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9D11AC3A-A10C-56E7-A342-E87EC892BAE2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
