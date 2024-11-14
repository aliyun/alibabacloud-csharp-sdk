// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeCloudResourceAccessedPortsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP ports.</para>
        /// </summary>
        [NameInMap("Http")]
        [Validation(Required=false)]
        public List<int?> Http { get; set; }

        /// <summary>
        /// <para>The HTTPS ports.</para>
        /// </summary>
        [NameInMap("Https")]
        [Validation(Required=false)]
        public List<int?> Https { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1823E96-EF4B-5BD2-9E02-1D18****3ED8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
