// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<ListParamsResponseBodyParams> Params { get; set; }
        public class ListParamsResponseBodyParams : TeaModel {
            /// <summary>
            /// <para>The environment to which the parameter belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>Daily: A test environment for daily use.</para>
            /// </description></item>
            /// <item><description><para>Prepub: A staging environment that mirrors the production environment.</para>
            /// </description></item>
            /// <item><description><para>Product: The production environment.</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("Environment")]
            [Validation(Required=false)]
            public string Environment { get; set; }

            /// <summary>
            /// <para>The time when the parameter was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The parameter name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>home</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The parameter ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>4</para>
            /// </summary>
            [NameInMap("ParamId")]
            [Validation(Required=false)]
            public string ParamId { get; set; }

            /// <summary>
            /// <para>The parameter value.</para>
            /// 
            /// <b>Example:</b>
            /// <para>house</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2D07551-38DA-531E-9B22-877D1D86A579</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
