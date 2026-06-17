// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardb20170801.Models
{
    public class DescribeCrossCloudRegionResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the cross-cloud regions.</para>
        /// </summary>
        [NameInMap("CrossCloudRegionList")]
        [Validation(Required=false)]
        public List<DescribeCrossCloudRegionResponseBodyCrossCloudRegionList> CrossCloudRegionList { get; set; }
        public class DescribeCrossCloudRegionResponseBodyCrossCloudRegionList : TeaModel {
            /// <summary>
            /// <para>The ID of the third-party cloud region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-east-3</para>
            /// </summary>
            [NameInMap("CrossCloudRegionId")]
            [Validation(Required=false)]
            public string CrossCloudRegionId { get; set; }

            /// <summary>
            /// <para>The name of the third-party cloud region.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-east-3</para>
            /// </summary>
            [NameInMap("CrossCloudRegionName")]
            [Validation(Required=false)]
            public string CrossCloudRegionName { get; set; }

            /// <summary>
            /// <para>A list of third-party cloud zones.</para>
            /// </summary>
            [NameInMap("CrossCloudZoneList")]
            [Validation(Required=false)]
            public List<DescribeCrossCloudRegionResponseBodyCrossCloudRegionListCrossCloudZoneList> CrossCloudZoneList { get; set; }
            public class DescribeCrossCloudRegionResponseBodyCrossCloudRegionListCrossCloudZoneList : TeaModel {
                /// <summary>
                /// <para>The ID of the third-party cloud zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-east-3-1</para>
                /// </summary>
                [NameInMap("CrossCloudZoneId")]
                [Validation(Required=false)]
                public string CrossCloudZoneId { get; set; }

                /// <summary>
                /// <para>The name of the third-party cloud zone.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-east-3-1</para>
                /// </summary>
                [NameInMap("CrossCloudZoneName")]
                [Validation(Required=false)]
                public string CrossCloudZoneName { get; set; }

            }

            /// <summary>
            /// <para>The resource pool ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>pj-87681rbcef6******</para>
            /// </summary>
            [NameInMap("ProjectId")]
            [Validation(Required=false)]
            public string ProjectId { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E56531A4-E552-40BA-9C58-137B80******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
