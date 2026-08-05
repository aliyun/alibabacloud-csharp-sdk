// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Kms20160120.Models
{
    public class ListSecretVersionIdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The current page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The page size of the current page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request. The ID is a unique identifier that Alibaba Cloud generates for the request and can be used to troubleshoot issues.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b75d8b1-5b6a-4ec0-8e0c-c08befdfad47</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The secret name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>secret001</para>
        /// </summary>
        [NameInMap("SecretName")]
        [Validation(Required=false)]
        public string SecretName { get; set; }

        /// <summary>
        /// <para>The total number of entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

        [NameInMap("VersionIds")]
        [Validation(Required=false)]
        public ListSecretVersionIdsResponseBodyVersionIds VersionIds { get; set; }
        public class ListSecretVersionIdsResponseBodyVersionIds : TeaModel {
            [NameInMap("VersionId")]
            [Validation(Required=false)]
            public List<ListSecretVersionIdsResponseBodyVersionIdsVersionId> VersionId { get; set; }
            public class ListSecretVersionIdsResponseBodyVersionIdsVersionId : TeaModel {
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public string CreateTime { get; set; }

                [NameInMap("VersionId")]
                [Validation(Required=false)]
                public string VersionId { get; set; }

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
