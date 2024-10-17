// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class ModifyAndroidInstanceRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>acp-8v5bjld0r7tkl****</para>
        /// </summary>
        [NameInMap("AndroidInstanceId")]
        [Validation(Required=false)]
        public string AndroidInstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>new_name</para>
        /// </summary>
        [NameInMap("NewAndroidInstanceName")]
        [Validation(Required=false)]
        public string NewAndroidInstanceName { get; set; }

    }

}
