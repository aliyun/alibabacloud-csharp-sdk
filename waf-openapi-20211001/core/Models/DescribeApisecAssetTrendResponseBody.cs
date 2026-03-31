// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeApisecAssetTrendResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeApisecAssetTrendResponseBodyData> Data { get; set; }
        public class DescribeApisecAssetTrendResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The number of active assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>60</para>
            /// </summary>
            [NameInMap("AssetActive")]
            [Validation(Required=false)]
            public long? AssetActive { get; set; }

            /// <summary>
            /// <para>The total number of assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public long? AssetCount { get; set; }

            /// <summary>
            /// <para>The number of deactivated assets.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("AssetOffline")]
            [Validation(Required=false)]
            public long? AssetOffline { get; set; }

            /// <summary>
            /// <para>The time for statistics. Specify a UNIX timestamp in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1683600042</para>
            /// </summary>
            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        /// <summary>
        /// <para>Id of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D7861F61-5B61-46CE-A47C-6B19****5EB0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
