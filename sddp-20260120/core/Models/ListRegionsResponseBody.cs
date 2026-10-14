// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListRegionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of regions where assets reside.</para>
        /// </summary>
        [NameInMap("RegionList")]
        [Validation(Required=false)]
        public List<ListRegionsResponseBodyRegionList> RegionList { get; set; }
        public class ListRegionsResponseBodyRegionList : TeaModel {
            /// <summary>
            /// <para>The region ID where the assets reside.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-zhangjiakou</para>
            /// </summary>
            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            /// <summary>
            /// <para>The name of the region where the assets reside.</para>
            /// 
            /// <b>Example:</b>
            /// <para>China North 3 (Zhangjiakou)</para>
            /// </summary>
            [NameInMap("RegionName")]
            [Validation(Required=false)]
            public string RegionName { get; set; }

        }

        /// <summary>
        /// <para>The request ID, which can be used to locate this API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
