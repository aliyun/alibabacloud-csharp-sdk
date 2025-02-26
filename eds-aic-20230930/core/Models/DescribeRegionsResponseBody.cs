// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eds_aic20230930.Models
{
    public class DescribeRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>Available regions.</para>
        /// </summary>
        [NameInMap("RegionModels")]
        [Validation(Required=false)]
        public List<DescribeRegionsResponseBodyRegionModels> RegionModels { get; set; }
        public class DescribeRegionsResponseBodyRegionModels : TeaModel {
            /// <summary>
            /// <para>Region ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A87B3769-0D05-5383-B236-5798B455****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
