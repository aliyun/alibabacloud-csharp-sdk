// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryLlmCubeWithThemeListByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EE822B***************F-F5B42DDADC12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The list of datasets and analysis themes.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLlmCubeWithThemeListByUserIdResponseBodyResult Result { get; set; }
        public class QueryLlmCubeWithThemeListByUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The dataset map.</para>
            /// <list type="bullet">
            /// <item><description>key: The dataset ID.</description></item>
            /// <item><description>value: The dataset name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;4d93****<em><b>0-9614-c97adea37911&quot;:&quot;common</b></em>value&quot;}</para>
            /// </summary>
            [NameInMap("CubeIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> CubeIds { get; set; }

            /// <summary>
            /// <para>The analysis theme map.</para>
            /// <list type="bullet">
            /// <item><description>key: The analysis theme ID. </description></item>
            /// <item><description>value: The analysis theme name.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>{&quot;9aefb3***<em><b><b><b><b>75abecbe&quot;:&quot;www</b></b></b></b></em>eeee&quot;}</para>
            /// </summary>
            [NameInMap("ThemeIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> ThemeIds { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request is successful.</description></item>
        /// <item><description>false: The request fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
