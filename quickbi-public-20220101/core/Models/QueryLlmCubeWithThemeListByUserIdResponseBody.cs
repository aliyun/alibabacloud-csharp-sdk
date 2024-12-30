// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryLlmCubeWithThemeListByUserIdResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>2EE822B***************F-F5B42DDADC12</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Result")]
        [Validation(Required=false)]
        public QueryLlmCubeWithThemeListByUserIdResponseBodyResult Result { get; set; }
        public class QueryLlmCubeWithThemeListByUserIdResponseBodyResult : TeaModel {
            [NameInMap("CubeIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> CubeIds { get; set; }

            [NameInMap("ThemeIds")]
            [Validation(Required=false)]
            public Dictionary<string, string> ThemeIds { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
