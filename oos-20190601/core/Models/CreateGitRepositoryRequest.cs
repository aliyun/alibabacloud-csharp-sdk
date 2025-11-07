// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class CreateGitRepositoryRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TF-CreateApplication-1647587475-84104b89-eba5-47a8-b2fd-807b8b7d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("IsPrivate")]
        [Validation(Required=false)]
        public bool? IsPrivate { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5ffd468b1e45db3c1cc26ad6</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JJGGu</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gitee</para>
        /// </summary>
        [NameInMap("Platform")]
        [Validation(Required=false)]
        public string Platform { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("SourceRepoBranch")]
        [Validation(Required=false)]
        public string SourceRepoBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-repo</para>
        /// </summary>
        [NameInMap("SourceRepoName")]
        [Validation(Required=false)]
        public string SourceRepoName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>aliyun-computenest</para>
        /// </summary>
        [NameInMap("SourceRepoOwner")]
        [Validation(Required=false)]
        public string SourceRepoOwner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>test-repo</para>
        /// </summary>
        [NameInMap("TargetRepoName")]
        [Validation(Required=false)]
        public string TargetRepoName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>namexx</para>
        /// </summary>
        [NameInMap("TargetRepoOwner")]
        [Validation(Required=false)]
        public string TargetRepoOwner { get; set; }

    }

}
