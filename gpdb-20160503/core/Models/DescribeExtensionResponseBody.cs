// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class DescribeExtensionResponseBody : TeaModel {
        /// <summary>
        /// <para>The current version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1</para>
        /// </summary>
        [NameInMap("CurrentVersion")]
        [Validation(Required=false)]
        public string CurrentVersion { get; set; }

        /// <summary>
        /// <para>The description of the extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhparser</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The ID of the extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>37</para>
        /// </summary>
        [NameInMap("ExtensionId")]
        [Validation(Required=false)]
        public string ExtensionId { get; set; }

        /// <summary>
        /// <para>The name of the extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>zhparser</para>
        /// </summary>
        [NameInMap("ExtensionName")]
        [Validation(Required=false)]
        public string ExtensionName { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance must be restarted to install the extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsInstallNeedRestart")]
        [Validation(Required=false)]
        public bool? IsInstallNeedRestart { get; set; }

        /// <summary>
        /// <para>Indicates whether the extension is the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>True</para>
        /// </summary>
        [NameInMap("IsLatestVersion")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>The latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2.1</para>
        /// </summary>
        [NameInMap("LatestVersion")]
        [Validation(Required=false)]
        public string LatestVersion { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ABB39CC3-4488-4857-905D-2E4A051D0521</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>installed</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
