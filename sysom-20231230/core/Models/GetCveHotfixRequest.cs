// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SysOM20231230.Models
{
    public class GetCveHotfixRequest : TeaModel {
        /// <summary>
        /// <para>The list of CVE IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("cveIds")]
        [Validation(Required=false)]
        public List<string> CveIds { get; set; }

        /// <summary>
        /// <para>The list of full kernel versions.</para>
        /// </summary>
        [NameInMap("kernelVersions")]
        [Validation(Required=false)]
        public List<string> KernelVersions { get; set; }

    }

}
