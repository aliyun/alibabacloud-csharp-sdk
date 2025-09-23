// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudRegionResponseBody : TeaModel {
        [NameInMap("CrossCloudRegionList")]
        [Validation(Required=false)]
        public List<DescribeCrossCloudRegionResponseBodyCrossCloudRegionList> CrossCloudRegionList { get; set; }
        public class DescribeCrossCloudRegionResponseBodyCrossCloudRegionList : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-east-3</para>
            /// </summary>
            [NameInMap("CrossCloudRegionId")]
            [Validation(Required=false)]
            public string CrossCloudRegionId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>cn-east-3</para>
            /// </summary>
            [NameInMap("CrossCloudRegionName")]
            [Validation(Required=false)]
            public string CrossCloudRegionName { get; set; }

            [NameInMap("CrossCloudZoneList")]
            [Validation(Required=false)]
            public List<DescribeCrossCloudRegionResponseBodyCrossCloudRegionListCrossCloudZoneList> CrossCloudZoneList { get; set; }
            public class DescribeCrossCloudRegionResponseBodyCrossCloudRegionListCrossCloudZoneList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-east-3-1</para>
                /// </summary>
                [NameInMap("CrossCloudZoneId")]
                [Validation(Required=false)]
                public string CrossCloudZoneId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>cn-east-3-1</para>
                /// </summary>
                [NameInMap("CrossCloudZoneName")]
                [Validation(Required=false)]
                public string CrossCloudZoneName { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>pj-87681rbcef6******</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

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
