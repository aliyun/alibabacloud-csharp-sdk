// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAutoGroupingConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable existing associated resources to follow the group transfer task. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false: Existing associated resources do not follow the group transfer task.</description></item>
        /// <item><description>true: Existing associated resources follow the group transfer task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("EnableExistingResourcesTransfer")]
        [Validation(Required=false)]
        public bool? EnableExistingResourcesTransfer { get; set; }

    }

}
