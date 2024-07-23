// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mts20140618.Models
{
    public class ImportFpShotJobRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the text fingerprint library to which the text file is imported. You can specify only one job of importing text files to a text fingerprint library at a time. You can obtain the library ID from the response parameters of the <a href="https://help.aliyun.com/document_detail/170149.html">CreateFpShotDB</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>88c6ca184c0e47098a5b665e2a12****</para>
        /// </summary>
        [NameInMap("FpDBId")]
        [Validation(Required=false)]
        public string FpDBId { get; set; }

        /// <summary>
        /// <para>The job configurations. The value must be a JSON object. Example: <c>{&quot;SaveType&quot;:&quot;onlysave&quot;}</c>. The <c>SaveType</c> field indicates the storage type. Valid values of the SaveType field:</para>
        /// <list type="bullet">
        /// <item><description><b>save</b>: The fingerprints of the text file are saved to the text fingerprint library only if the text file is not duplicated with content in the text fingerprint library.</description></item>
        /// <item><description><b>onlysave</b>: The fingerprints of the text file are saved to the text fingerprint library.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;SaveType&quot;:&quot;onlysave&quot;}</para>
        /// </summary>
        [NameInMap("FpImportConfig")]
        [Validation(Required=false)]
        public string FpImportConfig { get; set; }

        /// <summary>
        /// <para>The Object Storage Service (OSS) URL of the text file to be imported to the text fingerprint library. The value must be a JSON object. Example: {&quot;Bucket&quot;:&quot;example-bucket&quot;,&quot;Location&quot;:&quot;oss-cn-shanghai&quot;,&quot;Object&quot;:&quot;example.flv&quot;}.</para>
        /// <remarks>
        /// <para>The OSS bucket must reside in the same region as your MPS service.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{“Bucket”:”example-bucket”,“Location”:”oss-cn-shanghai”,“Object”:”example.txt”}</para>
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
        /// <para>The ID of the ApsaraVideo Media Processing (MPS) queue. To view the ID of the MPS queue, perform the following steps: Log on to the <b>MPS console</b>. In the left-side navigation pane, choose <b>Global Settings</b> &gt; <b>Pipelines</b>. The MPS queue is associated with a specified Message Service (MNS) topic. You can submit jobs for different services to different MPS queues. If you do not specify this parameter, the job is submitted to the default MPS queue and no MNS topic is associated with the MPS queue.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ae687c02fe944327ba9631e50da2****</para>
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
        /// <para>The user-defined data. The value can contain letters, digits, and special characters. The value can be up to 128 bytes in length.</para>
        /// </summary>
        [NameInMap("UserData")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
