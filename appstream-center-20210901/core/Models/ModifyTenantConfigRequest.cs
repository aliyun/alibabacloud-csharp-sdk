// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Appstream_center20210901.Models
{
    public class ModifyTenantConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the resource expiration reminder feature.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("AppInstanceGroupExpireRemind")]
        [Validation(Required=false)]
        public bool? AppInstanceGroupExpireRemind { get; set; }

    }

}
