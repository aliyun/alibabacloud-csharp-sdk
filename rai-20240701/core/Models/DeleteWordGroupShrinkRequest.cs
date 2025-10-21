// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RAI20240701.Models
{
    public class DeleteWordGroupShrinkRequest : TeaModel {
        /// <summary>
        /// <para>List of keyword strategy IDs.</para>
        /// </summary>
        [NameInMap("GroupIdList")]
        [Validation(Required=false)]
        public string GroupIdListShrink { get; set; }

        /// <summary>
        /// <para>Region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
