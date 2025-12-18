// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Config20200907.Models
{
    public class DescribeDiscoveredResourceBatchRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-shanghai,cn-hongkong,cn-zhangjiakou,cn-hangzhou</para>
        /// </summary>
        [NameInMap("Regions")]
        [Validation(Required=false)]
        public string Regions { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>r-wz998f311e21exxx,r-wz97f4a734789xxx</para>
        /// </summary>
        [NameInMap("ResourceIds")]
        [Validation(Required=false)]
        public string ResourceIds { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>ACS::ECS::Disk</para>
        /// </summary>
        [NameInMap("ResourceTypes")]
        [Validation(Required=false)]
        public string ResourceTypes { get; set; }

    }

}
