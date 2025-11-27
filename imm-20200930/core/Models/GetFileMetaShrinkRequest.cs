// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class GetFileMetaShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The name of the dataset.<a href="~~478160~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The name of the project.<a href="~~478153~~"></a></para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The URI of the file. Make sure that the file is indexed****.</para>
        /// <para>Specify the OSS URI in the oss://${Bucket}/${Object} format, where <c>${Bucket}</c> is the name of the bucket in the same region as the current project and <c>${Object}</c> is the path of the object with the extension included.</para>
        /// <para>Specify the URI of the file in Photo and Drive Service in the pds://domains/${domain}/drives/${drive}/files/${file}/revisions/${revision} format.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

        /// <summary>
        /// <para>The metadata fields that you want to include in the response. You can use this parameter to reduce the size of the response.</para>
        /// <para>If you do not specify this parameter or leave this parameter empty, the operation returns all metadata fields of the file.</para>
        /// </summary>
        [NameInMap("WithFields")]
        [Validation(Required=false)]
        public string WithFieldsShrink { get; set; }

    }

}
