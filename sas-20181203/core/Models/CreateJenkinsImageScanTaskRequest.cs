// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class CreateJenkinsImageScanTaskRequest : TeaModel {
        /// <summary>
        /// <para>The image summary.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a8c9f3765684cd8d9053db9523eab58878e99a199217500efd9ae2a860a7****</para>
        /// </summary>
        [NameInMap("Digest")]
        [Validation(Required=false)]
        public string Digest { get; set; }

        /// <summary>
        /// <para>The image creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717430400000</para>
        /// </summary>
        [NameInMap("ImageCreate")]
        [Validation(Required=false)]
        public long? ImageCreate { get; set; }

        /// <summary>
        /// <para>The image ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b10ef7b245c34a0822055c74fc4a0e8b5baf0279306316b2c517a501ed25****</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image size. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6120340</para>
        /// </summary>
        [NameInMap("ImageSize")]
        [Validation(Required=false)]
        public long? ImageSize { get; set; }

        /// <summary>
        /// <para>The image update time. The value is a UNIX timestamp. Unit: milliseconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1717430498600</para>
        /// </summary>
        [NameInMap("ImageUpdate")]
        [Validation(Required=false)]
        public long? ImageUpdate { get; set; }

        /// <summary>
        /// <para>The Jenkins environment context. Leave this parameter empty or set it to the fixed value: <b>release</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>release</para>
        /// </summary>
        [NameInMap("JenkinsEnv")]
        [Validation(Required=false)]
        public string JenkinsEnv { get; set; }

        /// <summary>
        /// <para>The namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lkl-zf-ss-ccss</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The repository name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sdk</para>
        /// </summary>
        [NameInMap("RepoName")]
        [Validation(Required=false)]
        public string RepoName { get; set; }

        /// <summary>
        /// <para>The access source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>119.136.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The image label.</para>
        /// 
        /// <b>Example:</b>
        /// <para>00f597223f-20210831-1</para>
        /// </summary>
        [NameInMap("Tag")]
        [Validation(Required=false)]
        public string Tag { get; set; }

        /// <summary>
        /// <para>The access token for the Jenkins image repository. Obtain the token from the homepage of the Chinese documentation center &gt; Security Center &gt; User Guide &gt; Container Protection &gt; CI/CD Access Settings. You can also invoke CreateJenkinsImageRegistry to create a CI/CD image repository and obtain the token from the response parameter Data.Token. For an existing repository, invoke PageImageRegistry to query the token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c3de8326-273e-11fc-a0e3-d012435c****</para>
        /// </summary>
        [NameInMap("Token")]
        [Validation(Required=false)]
        public string Token { get; set; }

        /// <summary>
        /// <para>The UUID of the image asset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5b268326-273e-44fc-a0e3-9482435c****</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
