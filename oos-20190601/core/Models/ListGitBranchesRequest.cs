// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class ListGitBranchesRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>TF-CreateApplication-1647587475-84104b89-eba5-47a8-b2fd-807b8b7d</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

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
        /// <para>geegenw-j-imwinmtuej</para>
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
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>alibaba/fastjson</para>
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
