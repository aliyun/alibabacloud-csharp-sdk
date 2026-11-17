// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class DeleteCloudDriveServicesRequest : TeaModel {
        /// <summary>
        /// <para>The list of Wuying cloud disk IDs.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("CdsId")]
        [Validation(Required=false)]
        public List<string> CdsId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
