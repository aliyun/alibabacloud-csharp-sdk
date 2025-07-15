// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class DescribeLiveStreamsTotalCountResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>String	FCFFE4A4-F34F-4EEF-B401-36A01689AFBC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The statistics about the live streams.</para>
        /// </summary>
        [NameInMap("StreamCountList")]
        [Validation(Required=false)]
        public DescribeLiveStreamsTotalCountResponseBodyStreamCountList StreamCountList { get; set; }
        public class DescribeLiveStreamsTotalCountResponseBodyStreamCountList : TeaModel {
            [NameInMap("StreamCountInfos")]
            [Validation(Required=false)]
            public List<DescribeLiveStreamsTotalCountResponseBodyStreamCountListStreamCountInfos> StreamCountInfos { get; set; }
            public class DescribeLiveStreamsTotalCountResponseBodyStreamCountListStreamCountInfos : TeaModel {
                /// <summary>
                /// <para>The total number of live streams.</para>
                /// 
                /// <b>Example:</b>
                /// <para>934</para>
                /// </summary>
                [NameInMap("Count")]
                [Validation(Required=false)]
                public int? Count { get; set; }

                /// <summary>
                /// <para>The timestamp.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-07-24T16:00:00Z</para>
                /// </summary>
                [NameInMap("Timestamp")]
                [Validation(Required=false)]
                public string Timestamp { get; set; }

            }

        }

    }

}
