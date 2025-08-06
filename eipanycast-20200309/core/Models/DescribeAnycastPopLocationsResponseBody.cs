// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eipanycast20200309.Models
{
    public class DescribeAnycastPopLocationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of access points in the specified access area.</para>
        /// </summary>
        [NameInMap("AnycastPopLocationList")]
        [Validation(Required=false)]
        public List<DescribeAnycastPopLocationsResponseBodyAnycastPopLocationList> AnycastPopLocationList { get; set; }
        public class DescribeAnycastPopLocationsResponseBodyAnycastPopLocationList : TeaModel {
            /// <summary>
            /// <para>The ID of the region where the access point is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-west-1-pop</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region where the access point is deployed.</para>
            /// 
            /// <b>Example:</b>
            /// <para>us-west-1-pop</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        /// <summary>
        /// <para>The number of access points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Count")]
        [Validation(Required=false)]
        public string Count { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4EC47282-1B74-4534-BD0E-403F3EE64CAF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
