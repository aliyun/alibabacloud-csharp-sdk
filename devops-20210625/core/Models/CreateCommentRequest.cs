// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateCommentRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>f0b1e61db5961df5975a93f9129d2513</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>GLOBAL_COMMENT</para>
        /// </summary>
        [NameInMap("commentType")]
        [Validation(Required=false)]
        public string CommentType { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("content")]
        [Validation(Required=false)]
        public string Content { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("draft")]
        [Validation(Required=false)]
        public bool? Draft { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/src/main/test.java</para>
        /// </summary>
        [NameInMap("filePath")]
        [Validation(Required=false)]
        public string FilePath { get; set; }

        [NameInMap("fromPachSetBizId")]
        [Validation(Required=false)]
        public string FromPachSetBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("lineNumber")]
        [Validation(Required=false)]
        public int? LineNumber { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2666ac1ac53841b0ba1b042e383279cc</para>
        /// </summary>
        [NameInMap("parentCommentBizId")]
        [Validation(Required=false)]
        public string ParentCommentBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b7d8386be17c4ca68a07140db4836257</para>
        /// </summary>
        [NameInMap("patchSetBizId")]
        [Validation(Required=false)]
        public string PatchSetBizId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("resolved")]
        [Validation(Required=false)]
        public bool? Resolved { get; set; }

        [NameInMap("toPatchSetBizId")]
        [Validation(Required=false)]
        public string ToPatchSetBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("localId")]
        [Validation(Required=false)]
        public long? LocalId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5ebbc0228123212b59xxxxx</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("repositoryIdentity")]
        [Validation(Required=false)]
        public string RepositoryIdentity { get; set; }

    }

}
