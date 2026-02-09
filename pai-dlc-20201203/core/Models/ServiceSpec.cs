// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pai_dlc20201203.Models
{
    public class ServiceSpec : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8080</para>
        /// </summary>
        [NameInMap("DefaultPort")]
        [Validation(Required=false)]
        public int? DefaultPort { get; set; }

        [NameInMap("ExtraPorts")]
        [Validation(Required=false)]
        public List<int?> ExtraPorts { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PerRole</para>
        /// </summary>
        [NameInMap("ServiceMode")]
        [Validation(Required=false)]
        public string ServiceMode { get; set; }

    }

}
