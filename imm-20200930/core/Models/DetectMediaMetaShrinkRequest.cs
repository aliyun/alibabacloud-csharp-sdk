// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class DetectMediaMetaShrinkRequest : TeaModel {
        /// <summary>
        /// <para><b>Leave this parameter empty unless you have special requirements.</b></para>
        /// <para>The chain authorization configuration. This parameter is optional. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use chain authorization to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public string CredentialConfigShrink { get; set; }

        /// <summary>
        /// <para>The project name. For information about how to obtain the project name, see <a href="https://help.aliyun.com/document_detail/478153.html">Create a project</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) URI of the media file.</para>
        /// <para>The OSS URI follows the format oss://${Bucket}/${Object}, where <c>${Bucket}</c> is the name of an OSS bucket in the same region as the current project, and <c>${Object}</c> is the full path of the file including the file name extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://examplebucket/sampleobject.mp4</para>
        /// </summary>
        [NameInMap("SourceURI")]
        [Validation(Required=false)]
        public string SourceURI { get; set; }

    }

}
