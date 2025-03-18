// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hologram20220601.Models
{
    public class ChangeResourceGroupRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hgprecn-cn-zvp25ysv3006</para>
        /// </summary>
        [NameInMap("instanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>new resource group id</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-acfmxwerqwerasfd</para>
        /// </summary>
        [NameInMap("newResourceGroupId")]
        [Validation(Required=false)]
        public string NewResourceGroupId { get; set; }

    }

}
