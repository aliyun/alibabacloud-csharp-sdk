// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devops20210625.Models
{
    public class CreateMergeRequestRequest : TeaModel {
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
        /// <para>WEB</para>
        /// </summary>
        [NameInMap("createFrom")]
        [Validation(Required=false)]
        public string CreateFrom { get; set; }

        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        [NameInMap("reviewerIds")]
        [Validation(Required=false)]
        public List<string> ReviewerIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sourceBranch</para>
        /// </summary>
        [NameInMap("sourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2369234</para>
        /// </summary>
        [NameInMap("sourceProjectId")]
        [Validation(Required=false)]
        public long? SourceProjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>targetBranch</para>
        /// </summary>
        [NameInMap("targetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2369234</para>
        /// </summary>
        [NameInMap("targetProjectId")]
        [Validation(Required=false)]
        public long? TargetProjectId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>722200214032b6b31e6f1434ab</para>
        /// </summary>
        [NameInMap("workItemIds")]
        [Validation(Required=false)]
        public string WorkItemIds { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6270e731cfea268afc21ccac</para>
        /// </summary>
        [NameInMap("organizationId")]
        [Validation(Required=false)]
        public string OrganizationId { get; set; }

    }

}
