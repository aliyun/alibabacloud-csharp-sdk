// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitAnalysisJobRequest : TeaModel {
        /// <summary>
        /// <para>The job configurations. Set this parameter as required. For more information, see the &quot;AnalysisConfig&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;QualityControl&quot;:{&quot;RateQuality&quot;:25,&quot;MethodStreaming&quot;:&quot;network&quot;}}</para>
        /// </summary>
        [NameInMap("AnalysisConfig")]
        [Validation(Required=false)]
        public string AnalysisConfig { get; set; }

        /// <summary>
        /// <para>The input information about the preset template analysis job to be submitted. The value must be a JSON object. You must log on to the Object Storage Service (OSS) console to grant the read permissions on the specified OSS bucket to MPS. For more information, see the &quot;Input&quot; section of the <a href="https://help.aliyun.com/document_detail/29253.html">Parameter details</a> topic.</para>
        /// <remarks>
        /// <para>The OSS bucket must reside in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;oss-cn-hangzhou&quot;,&quot;Object&quot;:&quot;example.flv&quot;}</para>
        /// </summary>
        [NameInMap("Input")]
        [Validation(Required=false)]
        public string Input { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The ID of the MPS queue to which the job is submitted. To view the ID of the MPS queue, log on to the <b>MPS console</b> and choose <b>Global Settings</b> &gt; <b>Pipelines</b> in the left-side navigation pane. If you want to enable asynchronous notifications, make sure that the MPS queue is bound to a Message Service (MNS) topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bb558c1cc25b45309aab5be44d19****</para>
        /// </summary>
        [NameInMap("PipelineId")]
        [Validation(Required=false)]
        public string PipelineId { get; set; }

        /// <summary>
        /// <para>The priority of the job in the MPS queue to which the job is submitted.</para>
        /// <list type="bullet">
        /// <item><description>Valid values: <b>1 to 10</b>. A value of 10 indicates the highest priority.</description></item>
        /// <item><description>Default value: <b>6</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Priority")]
        [Validation(Required=false)]
        public string Priority { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The custom data. The custom data can contain letters, digits, and hyphens (-), and can be up to 1,024 bytes in length. The custom data cannot start with a special character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid-001</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
