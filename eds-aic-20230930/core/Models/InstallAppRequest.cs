// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class InstallAppRequest : TeaModel {
        /// <summary>
        /// <para>The application IDs.</para>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// <para>The instance group IDs.</para>
        /// </summary>
        [NameInMap("InstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>The instance IDs.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

    }

}
