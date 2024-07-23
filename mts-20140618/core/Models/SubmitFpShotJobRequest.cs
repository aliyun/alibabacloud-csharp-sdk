// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class SubmitFpShotJobRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the media fingerprint analysis job. The value is a JSON object. For more information, see the &quot;FpShotConfig&quot; section of the <a href="https://help.aliyun.com/document_detail/93568.html">Parameter details</a> topic.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;PrimaryKey&quot;: &quot;12345****&quot;,
        ///       &quot;SaveType&quot;: &quot;save&quot;,
        ///       &quot;FpDBId&quot;: &quot;417f2ada5999daf****&quot;
        /// }</para>
        /// </summary>
        [NameInMap("FpShotConfig")]
        [Validation(Required=false)]
        public string FpShotConfig { get; set; }

        /// <summary>
        /// <para>The OSS URL of the job input. The value is a JSON object. You can query the OSS URL in the OSS or MPS console.</para>
        /// <remarks>
        /// <para>The OSS bucket must reside in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;Bucket&quot;:&quot;example-bucket-<b><b>&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example-</b></b>.flv&quot;}</para>
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
        /// <para>The ID of the MPS queue. This ID can be used to associate the job with a notification method. To view the ID of the MPS queue, perform the following steps: Log on to the <b>MPS console</b>. In the left-side navigation pane, choose <b>Global Settings</b> &gt; <b>Pipelines</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e47098a5b665e2a12****</para>
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

        /// <summary>
        /// <para>The custom data. The value can be up to 128 bytes in length and cannot start with a special character.</para>
        /// 
        /// <b>Example:</b>
        /// <para>testid-****</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
