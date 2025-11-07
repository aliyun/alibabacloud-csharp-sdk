// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Oos20190601.Models
{
    public class GetGitBranchRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>main</para>
        /// </summary>
        [NameInMap("Branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>5ffd468b1e45db3c1cc26ad6</para>
        /// </summary>
        [NameInMap("OrgId")]
        [Validation(Required=false)]
        public string OrgId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>namexxx</para>
        /// </summary>
        [NameInMap("Owner")]
        [Validation(Required=false)]
        public string Owner { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>github</para>
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
        /// <para>2823742</para>
        /// </summary>
        [NameInMap("RepoId")]
        [Validation(Required=false)]
        public long? RepoId { get; set; }

    }

}
