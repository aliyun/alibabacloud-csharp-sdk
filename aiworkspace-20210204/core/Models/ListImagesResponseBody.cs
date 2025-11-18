// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class ListImagesResponseBody : TeaModel {
        /// <summary>
        /// <para>The images.</para>
        /// </summary>
        [NameInMap("Images")]
        [Validation(Required=false)]
        public List<ListImagesResponseBodyImages> Images { get; set; }
        public class ListImagesResponseBodyImages : TeaModel {
            /// <summary>
            /// <para>The accessibility of the image. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>PUBLIC: All members can access the image.</description></item>
            /// <item><description>PRIVATE: Only the creator can access the image.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>PUBLIC</para>
            /// </summary>
            [NameInMap("Accessibility")]
            [Validation(Required=false)]
            public string Accessibility { get; set; }

            /// <summary>
            /// <para>The image description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>desc</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The time when the image is created, in UTC. The time follows the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtCreateTime")]
            [Validation(Required=false)]
            public string GmtCreateTime { get; set; }

            /// <summary>
            /// <para>The time when the image is modified, in UTC. The time follows the ISO 8601 standard.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2021-01-21T17:12:35.232Z</para>
            /// </summary>
            [NameInMap("GmtModifiedTime")]
            [Validation(Required=false)]
            public string GmtModifiedTime { get; set; }

            /// <summary>
            /// <para>The image ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>image-tzi7f9******s45t</para>
            /// </summary>
            [NameInMap("ImageId")]
            [Validation(Required=false)]
            public string ImageId { get; set; }

            /// <summary>
            /// <para>The image address, which includes the version number.</para>
            /// </summary>
            [NameInMap("ImageUri")]
            [Validation(Required=false)]
            public string ImageUri { get; set; }

            /// <summary>
            /// <para>The image tags.</para>
            /// </summary>
            [NameInMap("Labels")]
            [Validation(Required=false)]
            public List<ListImagesResponseBodyImagesLabels> Labels { get; set; }
            public class ListImagesResponseBodyImagesLabels : TeaModel {
                /// <summary>
                /// <para>The tag key.</para>
                /// 
                /// <b>Example:</b>
                /// <para>system.chipType</para>
                /// </summary>
                [NameInMap("Key")]
                [Validation(Required=false)]
                public string Key { get; set; }

                /// <summary>
                /// <para>The tag value.</para>
                /// 
                /// <b>Example:</b>
                /// <para>GPU</para>
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// <para>The image name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tensorflow_2.9</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The ID of the Alibaba Cloud account.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15577******82932</para>
            /// </summary>
            [NameInMap("ParentUserId")]
            [Validation(Required=false)]
            public string ParentUserId { get; set; }

            /// <summary>
            /// <para>The image size. Unit: GB.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>镜像来源 ID</para>
            /// </summary>
            [NameInMap("SourceId")]
            [Validation(Required=false)]
            public string SourceId { get; set; }

            /// <summary>
            /// <para>镜像来源类型</para>
            /// </summary>
            [NameInMap("SourceType")]
            [Validation(Required=false)]
            public string SourceType { get; set; }

            /// <summary>
            /// <para>The user ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>15577******82932</para>
            /// </summary>
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            /// <summary>
            /// <para>The workspace ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20******55</para>
            /// </summary>
            [NameInMap("WorkspaceId")]
            [Validation(Required=false)]
            public string WorkspaceId { get; set; }

        }

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
        /// <para>The total number of returned images.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
