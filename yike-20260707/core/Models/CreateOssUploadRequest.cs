// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Yike20260707.Models
{
    public class CreateOssUploadRequest : TeaModel {
        /// <summary>
        /// <para>The <b>business configuration JSON</b>, which includes ProductionId and FolderId.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;ProductionId&quot;: &quot;pd_***&quot;, &quot;FolderId&quot;: &quot;fd_***&quot;}</para>
        /// </summary>
        [NameInMap("BizConfig")]
        [Validation(Required=false)]
        public string BizConfig { get; set; }

        /// <summary>
        /// <para>The credential type. This is a reserved parameter. The current version always returns STS temporary credentials, and this parameter does not take effect.</para>
        /// 
        /// <b>Example:</b>
        /// <para>STS</para>
        /// </summary>
        [NameInMap("CredentialType")]
        [Validation(Required=false)]
        public string CredentialType { get; set; }

        /// <summary>
        /// <para>The file name extension, such as mp4, wav, or png. Do not include the dot. If this parameter is not specified, <c>MissingParameter</c> is returned.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mp4</para>
        /// </summary>
        [NameInMap("FileExt")]
        [Validation(Required=false)]
        public string FileExt { get; set; }

        /// <summary>
        /// <para>The file type. Valid values: <c>Media</c> (default), <c>StoryboardInput</c>, <c>ImageFusion</c>, <c>AIAppParams</c>, <c>Workflow</c>, and <c>CommonFile</c>. If an invalid value is specified, <c>InvalidParameter</c> is returned. This value is used as a path segment in the <c>ObjectKey</c> and is converted to lowercase.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Media</para>
        /// </summary>
        [NameInMap("FileType")]
        [Validation(Required=false)]
        public string FileType { get; set; }

        /// <summary>
        /// <para>The explicitly specified destination bucket.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-bucket</para>
        /// </summary>
        [NameInMap("TargetBucket")]
        [Validation(Required=false)]
        public string TargetBucket { get; set; }

    }

}
