// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20240330.Models
{
    public class GetRumSymbolFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The list of symbol files.</para>
        /// </summary>
        [NameInMap("files")]
        [Validation(Required=false)]
        public List<GetRumSymbolFilesResponseBodyFiles> Files { get; set; }
        public class GetRumSymbolFilesResponseBodyFiles : TeaModel {
            /// <summary>
            /// <para>The object path of the symbol file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user/workspace/service-id/3.0.0/build-1/new-app.map</para>
            /// </summary>
            [NameInMap("artifactPath")]
            [Validation(Required=false)]
            public string ArtifactPath { get; set; }

            /// <summary>
            /// <para>The type of the symbol file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>map</para>
            /// </summary>
            [NameInMap("artifactType")]
            [Validation(Required=false)]
            public string ArtifactType { get; set; }

            /// <summary>
            /// <para>The name of the symbol file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>new-app.map</para>
            /// </summary>
            [NameInMap("fileName")]
            [Validation(Required=false)]
            public string FileName { get; set; }

            /// <summary>
            /// <para>The list of matched search keywords.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[&quot;new-app&quot;]</para>
            /// </summary>
            [NameInMap("matchedKeywords")]
            [Validation(Required=false)]
            public List<string> MatchedKeywords { get; set; }

            /// <summary>
            /// <para>The platform type to which the file belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>web</para>
            /// </summary>
            [NameInMap("platform")]
            [Validation(Required=false)]
            public string Platform { get; set; }

            /// <summary>
            /// <para>The size of the file in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>512</para>
            /// </summary>
            [NameInMap("size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The source of the symbol file. This query API returns only symbol files uploaded by users, which is fixed to user. The value system is reserved for internal system symbols of the platform.</para>
            /// 
            /// <b>Example:</b>
            /// <para>user</para>
            /// </summary>
            [NameInMap("source")]
            [Validation(Required=false)]
            public string Source { get; set; }

            /// <summary>
            /// <para>The timestamp of the last time the file was updated, in milliseconds.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1778806923000</para>
            /// </summary>
            [NameInMap("updateTime")]
            [Validation(Required=false)]
            public long? UpdateTime { get; set; }

            /// <summary>
            /// <para>The UUID or Debug ID of the symbol file.</para>
            /// 
            /// <b>Example:</b>
            /// <para>build-1</para>
            /// </summary>
            [NameInMap("uuid")]
            [Validation(Required=false)]
            public string Uuid { get; set; }

            /// <summary>
            /// <para>The associated application version number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3.0.0</para>
            /// </summary>
            [NameInMap("version")]
            [Validation(Required=false)]
            public string Version { get; set; }

        }

        /// <summary>
        /// <para>Indicates whether more data is available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("hasMore")]
        [Validation(Required=false)]
        public bool? HasMore { get; set; }

        /// <summary>
        /// <para>The pagination token for the next page. The example is for illustration purposes only and cannot be used for actual queries. To query the next page, use the actual value returned in the response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>next</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("pageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>request-1</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
