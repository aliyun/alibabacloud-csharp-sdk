// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AIWorkSpace20210204.Models
{
    public class AddImageRequest : TeaModel {
        /// <summary>
        /// <para>The accessibility of the image. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PUBLIC: The image is accessible to all members in the workspace.</description></item>
        /// <item><description>PRIVATE: The image is accessible only to the image creator.</description></item>
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
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The image ID. If you do not specify this parameter, the system automatically generates an image ID. The image ID must start with image- followed by 18 characters in letters or digits.</para>
        /// 
        /// <b>Example:</b>
        /// <para>image-k83*****cv</para>
        /// </summary>
        [NameInMap("ImageId")]
        [Validation(Required=false)]
        public string ImageId { get; set; }

        /// <summary>
        /// <para>The URL of the image, which can be repeated. You can call <a href="https://help.aliyun.com/document_detail/449118.html">ListImage</a> to view the image URL.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>registry.cn-hangzhou.aliyuncs.com/pai-compression/nlp:gpu</para>
        /// </summary>
        [NameInMap("ImageUri")]
        [Validation(Required=false)]
        public string ImageUri { get; set; }

        /// <summary>
        /// <para>The image tag, which is an array. Each element in the array contains a key-value pair. Alibaba Cloud images have the system.official=true tag. You can add the following keys to an image:</para>
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
        /// <para>The image name. The name must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>The name must be 1 to 50 characters in length.</description></item>
        /// <item><description>The name can contain lowercase letters, digits, and hyphens (-). The name must start with a lowercase letter.</description></item>
        /// <item><description>The name must be unique in a workspace.</description></item>
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
        /// <para>The size of the image. Unit: GB.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("Size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        [NameInMap("SourceId")]
        [Validation(Required=false)]
        public string SourceId { get; set; }

        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

        /// <summary>
        /// <para>The workspace ID. You can call <a href="https://help.aliyun.com/document_detail/449124.html">ListWorkspaces</a> to obtain the workspace ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>15******45</para>
        /// </summary>
        [NameInMap("WorkspaceId")]
        [Validation(Required=false)]
        public string WorkspaceId { get; set; }

    }

}
