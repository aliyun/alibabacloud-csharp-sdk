// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ServiceSpec : TeaModel {
        /// <summary>
        /// <para>The default port for the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("DefaultPort")]
        [Validation(Required=false)]
        public int? DefaultPort { get; set; }

        /// <summary>
        /// <para>The list of extra ports for the service.</para>
        /// </summary>
        [NameInMap("ExtraPorts")]
        [Validation(Required=false)]
        public List<int?> ExtraPorts { get; set; }

        /// <summary>
        /// <para>The service pattern. Valid values are PerRole and PerPod. The default value is PerPod.</para>
        /// 
        /// <b>Example:</b>
        /// <para>PerRole</para>
        /// </summary>
        [NameInMap("ServiceMode")]
        [Validation(Required=false)]
        public string ServiceMode { get; set; }

    }

}
