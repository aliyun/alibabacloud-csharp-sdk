// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Devs20230714.Models
{
    public class WebhookCodeContext : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("branch")]
        [Validation(Required=false)]
        public string Branch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>b1dd9ba168dfef1cb3a1dd608b6054c771a93959</para>
        /// </summary>
        [NameInMap("commitID")]
        [Validation(Required=false)]
        public string CommitID { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my PR decscription</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>PUSH</para>
        /// </summary>
        [NameInMap("eventType")]
        [Validation(Required=false)]
        public string EventType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>commit message</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>merged</para>
        /// </summary>
        [NameInMap("prType")]
        [Validation(Required=false)]
        public string PrType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://codeup.aliyun.com/my-namespace/my-repo.git">https://codeup.aliyun.com/my-namespace/my-repo.git</a></para>
        /// </summary>
        [NameInMap("repoUrl")]
        [Validation(Required=false)]
        public string RepoUrl { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("sourceBranch")]
        [Validation(Required=false)]
        public string SourceBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>release-0.0.1</para>
        /// </summary>
        [NameInMap("tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>master</para>
        /// </summary>
        [NameInMap("targetBranch")]
        [Validation(Required=false)]
        public string TargetBranch { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <h1>FIX</h1>
        /// </summary>
        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
