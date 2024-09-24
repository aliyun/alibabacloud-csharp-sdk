// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeDefaultProxyInstallVersionResponseBody : TeaModel {
        /// <summary>
        /// <para>The default installation version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>proxy_01_03</para>
        /// </summary>
        [NameInMap("InstallVersion")]
        [Validation(Required=false)]
        public string InstallVersion { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F9FCB51A-5078-5D31-9C4D-3B25BEF068C7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
