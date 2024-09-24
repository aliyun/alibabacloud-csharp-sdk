// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class RefreshContainerAssetsRequest : TeaModel {
        /// <summary>
        /// <para>The type of the container asset whose statistics you want to refresh. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>IMAGE</b></description></item>
        /// <item><description><b>CONTAINER</b></description></item>
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
