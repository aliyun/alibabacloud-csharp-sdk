// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class ListMergeRequestFilesReadsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>agp_4d57a6796b3626f52064ab1fba5384a5</para>
        /// </summary>
        [NameInMap("accessToken")]
        [Validation(Required=false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5e733626d53f4b04a6aa0e23d4ff72b8</para>
        /// </summary>
        [NameInMap("fromPatchSetBizId")]
        [Validation(Required=false)]
        public string FromPatchSetBizId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("localId")]
        [Validation(Required=false)]
        public long? LocalId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>60de7a6852743a5162b5f957</para>
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

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>513fcfd81a9142d2bb0db4f72c0aa15b</para>
        /// </summary>
        [NameInMap("toPatchSetBizId")]
        [Validation(Required=false)]
        public string ToPatchSetBizId { get; set; }

    }

}
