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
        /// <item><description><para>PUBLIC: All members of the workspace can perform operations on the image.</para>
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
        /// <para>The ID of the image. If you leave this parameter empty, the system automatically generates an ID.
        /// The format is \<c>image-\\</c> followed by 18 uppercase letters, lowercase letters, or digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-k83*****cv</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The URI of the image. The URI can be reused. For more information, see <a href="https://help.aliyun.com/document_detail/449118.html">ListImage</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/pai-compression/nlp:gpu</para>
        /// </summary>
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>The labels of the image. This is an array where each item contains a key and a value.
        /// Official images have the following label: system.official=true
        /// The following keys are supported:</para>
        /// <list type="bullet">
        /// <item><description><para>system.chipType</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.cudaVersion</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.fromImageId</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.fromInstanceId</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.id</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.os</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.osVersion</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.resourceType</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.rootImageId</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.stage</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.tag</para>
        /// </description></item>
        /// <item><description><para>system.dsw\.type</para>
        /// </description></item>
        /// <item><description><para>system.framework</para>
        /// </description></item>
        /// <item><description><para>system.origin</para>
        /// </description></item>
        /// <item><description><para>system.pythonVersion</para>
        /// </description></item>
        /// <item><description><para>system.source</para>
        /// </description></item>
        /// <item><description><para>system.supported.dlc</para>
        /// </description></item>
        /// <item><description><para>system.supported.dsw</para>
        /// </description></item>
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
        /// <para>The image name. The naming convention is as follows:</para>
        /// <list type="bullet">
        /// <item><description><para>The name must be 1 to 50 characters long.</para>
        /// </description></item>
        /// <item><description><para>The name can contain lowercase letters, digits, and hyphens (-). It must start with a letter.</para>
        /// </description></item>
        /// <item><description><para>The name must be unique within the workspace.</para>
        /// </description></item>
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
        /// <para>The size of the image, in GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The source ID of the image. If the source type is Build, this ID corresponds to the image build ID.</para>
        /// </summary>
        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        /// <summary>
        /// <para>The source type of the image. Valid values:
        /// Import
        /// Build</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The ID of the workspace to which the image belongs. For more information, see <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15******45</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
