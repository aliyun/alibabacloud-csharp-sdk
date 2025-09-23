// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudRegionMappingToAliyunRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("AliyunRegionId")]
        [Validation(Required=false)]
        public string AliyunRegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HuaweiCloud</para>
        /// </summary>
        [NameInMap("CloudProvider")]
        [Validation(Required=false)]
        public string CloudProvider { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-east-3</para>
        /// </summary>
        [NameInMap("CrossCloudRegionId")]
        [Validation(Required=false)]
        public string CrossCloudRegionId { get; set; }

    }

}
