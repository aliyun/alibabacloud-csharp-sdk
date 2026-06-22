// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RefreshContainerAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The Asset Type of the container asset to refresh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IMAGE</b>: container image.</description></item>
        /// <item><description><b>CONTAINER</b>: container.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>IMAGE</para>
        /// </summary>
        [NameInMap("AssetType")]
        [Validation(Required=false)]
        public string AssetType { get; set; }

    }

}
