// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class UpdateLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the stream belongs, and it cannot be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>liveApp****</para>
        /// </summary>
        [NameInMap("App")]
        [Validation(Required=false)]
        public string App { get; set; }

        /// <summary>
        /// <para>Streamer domain name, not modifiable.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>example.com</para>
        /// </summary>
        [NameInMap("Domain")]
        [Validation(Required=false)]
        public string Domain { get; set; }

        /// <summary>
        /// <para>The encryption configuration. The value is a JSON string. The following fields are included in the syntax:</para>
        /// <list type="bullet">
        /// <item><description>EncryptType: the type of the encryption. Set the value to <b>aliyun</b>.</description></item>
        /// <item><description>KmsKeyID: the ID of the CMK in KMS.</description></item>
        /// <item><description>KmsKeyExpireInterval: the validity period of the CMK. Valid values: <b>60 to 3600</b>. Unit: seconds.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;EncryptType&quot;: &quot;aliyun&quot;, &quot;KmsKeyID&quot;:&quot;afce5722-81d2-43c3-9930-7601da11****&quot;,&quot;KmsKeyExpireInterval&quot;:&quot;3600&quot;}</para>
        /// </summary>
        [NameInMap("EncryptParameters")]
        [Validation(Required=false)]
        public string EncryptParameters { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable triggered transcoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>yes</b>: enables triggered transcoding.</description></item>
        /// <item><description><b>no</b>: disables triggered transcoding.</description></item>
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

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Transcoding template, not modifiable.</para>
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
