// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class AddImageRequest : TeaModel {
        /// <summary>
        /// <para>The visibility of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: All members in the current workspace can access the image.</description></item>
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
        /// <para>The description of the image.</para>
        /// 
        /// <b>Example:</b>
        /// <para>NLP model compression training image</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image ID. If this parameter is not specified, the system automatically generates one. The format is image- followed by 18 uppercase or lowercase letters or digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-k83*****cv</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The image URI, which can be duplicated. For information about how to view the image URI, see <a href="https://help.aliyun.com/document_detail/449118.html">ListImage</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/pai-compression/nlp:gpu</para>
        /// </summary>
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>The image labels. This is an array in which each item contains a key field and a value field.
        /// Official images have the following label: system.official=true
        /// The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description>system.chipType</description></item>
        /// <item><description>system.dsw.cudaVersion</description></item>
        /// <item><description>system.dsw.fromImageId</description></item>
        /// <item><description>system.dsw.fromInstanceId</description></item>
        /// <item><description>system.dsw.id</description></item>
        /// <item><description>system.dsw.os</description></item>
        /// <item><description>system.dsw.osVersion</description></item>
        /// <item><description>system.dsw.resourceType</description></item>
        /// <item><description>system.dsw.rootImageId</description></item>
        /// <item><description>system.dsw.stage</description></item>
        /// <item><description>system.dsw.tag</description></item>
        /// <item><description>system.dsw.type</description></item>
        /// <item><description>system.framework</description></item>
        /// <item><description>system.origin</description></item>
        /// <item><description>system.pythonVersion</description></item>
        /// <item><description>system.source</description></item>
        /// <item><description>system.supported.dlc</description></item>
        /// <item><description>system.supported.dsw</description></item>
        /// </list>
        /// </summary>
        [NameInMap("Labels")]
        [Validation(Required=false)]
        public List<AddImageRequestLabels> Labels { get; set; }
        public class AddImageRequestLabels : TeaModel {
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
        /// <para>The image name. Naming rules:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 1 to 50 characters in length.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, and hyphens (-), and must start with a letter.</description></item>
        /// <item><description>The name must be unique within the same workspace.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>nlp-compression</para>
        /// </summary>
        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The image size, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The image source ID. When the image source type is Build, the source ID corresponds to the image build ID.</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The image source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Import: import.</description></item>
        /// <item><description>Build: generate.</description></item>
        /// </list>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        [NameInMap("UserId")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the image belongs. For information about how to obtain the workspace ID, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15******45</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
