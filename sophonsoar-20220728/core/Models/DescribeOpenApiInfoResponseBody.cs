// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sophonsoar20220728.Models
{
    public class DescribeOpenApiInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>The data returned.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public DescribeOpenApiInfoResponseBodyData Data { get; set; }
        public class DescribeOpenApiInfoResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The description of the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>describeEcs</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The input parameters of the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{}</para>
            /// </summary>
            [NameInMap("InputParams")]
            [Validation(Required=false)]
            public string InputParams { get; set; }

            /// <summary>
            /// <para>The output parameters of the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("OutputParams")]
            [Validation(Required=false)]
            public string OutputParams { get; set; }

            /// <summary>
            /// <para>The sample response parameters.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[]</para>
            /// </summary>
            [NameInMap("ResponseDemo")]
            [Validation(Required=false)]
            public string ResponseDemo { get; set; }

            /// <summary>
            /// <para>The summary of the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>describeEcs</para>
            /// </summary>
            [NameInMap("Summary")]
            [Validation(Required=false)]
            public string Summary { get; set; }

            /// <summary>
            /// <para>The title of the API operation.</para>
            /// 
            /// <b>Example:</b>
            /// <para>describeEcs</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>358E012F-B516-599D-9ED0-A1A361CDE615</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
