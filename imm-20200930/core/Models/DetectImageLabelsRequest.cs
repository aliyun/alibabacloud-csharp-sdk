// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectImageLabelsRequest : TeaModel {
        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The authorization chain settings. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>immimagetest</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The URI of the Object Storage Service (OSS) bucket in which you store the image.</para>
        /// <para>Specify the value in the oss://${Bucket}/${Object} format. <c>${Bucket}</c> specifies the name of the OSS bucket that resides in the same region as the current project. <c>${Object}</c> specifies the complete path to the image file that has an extension.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://imm-test/testcases/facetest.jpg</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

        /// <summary>
        /// <para>The threshold of the label confidence. Labels whose confidence is lower than the specified threshold are not returned in the response. Valid values: 0 to 1. If you leave this parameter empty, the algorithm provides a default threshold.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("Threshold")]
        [Validation(Required=false)]
        public float? Threshold { get; set; }

    }

}
