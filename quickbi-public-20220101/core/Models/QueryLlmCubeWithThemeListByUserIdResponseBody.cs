// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryLlmCubeWithThemeListByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2EE822B***************F-F5B42DDADC12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>List of datasets and analysis themes.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLlmCubeWithThemeListByUserIdResponseBodyResult Result { get; set; }
        public class QueryLlmCubeWithThemeListByUserIdResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>Dataset map.</para>
            /// <list type="bullet">
            /// <item><description>key - Dataset ID</description></item>
            /// <item><description>value - Dataset name</description></item>
            /// </list>
            /// </summary>
            [NameInMap("CubeIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> CubeIds { get; set; }

            /// <summary>
            /// <para>Analysis theme map.</para>
            /// <list type="bullet">
            /// <item><description>key - Analysis theme ID </description></item>
            /// <item><description>value - Analysis theme name</description></item>
            /// </list>
            /// </summary>
            [NameInMap("ThemeIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> ThemeIds { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful</description></item>
        /// <item><description>false: The request failed</description></item>
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
