// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SubmitDNAJobRequest : TeaModel {
        /// <summary>
        /// <para>The DNA configuration in JSON format. If specified, these settings override the corresponding template parameters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SaveType&quot;: &quot;save&quot;,&quot;MediaType&quot;:&quot;video&quot;}</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The DNA library ID. To create a DNA library, see <a href="https://help.aliyun.com/document_detail/479275.html">CreateDNADB</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2288c6ca184c0e47098a5b665e2a12****</para>
        /// </summary>
        [NameInMap("DBId")]
        [Validation(Required=false)]
        public string DBId { get; set; }

        /// <summary>
        /// <para>The input DNA file.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public SubmitDNAJobRequestInput Input { get; set; }
        public class SubmitDNAJobRequestInput : TeaModel {
            /// <summary>
            /// <para>The media ID or OSS file url of the input file.</para>
            /// <para>1\. <c>oss://bucket/object</c></para>
            /// <para>2\. <c>http(s)://bucket.oss-[regionId].aliyuncs.com/object</c></para>
            /// <para>In these formats, <c>bucket</c> is the name of an OSS bucket in the same region as your project, and <c>object</c> is the file path.</para>
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
            /// <item><description><para><c>OSS</c>: The input is an OSS file url.</para>
            /// </description></item>
            /// <item><description><para><c>Media</c>: The input is a media ID.</para>
            /// </description></item>
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
        /// <para>The pipeline ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5246b8d12a62433ab77845074039****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The unique primary key for the video. You are responsible for ensuring its uniqueness.</para>
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
        /// <para>The user-defined data. The maximum length is 128 bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>userData</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
