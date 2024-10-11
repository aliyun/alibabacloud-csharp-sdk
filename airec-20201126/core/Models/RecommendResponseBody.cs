// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class RecommendResponseBody : TeaModel {
        /// <summary>
        /// <para>This parameter may be used in the debugging process. You can ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>Queries the recommendation results of a specified instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;i2i_common_common;NotFound;1673254401;similar product/content of clicked ones;2023-01-09 16:53:21&quot;</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The weight of the specified process.</para>
        /// 
        /// <b>Example:</b>
        /// <para>04707E49-642A-4649-827A-F8EEB07D4C27</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The unique ID of the user.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<RecommendResponseBodyResult> Result { get; set; }
        public class RecommendResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The ID of the device.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("flowWeight")]
            [Validation(Required=false)]
            public double? FlowWeight { get; set; }

            /// <summary>
            /// <para>The returned results.</para>
            /// 
            /// <b>Example:</b>
            /// <para>123</para>
            /// </summary>
            [NameInMap("itemId")]
            [Validation(Required=false)]
            public string ItemId { get; set; }

            /// <summary>
            /// <para>The ID of the recommended item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>item</para>
            /// </summary>
            [NameInMap("itemType")]
            [Validation(Required=false)]
            public string ItemType { get; set; }

            /// <summary>
            /// <para>N/A</para>
            /// 
            /// <b>Example:</b>
            /// <para>xxx</para>
            /// </summary>
            [NameInMap("matchInfo")]
            [Validation(Required=false)]
            public string MatchInfo { get; set; }

            /// <summary>
            /// <para>The event tracking ID. This parameter is uploaded together with user behaviors on the recommended item. In this case, the value of this parameter is ali.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Successful</para>
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// <para>The string for filtering during recommendation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("position")]
            [Validation(Required=false)]
            public int? Position { get; set; }

            /// <summary>
            /// <para>The status of the execution.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ali</para>
            /// </summary>
            [NameInMap("traceId")]
            [Validation(Required=false)]
            public string TraceId { get; set; }

            /// <summary>
            /// <para>Specifies whether to perform personalized ranking based on the user IDs in the filtering and ranking phases.</para>
            /// 
            /// <b>Example:</b>
            /// <para>&quot;1007.62381.131491.100200300000000:bcb946ed-3f09-4e9b-bf4a-c19862f42231:792783::0:s101:::15:content___130788_stall:item:i2i_common_common:0.0205279946753756:null:null:1673258031504::context__recall_index=156,context__hour=17,context__trigger_num=2::C7EF99C9-6C55-5D45-A8D5-0754082E9DCF:hot_common,i2i_common_common,i2i_swing_common,hot_full:::::&quot;</para>
            /// </summary>
            [NameInMap("traceInfo")]
            [Validation(Required=false)]
            public string TraceInfo { get; set; }

            /// <summary>
            /// <para>The weight of the recommended item.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("weight")]
            [Validation(Required=false)]
            public float? Weight { get; set; }

        }

    }

}
