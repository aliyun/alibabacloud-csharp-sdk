// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class UninstallAppRequest : TeaModel {
        /// <summary>
        /// <para>A list of application IDs.</para>
        /// </summary>
        [NameInMap("AppIdList")]
        [Validation(Required=false)]
        public List<string> AppIdList { get; set; }

        /// <summary>
        /// <para>A list of instance group IDs. You must specify either this parameter or <c>InstanceIdList</c>. If you specify both, only <c>InstanceGroupIdList</c> takes precedence.</para>
        /// </summary>
        [NameInMap("InstanceGroupIdList")]
        [Validation(Required=false)]
        public List<string> InstanceGroupIdList { get; set; }

        /// <summary>
        /// <para>A list of instance IDs. You must specify either this parameter or <c>InstanceGroupIdList</c>. If you specify both, only <c>InstanceGroupIdList</c> takes precedence.</para>
        /// </summary>
        [NameInMap("InstanceIdList")]
        [Validation(Required=false)]
        public List<string> InstanceIdList { get; set; }

    }

}
