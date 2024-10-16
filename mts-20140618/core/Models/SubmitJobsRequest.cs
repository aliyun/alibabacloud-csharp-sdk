// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitJobsRequest : TeaModel {
        /// <summary>
        /// <para>The information about the input file. For more information, see the &quot;Input&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
        /// <remarks>
        /// </remarks>
        /// <list type="bullet">
        /// <item><description><para>The path of an Object Storage Service (OSS) object must be URL-encoded in UTF-8 before you use the path in MPS.</para>
        /// </description></item>
        /// <item><description><para>The OSS bucket must reside in the same region as your MPS service.</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a/b/c/test-cn.srt</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        /// <summary>
        /// <para>The name of the OSS bucket that stores the output file.</para>
        /// <list type="bullet">
        /// <item><description>For more information about the term bucket, see <a href="https://help.aliyun.com/document_detail/31827.html">Terms</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exampleBucket</para>
        /// </summary>
        [NameInMap("OutputBucket")]
        [Validation(Required=false)]
        public string OutputBucket { get; set; }

        /// <summary>
        /// <para>The region in which the OSS bucket that stores the output file resides.</para>
        /// <list type="bullet">
        /// <item><description>The OSS bucket must reside in the same region as MPS.</description></item>
        /// <item><description>For more information about the term bucket, see <a href="https://help.aliyun.com/document_detail/31827.html">Terms</a>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>oss-cn-hangzhou</para>
        /// </summary>
        [NameInMap("OutputLocation")]
        [Validation(Required=false)]
        public string OutputLocation { get; set; }

        /// <summary>
        /// <para>The job output configurations. For more information, see the &quot;Output&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
        /// <list type="bullet">
        /// <item><description>Specify the value in a JSON array of Output objects. You can specify up to 30 Output objects.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;OutputObject&quot;:&quot;exampleOutput.mp4&quot;,&quot;TemplateId&quot;:&quot;6181666213ab41b9bc21da8ff5ff****&quot;,&quot;WaterMarks&quot;:[{&quot;InputFile&quot;:{&quot;Bucket&quot;:&quot;exampleBucket&quot;,&quot;Location&quot;:&quot;oss-cn-hangzhou&quot;,&quot;Object&quot;:&quot;image_01.png&quot;},&quot;WaterMarkTemplateId&quot;:&quot;9b772ce2740d4d55876d8b542d47****&quot;}],&quot;UserData&quot;:&quot;testid-001&quot;}]</para>
        /// </summary>
        [NameInMap("Outputs")]
        [Validation(Required=false)]
        public string Outputs { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the MPS queue. For more information, see <a href="https://help.aliyun.com/document_detail/31827.html">Terms</a>.</para>
        /// <list type="bullet">
        /// <item><description>To obtain the ID of an MPS queue, you can log on to the <a href="https://mps.console.aliyun.com/overview">MPS console</a> and choose <b>Global Settings</b> &gt; <b>MPS Queue and Callback</b> in the left-side navigation pane.</description></item>
        /// <item><description>If you want to receive asynchronous message notifications, associate an MNS queue or topic with the MPS queue. For more information, see <a href="https://help.aliyun.com/document_detail/42618.html">Receive notifications</a>.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dd3dae411e704030b921e52698e5****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
