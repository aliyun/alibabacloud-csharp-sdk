// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDNAJobRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the media fingerprint analysis job. The value is a JSON object. If you specify this parameter, the template parameters are overwritten.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SaveType&quot;: &quot;save&quot;,&quot;MediaType&quot;&quot;:&quot;video&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the media fingerprint library. If you do not specify this parameter, the default media fingerprint library is used. For more information about how to create a media fingerprint library, see <a href="https://help.aliyun.com/document_detail/479275.html">CreateDNADB</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2288c6ca184c0e47098a5b665e2a12****</para>
        /// </summary>
        [NameInMap("DBId")]
        [Validation(Required=false)]
        public string DBId { get; set; }

        /// <summary>
        /// <para>The input file for media fingerprint analysis.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitDNAJobRequestInput Input { get; set; }
        public class SubmitDNAJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The input file. The file can be an OSS object or a media asset. You can specify the path of an OSS object in one of the following formats:</para>
            /// <para>1\. oss://bucket/object</para>
            /// <para>2\. http(s)://bucket.oss-[regionId].aliyuncs.com/object</para>
            /// <para>In the preceding paths, bucket indicates an OSS bucket that resides in the same region as the current project, and object indicates the path of the object in the bucket.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1b1b9cd148034739af413150fded****</para>
            /// </summary>
            [NameInMap("Media")]
            [Validation(Required=false)]
            public string Media { get; set; }

            /// <summary>
            /// <para>The type of the input file. Valid values:</para>
            /// <ol>
            /// <item><description>OSS: Object Storage Service (OSS) object.</description></item>
            /// <item><description>Media: media asset.</description></item>
            /// </ol>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Media</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue to which the media fingerprint analysis job is submitted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5246b8d12a62433ab77845074039****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The primary key of the video. You must make sure that each primary key is unique.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3ca84a39a9024f19853b21be9cf9****</para>
        /// </summary>
        [NameInMap("PrimaryKey")]
        [Validation(Required=false)]
        public string PrimaryKey { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The template ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>S00000101-100060</para>
        /// </summary>
        [NameInMap("TemplateId")]
        [Validation(Required=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// <para>The user-defined data. The data can be up to 128 bytes in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userData</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
