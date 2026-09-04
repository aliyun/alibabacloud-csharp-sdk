// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CodeSec20260401.Models
{
    public class CreateCodeBundleRequest : TeaModel {
        /// <summary>
        /// <para>Optional CI/CD metadata JSON, stored as-is on the <c>code_bundles</c> row.
        /// Used by downstream scan creation for incremental diff, branch tracking, and audit.
        /// Typical structure: <c>{&quot;scan_mode&quot;: {&quot;type&quot;: &quot;full&quot;|&quot;incremental&quot;, &quot;base_ref&quot;: &quot;...&quot;, &quot;base_commit&quot;: &quot;...&quot;, &quot;head_commit&quot;: &quot;...&quot;}, &quot;context&quot;: {&quot;repository&quot;: &quot;...&quot;, &quot;branch&quot;: &quot;...&quot;, &quot;commit&quot;: &quot;...&quot;, &quot;pipeline_source&quot;: &quot;...&quot;, &quot;merge_request_iid&quot;: 123, &quot;default_branch&quot;: &quot;main&quot;}, &quot;client&quot;: {&quot;name&quot;: &quot;krypton-cli&quot;, &quot;version&quot;: &quot;0.2.0&quot;, &quot;os&quot;: &quot;linux&quot;, &quot;arch&quot;: &quot;amd64&quot;}}</c>.
        /// Backend does not validate internal fields; clients may add arbitrary keys.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;region&quot;:&quot;cn-beijing&quot;}</para>
        /// </summary>
        [NameInMap("ciMetadata")]
        [Validation(Required=false)]
        public string CiMetadata { get; set; }

        /// <summary>
        /// <para>Original archive file name; used to derive OSS key suffix (e.g. <c>.zip</c>, <c>.tar.gz</c>).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-cases.zip</para>
        /// </summary>
        [NameInMap("filename")]
        [Validation(Required=false)]
        public string Filename { get; set; }

    }

}
