// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DescribeDiscoveredResourceBatchRequest : TeaModel {
        /// <summary>
        /// <para>The regions where the resources reside. Separate multiple regions with commas (<c>,</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai,cn-hongkong,cn-zhangjiakou,cn-hangzhou</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// <para>The resource IDs. Separate multiple resource IDs with commas (<c>,</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-wz998f311e21****,r-wz97f4a73478****</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <para>The resource types. Separate multiple resource types with commas (<c>,</c>).</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACS::ECS::Disk,ACS::ECS::Instance</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
