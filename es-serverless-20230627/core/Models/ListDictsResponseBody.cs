// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Es_serverless20230627.Models
{
    public class ListDictsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>E92BCBB9-3CFE-58DD-8D8C-56DF46AB3BF3</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDictsResponseBodyResult> Result { get; set; }
        public class ListDictsResponseBodyResult : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para><a href="http://es-serverless-****.oss-cn-hangzhou.aliyuncs.com/app/es7**190/0/config/analysis-ik/stopword.dic?Expires=1705923089&OSSAccessKeyId=STS.NV18q****UkVp6LNj&Signat">http://es-serverless-****.oss-cn-hangzhou.aliyuncs.com/app/es7**190/0/config/analysis-ik/stopword.dic?Expires=1705923089&amp;OSSAccessKeyId=STS.NV18q****UkVp6LNj&amp;Signat</a></para>
            /// </summary>
            [NameInMap("downloadUrl")]
            [Validation(Required=false)]
            public string DownloadUrl { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>a.dic</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>OSS</para>
            /// </summary>
            [NameInMap("sourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>MAIN</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
