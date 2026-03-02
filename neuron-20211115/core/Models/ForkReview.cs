// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Neuron20211115.Models
{
    public class ForkReview : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>旭坤</para>
        /// </summary>
        [NameInMap("applicant")]
        [Validation(Required=false)]
        public string Applicant { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("forkId")]
        [Validation(Required=false)]
        public long? ForkId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>global-mall</para>
        /// </summary>
        [NameInMap("gitGroup")]
        [Validation(Required=false)]
        public string GitGroup { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>product</para>
        /// </summary>
        [NameInMap("pbcName")]
        [Validation(Required=false)]
        public string PbcName { get; set; }

        [NameInMap("repoUrls")]
        [Validation(Required=false)]
        public List<string> RepoUrls { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>中驿</para>
        /// </summary>
        [NameInMap("reviewer")]
        [Validation(Required=false)]
        public string Reviewer { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>194835334</para>
        /// </summary>
        [NameInMap("reviewerId")]
        [Validation(Required=false)]
        public string ReviewerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>待审核</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>商城国际化版本</para>
        /// </summary>
        [NameInMap("usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
