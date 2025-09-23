// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudRegionMappingToAliyunResponseBody : TeaModel {
        [NameInMap("CrossCloudRegionMappingList")]
        [Validation(Required=false)]
        public List<DescribeCrossCloudRegionMappingToAliyunResponseBodyCrossCloudRegionMappingList> CrossCloudRegionMappingList { get; set; }
        public class DescribeCrossCloudRegionMappingToAliyunResponseBodyCrossCloudRegionMappingList : TeaModel {
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

        /// <summary>
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
