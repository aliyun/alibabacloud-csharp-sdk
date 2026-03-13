// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.FC20230330.Models
{
    public class SLSTriggerLogConfig : TeaModel {
        /// <summary>
        /// <para>The name of the Logstore. Exceptions and function execution statistics during function triggering are recorded in the Logstore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-sls-logstore-name</para>
        /// </summary>
        [NameInMap("logstore")]
        [Validation(Required=false)]
        public string Logstore { get; set; }

        /// <summary>
        /// <para>The name of the project. Exceptions that occur during function triggering and execution statistics are recorded in the Logstore under the project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-sls-project-name</para>
        /// </summary>
        [NameInMap("project")]
        [Validation(Required=false)]
        public string Project { get; set; }

    }

}
