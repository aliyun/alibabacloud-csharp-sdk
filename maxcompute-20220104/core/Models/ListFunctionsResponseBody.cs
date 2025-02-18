// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.MaxCompute20220104.Models
{
    public class ListFunctionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The returned data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public ListFunctionsResponseBodyData Data { get; set; }
        public class ListFunctionsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The information about each function.</para>
            /// </summary>
            [NameInMap("functions")]
            [Validation(Required=false)]
            public List<ListFunctionsResponseBodyDataFunctions> Functions { get; set; }
            public class ListFunctionsResponseBodyDataFunctions : TeaModel {
                /// <summary>
                /// <para>The class in which the function was defined.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("class")]
                [Validation(Required=false)]
                public string Class { get; set; }

                /// <summary>
                /// <para>The time when the function was created. Unit: milliseconds.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1664505167000</para>
                /// </summary>
                [NameInMap("creationTime")]
                [Validation(Required=false)]
                public long? CreationTime { get; set; }

                /// <summary>
                /// <para>The display name of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>getdate</para>
                /// </summary>
                [NameInMap("displayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The name of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>getdate</para>
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// <para>The owner of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>odpsowner</para>
                /// </summary>
                [NameInMap("owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// <para>The name of the resource that was associated with the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("resources")]
                [Validation(Required=false)]
                public string Resources { get; set; }

                /// <summary>
                /// <para>The schema of the function.</para>
                /// 
                /// <b>Example:</b>
                /// <para>abc</para>
                /// </summary>
                [NameInMap("schema")]
                [Validation(Required=false)]
                public string Schema { get; set; }

            }

            /// <summary>
            /// <para>Indicates the marker after which the returned list begins.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cHlvZHBzX3VkZl8xMDExNV8xNDU3NDI4NDkzKg==</para>
            /// </summary>
            [NameInMap("marker")]
            [Validation(Required=false)]
            public string Marker { get; set; }

            /// <summary>
            /// <para>The maximum number of entries returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("maxItem")]
            [Validation(Required=false)]
            public int? MaxItem { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0be3e0b716671885050924814e3623</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
