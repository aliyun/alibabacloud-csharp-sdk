// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeUserAssetResponseBody : TeaModel {
        /// <summary>
        /// <para>The API statistics.</para>
        /// </summary>
        [NameInMap("Assets")]
        [Validation(Required=false)]
        public List<DescribeUserAssetResponseBodyAssets> Assets { get; set; }
        public class DescribeUserAssetResponseBodyAssets : TeaModel {
            /// <summary>
            /// <para>The number of APIs returned.</para>
            /// 
            /// <b>Example:</b>
            /// <para>134</para>
            /// </summary>
            [NameInMap("AssetNum")]
            [Validation(Required=false)]
            public long? AssetNum { get; set; }

            /// <summary>
            /// <para>The time at which the API was called. The value is a UNIX timestamp displayed in UTC. Unit: seconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1723435200</para>
            /// </summary>
            [NameInMap("TimeStamp")]
            [Validation(Required=false)]
            public long? TimeStamp { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>C1823E96-EF4B-5BD2-9E02-1D18****3ED8</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
