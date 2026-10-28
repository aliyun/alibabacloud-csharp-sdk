// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.PaiRecService20221213.Models
{
    public class ListParamsResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of parameters.</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public List<ListParamsResponseBodyParams> Params { get; set; }
        public class ListParamsResponseBodyParams : TeaModel {
            /// <summary>
            /// <para>The environment to which the parameter belongs. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Daily: daily environment</description></item>
            /// <item><description>Prepub: staging environment</description></item>
            /// <item><description>Product: production environment</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Daily</para>
            /// </summary>
            [NameInMap("Environment")]
            [Validation(Required=false)]
            public string Environment { get; set; }

            /// <summary>
            /// <para>The update time. The time follows the ISO 8601 standard and includes the time zone offset.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-12-15T23:24:33.132+08:00</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The name of the parameter.</para>
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
            /// <para>The value of the parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>house</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>A2D07551-38DA-531E-9B22-877D1D86A579</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of elements in the list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
