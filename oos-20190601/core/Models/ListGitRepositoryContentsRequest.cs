// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListGitRepositoryContentsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dev</para>
        /// </summary>
        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dir</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>6fekfmnfll135123kdf33</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dhuai</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dir1</para>
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

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
        /// <para>LYH-RAIN/vue-color-avatar</para>
        /// </summary>
        [NameInMap("RepoFullName")]
        [Validation(Required=false)]
        public string RepoFullName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2642213</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public long? RepoId { get; set; }

    }

}
