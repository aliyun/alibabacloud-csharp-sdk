// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class GetImageResponseBody : TeaModel {
        /// <summary>
        /// <para>The visibility of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>PUBLIC: All members in the current workspace can perform operations on the image.</para>
        /// </description></item>
        /// <item><description><para>PRIVATE: Only the creator can perform operations on the image.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>PUBLIC</para>
        /// </summary>
        [NameInMap("Accessibility")]
        [Validation(Required=false)]
        public string Accessibility { get; set; }

        /// <summary>
        /// <para>The description of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLP model compression training image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The time when the image was created. The time is in UTC and the format is ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtCreateTime")]
        [Validation(Required=false)]
        public string GmtCreateTime { get; set; }

        /// <summary>
        /// <para>The time when the image was last modified. The time is in UTC and the format is ISO 8601.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-01-21T17:12:35.232Z</para>
        /// </summary>
        [NameInMap("GmtModifiedTime")]
        [Validation(Required=false)]
        public string GmtModifiedTime { get; set; }

        /// <summary>
        /// <para>The URL of the image, including the version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.******ession/nlp:gpu</para>
        /// </summary>
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>A list of image labels. This is an array. Each item in the array contains a Key and a Value field.
        /// Official images have the following label: the key is system.official and the value is true.</para>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<GetImageResponseBodyLabels> Labels { get; set; }
        public class GetImageResponseBodyLabels : TeaModel {
            /// <summary>
            /// <para>The key of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>system.chipType</para>
            /// </summary>
            [NameInMap("Key")]
            [Validation(Required=false)]
            public string Key { get; set; }

            /// <summary>
            /// <para>The value of the label.</para>
            /// 
            /// <b>Example:</b>
            /// <para>GPU</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The name of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlp-compression</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account of the creator.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15577******8921</para>
        /// </summary>
        [NameInMap("ParentUserId")]
        [Validation(Required=false)]
        public string ParentUserId { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5A14FA81-DD4E-******-6343FE44B941</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The size of the image in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The ID of the image source.</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The type of the image source.</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The UID of the user who created the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15577******8921</para>
        /// </summary>
        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the image belongs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15945</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
