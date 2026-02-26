// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class ContextualFile : TeaModel {
        /// <summary>
        /// <para>The Multipurpose Internet Mail Extensions (MIME) type of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>text/x-imm-faq</para>
        /// </summary>
        [NameInMap("ContentType")]
        [Validation(Required=false)]
        public string ContentType { get; set; }

        /// <summary>
        /// <para>Name of the dataset</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>Elements</para>
        /// </summary>
        [NameInMap("Elements")]
        [Validation(Required=false)]
        public List<Element> Elements { get; set; }

        /// <summary>
        /// <para>Media type of the current file</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>image</description></item>
        /// <item><description>other</description></item>
        /// <item><description>document</description></item>
        /// <item><description>archive</description></item>
        /// <item><description>audio</description></item>
        /// <item><description>video</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The URI of the OSS object. This parameter is available only if the value of the URI parameter is the URI of a file in Photo and Drive Service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.jpg</para>
        /// </summary>
        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        /// <summary>
        /// <para>The identifier of the corresponding file that exists in the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0939d7ed-73fa-4009-bbe6-fbbe07b92b2e</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>User ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1482910009923706</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>Name of the project</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>URI of the file. Specify the OSS URI in the oss://${bucketname}/${objectname} format, where ${bucketname} is the name of the bucket in the same region as the current project and ${objectname} is the path of the object. The URI of a file in Photo and Drive Service follows the pds://domains/${domain}/drives/${drive}/files/${file}/revisions/${revision} format.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
