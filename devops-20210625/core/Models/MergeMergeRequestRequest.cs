// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class MergeMergeRequestRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>0cf2c8458ac44d9481aab2dd6ec10596v3</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>&quot;&quot;</para>
        /// </summary>
        [NameInMap("mergeMessage")]
        [Validation(Required=false)]
        public string MergeMessage { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>no-fast-forward</para>
        /// </summary>
        [NameInMap("mergeType")]
        [Validation(Required=false)]
        public string MergeType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("removeSourceBranch")]
        [Validation(Required=false)]
        public bool? RemoveSourceBranch { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60de7a6852743a5162b5f957</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
