// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class QuerySearchLibResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The index information.</para>
        /// </summary>
        [NameInMap("IndexInfo")]
        [Validation(Required=false)]
        public List<QuerySearchLibResponseBodyIndexInfo> IndexInfo { get; set; }
        public class QuerySearchLibResponseBodyIndexInfo : TeaModel {
            /// <summary>
            /// <para>The readiness status of the index. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Initializing: The index is being initialized.</para>
            /// </description></item>
            /// <item><description><para>Normal: The index is ready.</para>
            /// </description></item>
            /// <item><description><para>Fail: The index failed to be created.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Normal</para>
            /// </summary>
            [NameInMap("IndexReadiness")]
            [Validation(Required=false)]
            public string IndexReadiness { get; set; }

            /// <summary>
            /// <para>The status of the index. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Active: The index is active.</para>
            /// </description></item>
            /// <item><description><para>Deactive: The index is inactive.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("IndexStatus")]
            [Validation(Required=false)]
            public string IndexStatus { get; set; }

            /// <summary>
            /// <para>The index type. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>mm: Large language model (LLM).</para>
            /// </description></item>
            /// <item><description><para>face: Face recognition.</para>
            /// </description></item>
            /// <item><description><para>aiLabel: Smart tagging.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>face</para>
            /// </summary>
            [NameInMap("IndexType")]
            [Validation(Required=false)]
            public string IndexType { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>11-DB8D-4A9A-875B-275798</b></b></b></para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The search library configuration.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;faceGroupIds&quot;:&quot;xxx1,xxx2,xx3&quot;}</para>
        /// </summary>
        [NameInMap("SearchLibConfig")]
        [Validation(Required=false)]
        public string SearchLibConfig { get; set; }

        /// <summary>
        /// <para>The name of the search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test1</para>
        /// </summary>
        [NameInMap("SearchLibName")]
        [Validation(Required=false)]
        public string SearchLibName { get; set; }

        /// <summary>
        /// <para>The status of the search library.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>Indicates whether the call was successful.</para>
        /// <list type="bullet">
        /// <item><description><para><b>true</b>: The call was successful.</para>
        /// </description></item>
        /// <item><description><para><b>false</b>: The call failed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public string Success { get; set; }

    }

}
