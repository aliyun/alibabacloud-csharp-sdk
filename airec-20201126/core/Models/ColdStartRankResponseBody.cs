// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ColdStartRankResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>8F81A922-6C81-46D6-B78C-CC35E16B1691</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ColdStartRankResponseBodyResult> Result { get; set; }
        public class ColdStartRankResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>3_Lwm4vy1</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>article</para>
            /// </summary>
            [NameInMap("itemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>1007.62364.131773.100200300000000:d709586e-643c-4fcb-a35c-6c5e8cd6756e:Grr8KG::0:sy_list_gul:::1:content___3_Lwm4vy:article:i2i_common_common:9.385107352002104E-4:0.25131988525390625:null:1677207034118::context__recall_index=253,context__hour=10,context__trigger_num=2::002bc90e-0d30-4682-9de3-1f4bad73702e:i2i_scategory_common,hot_common,i2i_common_common,i2i_swing_common:::::</para>
            /// </summary>
            [NameInMap("traceInfo")]
            [Validation(Required=false)]
            public string TraceInfo { get; set; }

        }

    }

}
