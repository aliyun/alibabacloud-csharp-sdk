// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FCSandbox20260509.Models
{
    public class LogConfiguration : TeaModel {
        /// <summary>
        /// <para>The name of the Simple Log Service Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-logstore</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the Simple Log Service project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sandbox-project</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
