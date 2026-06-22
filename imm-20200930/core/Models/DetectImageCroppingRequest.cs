// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageCroppingRequest : TeaModel {
        /// <summary>
        /// <para>The list of cropping aspect ratios. You can specify up to 5 ratios. Each ratio must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>The ratio must consist of integers in the range of (0, 20).</para>
        /// </description></item>
        /// <item><description><para>The ratio value must be in the range of [0.5, 2].</para>
        /// </description></item>
        /// <item><description><para>If you do not specify this parameter, the default value <c>[&quot;auto&quot;]</c> is used.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>The following cases cause an error:<br>- More than 5 ratios are specified.<br>- An empty list is passed.<br>- The ratio contains non-integer values, such as <c>4.1:3</c>.<br>- The ratio value is less than 0.5 or greater than 2.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;1:1&quot;]</para>
        /// </summary>
        [NameInMap("AspectRatios")]
        [Validation(Required=false)]
        public string AspectRatios { get; set; }

        /// <summary>
        /// <para><b>Leave this parameter empty unless otherwise required.</b></para>
        /// <para>The China authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chained authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The list of semantic text descriptions for objects that you want the cropping result to include. Each element is free-form text, such as &quot;signboard&quot; or &quot;dish&quot;.</para>
        /// <remarks>
        /// <para>Usage limits of the InclusionHints parameter:
        /// <br>- You can pass in up to 1 hint in the array to specify the type of object to include in the cropping result, such as &quot;signboard&quot;.
        /// <br>- The algorithm detects all objects in the image that match the hint and generates cropping regions that include as many matched objects as possible.
        /// <br>- Each cropping region includes up to 10 matched objects. If more than 10 objects match in the image, the cropping region includes up to 10 of them.
        /// <br>- You can use the MatchedInclusionHints response field to determine whether the hint was successfully matched.
        /// <br>- This parameter is supported only in regions in the Chinese mainland.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;sign&quot;]</para>
        /// </summary>
        [NameInMap("InclusionHints")]
        [Validation(Required=false)]
        public List<string> InclusionHints { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immtest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The OSS URI of the image.</para>
        /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where <c>${Bucket}</c> is the name of an OSS bucket in the same region as the current project, and <c>${Object}</c> is the full path of the file including the file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/testcases/facetest.jpg</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

    }

}
