// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageCroppingShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The cropping ratios. You can specify up to five cropping ratios. Take note of the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The ratio must be an integer between 0 and 20.</description></item>
        /// <item><description>The ratio must range from 0.5 to 2.</description></item>
        /// <item><description>If you leave this parameter empty, the default processing logic is <c>[&quot;auto&quot;]</c>.</description></item>
        /// </list>
        /// <remarks>
        /// <para> Errors are reported in one of the following cases:\
        /// You specify more than five cropping ratios.\
        /// You pass an empty list to the system.\
        /// You specify a ratio that is not an integer, such as <c>4.1:3</c>.\
        /// The ratio is beyond the range of 0.5 to 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1:1&quot;]</para>
        /// </summary>
        [NameInMap("AspectRatios")]
        [Validation(Required=false)]
        public string AspectRatios { get; set; }

        /// <summary>
        /// <para><b>If you do not have special requirements, leave this parameter empty.</b></para>
        /// <para>The authorization chain. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The name of the project.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The URI of the Object Storage Service (OSS) bucket in which you store the image.</para>
        /// <para>Specify the value in the oss://${Bucket}/${Object} format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region as the current project. <c>${Object}</c> specifies the complete path to the image file that has an extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/testcases/facetest.jpg</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

    }

}
