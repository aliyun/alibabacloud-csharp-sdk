// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class DeleteOpsItemsRequest : TeaModel {
        /// <summary>
        /// <para>The IDs of O\&amp;M items.</para>
        /// </summary>
        [NameInMap("OpsItemIds")]
        [Validation(Required=false)]
        public List<string> OpsItemIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
