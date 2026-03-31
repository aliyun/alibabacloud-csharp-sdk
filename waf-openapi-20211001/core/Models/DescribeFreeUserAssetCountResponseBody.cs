// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Waf_openapi20211001.Models
{
    public class DescribeFreeUserAssetCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The asset statistics provided by basic detection.</para>
        /// </summary>
        [NameInMap("Asset")]
        [Validation(Required=false)]
        public DescribeFreeUserAssetCountResponseBodyAsset Asset { get; set; }
        public class DescribeFreeUserAssetCountResponseBodyAsset : TeaModel {
            /// <summary>
            /// <para>The number of active APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>34</para>
            /// </summary>
            [NameInMap("AssetActive")]
            [Validation(Required=false)]
            public long? AssetActive { get; set; }

            /// <summary>
            /// <para>The total number of APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15</para>
            /// </summary>
            [NameInMap("AssetCount")]
            [Validation(Required=false)]
            public long? AssetCount { get; set; }

            /// <summary>
            /// <para>The number of deactivated APIs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>13</para>
            /// </summary>
            [NameInMap("AssetOffline")]
            [Validation(Required=false)]
            public long? AssetOffline { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30488BF0-FD58-52DD-B396-D014549F43A3</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
