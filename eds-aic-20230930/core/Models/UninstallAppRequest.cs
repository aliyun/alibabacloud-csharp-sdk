// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UninstallAppRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of the apps.</para>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// <para>The ID of the instance groups. If you specify this parameter, you cannot specify InstanceIdList.</para>
        /// </summary>
        [NameInMap("InstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>The IDs of the cloud phone instances. If you specify this parameter, you cannot specify InstanceGroupIdList.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

    }

}
