// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the stream belongs.</para>
        /// <list type="bullet">
        /// <item><description><para>The value of App must be the same as the AppName in the ingest URL for the transcoding template to take effect. The value can be up to 256 characters in length and can contain digits, letters, hyphens (-), and underscores (_).</para>
        /// </description></item>
        /// <item><description><para>App also supports a single asterisk (\*) as the value, which matches any string including an empty string.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>If a transcoding template with App set to a single asterisk (\<em>) is configured: when a user pulls a transcoded stream, the system first matches the transcoding template whose App value is the same as the AppName in the ingest URL. If no such template exists, the system matches the transcoding template with App set to a single asterisk (\</em>).</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>The streaming domain of the streamer.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The encryption configuration. JSON format. The fields are described as follows:</para>
        /// <list type="bullet">
        /// <item><description>EncryptType: the encryption type. Set the value to <b>aliyun</b>.</description></item>
        /// <item><description>KmsKeyID: the user KMS master key ID.</description></item>
        /// <item><description>KmsKeyExpireInterval: the key rotation interval. Valid values: <b>60 to 3600</b>. Unit: seconds.</description></item>
        /// </list>
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
        /// <item><description><b>yes</b>: enables on-demand transcoding.</description></item>
        /// <item><description><b>no</b>: disables on-demand transcoding.</description></item>
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
        /// <para>The region ID. When using SDK 2.0, set this parameter to the region ID that corresponds to the service registration endpoint. When using SDK 1.0, ignore this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The transcoding template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard quality templates:</para>
        /// <list type="bullet">
        /// <item><description><para><b>lld</b>: low definition.</para>
        /// </description></item>
        /// <item><description><para><b>lsd</b>: standard definition.</para>
        /// </description></item>
        /// <item><description><para><b>lhd</b>: high definition.</para>
        /// </description></item>
        /// <item><description><para><b>lud</b>: ultra-high definition.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Narrowband HD™ transcoding templates:</para>
        /// <list type="bullet">
        /// <item><description><para><b>ld</b>: low definition.</para>
        /// </description></item>
        /// <item><description><para><b>sd</b>: standard definition.</para>
        /// </description></item>
        /// <item><description><para><b>hd</b>: high definition.</para>
        /// </description></item>
        /// <item><description><para><b>ud</b>: ultra-high definition.</para>
        /// </description></item>
        /// </list>
        /// </description></item>
        /// </list>
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
