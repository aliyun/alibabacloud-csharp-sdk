// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNest20210601.Models
{
    public class ListSkillFilesResponseBody : TeaModel {
        /// <summary>
        /// <para>The maximum number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to retrieve the next page of results. This token is returned only when more results are available.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAWns8w4MmhzeptXVRG0PUEU=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2849EE73-AFFA-5AFD-9575-12FA886451DA</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The Skill files.</para>
        /// </summary>
        [NameInMap("SkillFiles")]
        [Validation(Required=false)]
        public List<ListSkillFilesResponseBodySkillFiles> SkillFiles { get; set; }
        public class ListSkillFilesResponseBodySkillFiles : TeaModel {
            /// <summary>
            /// <para>The relative path of the file within the Skill.</para>
            /// 
            /// <b>Example:</b>
            /// <para>SKILL.md</para>
            /// </summary>
            [NameInMap("FilePath")]
            [Validation(Required=false)]
            public string FilePath { get; set; }

            /// <summary>
            /// <para>The pre-signed URL for accessing the file in OSS.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/SKILL.md">https://embedding-pic.oss-cn-beijing-internal.aliyuncs.com/SKILL.md</a></para>
            /// </summary>
            [NameInMap("SignedUrl")]
            [Validation(Required=false)]
            public string SignedUrl { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries that match the query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
