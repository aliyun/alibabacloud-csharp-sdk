// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Edas20170801.Models
{
    public class ListSwimmingLaneGroupRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the lane group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("GroupId")]
        [Validation(Required=false)]
        public long? GroupId { get; set; }

        /// <summary>
        /// <para>The ID of the namespace.</para>
        /// <para>The ID of a custom namespace is in the region ID:namespace identifier format. Example: cn-beijing:test.\
        /// The ID of the default namespace is in the region ID format. Example: cn-beijing.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shenzhen:publish</para>
        /// </summary>
        [NameInMap("LogicalRegionId")]
        [Validation(Required=false)]
        public string LogicalRegionId { get; set; }

    }

}
