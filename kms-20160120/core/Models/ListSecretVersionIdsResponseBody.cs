// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretVersionIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request, which is used to locate and troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b75d8b1-5b6a-4ec0-8e0c-c08befdfad47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The name of the secret.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The number of entries returned on the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// <para>The list of secret versions.</para>
        /// </summary>
        [NameInMap("VersionIds")]
        [Validation(Required=false)]
        public ListSecretVersionIdsResponseBodyVersionIds VersionIds { get; set; }
        public class ListSecretVersionIdsResponseBodyVersionIds : TeaModel {
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public List<ListSecretVersionIdsResponseBodyVersionIdsVersionId> VersionId { get; set; }
            public class ListSecretVersionIdsResponseBodyVersionIdsVersionId : TeaModel {
                /// <summary>
                /// <para>The time when the secret version was created.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2020-02-21T15:39:26Z</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                /// <summary>
                /// <para>The version number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>00000000000000000000000000000000203</para>
                /// </summary>
                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

                /// <summary>
                /// <para>The stage labels that mark the secret version.</para>
                /// </summary>
                [NameInMap("VersionStages")]
                [Validation(Required=false)]
                public ListSecretVersionIdsResponseBodyVersionIdsVersionIdVersionStages VersionStages { get; set; }
                public class ListSecretVersionIdsResponseBodyVersionIdsVersionIdVersionStages : TeaModel {
                    [NameInMap("VersionStage")]
                    [Validation(Required=false)]
                    public List<string> VersionStage { get; set; }

                }

            }

        }

    }

}
