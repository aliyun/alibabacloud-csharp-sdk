// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceManager20200331.Models
{
    public class UpdateAutoGroupingConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to enable the Transfer Existing Associated Resources feature. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>false</description></item>
        /// <item><description>true</description></item>
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
