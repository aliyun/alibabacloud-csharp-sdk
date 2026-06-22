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
        /// <para>The dataset name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>Elements.</para>
        /// </summary>
        [NameInMap("Elements")]
        [Validation(Required=false)]
        public List<Element> Elements { get; set; }

        /// <summary>
        /// <para>The media type of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>document</para>
        /// </summary>
        [NameInMap("MediaType")]
        [Validation(Required=false)]
        public string MediaType { get; set; }

        /// <summary>
        /// <para>The URI path of the OSS file. This parameter is used only when the URI is a PDS address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket/test-object.jpg</para>
        /// </summary>
        [NameInMap("OSSURI")]
        [Validation(Required=false)]
        public string OSSURI { get; set; }

        /// <summary>
        /// <para>The identifier of the file in the dataset.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0939d7ed-73fa-4009-bbe6-fbbe07b92b2e</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1482910009923706</para>
        /// </summary>
        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The project name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The URI of the file.
        /// The format of an OSS URI is oss\://${bucketname}/${objectname}. ${bucketname} is the name of an OSS bucket in the same region as the current project. ${objectname} is the file path.
        /// The format of a PDS URI is pds\://domains/${domain}/drives/${drive}/files/${file}/revisions/${revision}.</para>
        /// 
        /// <b>Example:</b>
        /// <para>oss://test-bucket</para>
        /// </summary>
        [NameInMap("URI")]
        [Validation(Required=false)]
        public string URI { get; set; }

    }

}
