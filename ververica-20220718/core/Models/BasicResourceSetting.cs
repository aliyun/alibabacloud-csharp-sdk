// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class BasicResourceSetting : TeaModel {
        /// <summary>
        /// <para>The resource configuration of the JobManager.</para>
        /// </summary>
        [NameInMap("jobmanagerResourceSettingSpec")]
        [Validation(Required=false)]
        public BasicResourceSettingSpec JobmanagerResourceSettingSpec { get; set; }

        /// <summary>
        /// <para>The parallelism for a deployment.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        /// <summary>
        /// <para>The resource configuration of a TaskManager.</para>
        /// </summary>
        [NameInMap("taskmanagerResourceSettingSpec")]
        [Validation(Required=false)]
        public BasicResourceSettingSpec TaskmanagerResourceSettingSpec { get; set; }

    }

}
