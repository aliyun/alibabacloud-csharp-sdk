// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class CompareImageFacesRequest : TeaModel {
        /// <summary>
        /// <para><b>If you have no special requirements, leave this parameter empty.</b></para>
        /// <para>The authorization chain settings. For more information, see <a href="https://help.aliyun.com/document_detail/465340.html">Use authorization chains to access resources of other entities</a>.</para>
        /// </summary>
        [NameInMap("CredentialConfig")]
        [Validation(Required=false)]
        public CredentialConfig CredentialConfig { get; set; }

        /// <summary>
        /// <para>The name of the project. For more information, see <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The URLs of the two images for compression.</para>
        /// </summary>
        [NameInMap("Source")]
        [Validation(Required=false)]
        public CompareImageFacesRequestSource Source { get; set; }
        public class CompareImageFacesRequestSource : TeaModel {
            /// <summary>
            /// <para>The OSS URL of the image file.</para>
            /// <para>Specify the URL in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format. <c>&lt;bucket&gt;</c> specifies the name of the OSS bucket that is in the same region as the current project. <c>&lt;object&gt;</c> specifies path of the object with the extension included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object1</para>
            /// </summary>
            [NameInMap("URI1")]
            [Validation(Required=false)]
            public string URI1 { get; set; }

            /// <summary>
            /// <para>The OSS URL of the image file.</para>
            /// <para>Specify the URL in the <c>oss://&lt;bucket&gt;/&lt;object&gt;</c> format. <c>&lt;bucket&gt;</c> specifies the name of the OSS bucket that is in the same region as the current project, and <c>&lt;object&gt;</c> specifies the path of the object with the extension included.</para>
            /// 
            /// <b>Example:</b>
            /// <para>oss://test-bucket/test-object2</para>
            /// </summary>
            [NameInMap("URI2")]
            [Validation(Required=false)]
            public string URI2 { get; set; }

        }

    }

}
