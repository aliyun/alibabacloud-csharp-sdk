// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class UpdateInstanceNameRequest : TeaModel {
        /// <summary>
        /// <para>The new name of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_name</para>
        /// </summary>
        [NameInMap("instanceName")]
        [Validation(Required=false)]
        public string InstanceName { get; set; }

    }

}
