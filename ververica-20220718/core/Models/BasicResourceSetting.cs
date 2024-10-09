// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ververica20220718.Models
{
    public class BasicResourceSetting : TeaModel {
        [NameInMap("jobmanagerResourceSettingSpec")]
        [Validation(Required=false)]
        public BasicResourceSettingSpec JobmanagerResourceSettingSpec { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("parallelism")]
        [Validation(Required=false)]
        public long? Parallelism { get; set; }

        [NameInMap("taskmanagerResourceSettingSpec")]
        [Validation(Required=false)]
        public BasicResourceSettingSpec TaskmanagerResourceSettingSpec { get; set; }

    }

}
