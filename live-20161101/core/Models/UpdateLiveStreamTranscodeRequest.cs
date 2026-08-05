// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The AppName of the live stream. This parameter cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The streaming domain. This parameter cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The encryption settings, formatted as a JSON string.</para>
        /// <list type="bullet">
        /// <item><description><para><b>EncryptType</b>: The encryption type. Set the value to aliyun.</para>
        /// </description></item>
        /// <item><description><para><b>KmsKeyID</b>: The ID of the customer master key (CMK) in Key Management Service (KMS).</para>
        /// </description></item>
        /// <item><description><para><b>KmsKeyExpireInterval</b>: The key rotation period. Unit: seconds. Valid values: <b>60 to 3600.</b></para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>When you use Digital Rights Management (DRM) encryption, you cannot modify <b>KmsKeyID</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EncryptType&quot;: &quot;aliyun&quot;, &quot;KmsKeyID&quot;:&quot;afce5722-81d2-43c3-9930-7601da11****&quot;,&quot;KmsKeyExpireInterval&quot;:&quot;3600&quot;}</para>
        /// </summary>
        [NameInMap("EncryptParameters")]
        [Validation(Required=false)]
        public string EncryptParameters { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable on-demand transcoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>yes</b>: Transcoding only starts when the first viewer requests this transcoded stream.</para>
        /// </description></item>
        /// <item><description><para><b>no</b>: Transcoding starts immediately after the stream is published.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>yes</para>
        /// </summary>
        [NameInMap("Lazy")]
        [Validation(Required=false)]
        public string Lazy { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The transcoding template name. This parameter cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lsd</para>
        /// </summary>
        [NameInMap("Template")]
        [Validation(Required=false)]
        public string Template { get; set; }

    }

}
