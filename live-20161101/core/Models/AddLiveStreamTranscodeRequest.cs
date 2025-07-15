// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class AddLiveStreamTranscodeRequest : TeaModel {
        /// <summary>
        /// <para>The name of the application to which the live stream belongs.</para>
        /// <list type="bullet">
        /// <item><description>The transcoding template takes effect only if the value of this parameter is the same as the application name that is specified in the ingest URL. The name can be up to 256 characters in length and can contain digits, letters, hyphens (-), and underscores (_).</description></item>
        /// <item><description>You can also set this parameter to an asterisk (\<em>). Asterisks (\</em>) can match any string, including an empty string.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you configure a transcoding template for which App is set to an asterisk (\*), the transcoding template is used only if no transcoding template for which App is set to the same value as AppName in the ingest URL exists.</para>
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
        /// <para>The name of the main streaming domain.</para>
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
        /// <para>Specifies whether to use the load-on-demand mechanism for transcoding. Default value: <b>yes</b>.</para>
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
        /// <para>The transcoding template. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Standard transcoding template:</para>
        /// <list type="bullet">
        /// <item><description><b>lld</b>: low definition</description></item>
        /// <item><description><b>lsd</b>: standard definition</description></item>
        /// <item><description><b>lhd</b>: high definition</description></item>
        /// <item><description><b>lud</b>: ultra-high definition</description></item>
        /// </list>
        /// </description></item>
        /// <item><description><para>Narrowband HD™ transcoding template:</para>
        /// <list type="bullet">
        /// <item><description><b>ld</b>: low definition</description></item>
        /// <item><description><b>sd</b>: standard definition</description></item>
        /// <item><description><b>hd</b>: high definition</description></item>
        /// <item><description><b>ud</b>: ultra-high definition</description></item>
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
