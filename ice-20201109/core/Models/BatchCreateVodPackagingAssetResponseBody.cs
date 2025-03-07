// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class BatchCreateVodPackagingAssetResponseBody : TeaModel {
        /// <summary>
        /// <para>The name of the packaging group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>vod_hls</para>
        /// </summary>
        [NameInMap("GroupName")]
        [Validation(Required=false)]
        public string GroupName { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3B-0E1A-586A-AC29-742247</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The results of asset ingestion.</para>
        /// </summary>
        [NameInMap("ResultList")]
        [Validation(Required=false)]
        public List<BatchCreateVodPackagingAssetResponseBodyResultList> ResultList { get; set; }
        public class BatchCreateVodPackagingAssetResponseBodyResultList : TeaModel {
            /// <summary>
            /// <para>The information about the ingested asset.</para>
            /// </summary>
            [NameInMap("Asset")]
            [Validation(Required=false)]
            public VodPackagingAsset Asset { get; set; }

            /// <summary>
            /// <para>The error code for failed ingestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>InvalidParameter.PackagingAssetAlreadyExists</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The error message for failed ingestion.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The specified packagingAsset &quot;inputMovie&quot; already exists</para>
            /// </summary>
            [NameInMap("Message")]
            [Validation(Required=false)]
            public string Message { get; set; }

        }

    }

}
