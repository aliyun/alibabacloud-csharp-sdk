// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateSuspiciousTargetConfigRequest : TeaModel {
        /// <summary>
        /// <para>The language of the content within the request and response. Default value: <b>zh</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The source IP address of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>The configuration of proactive defense for your server. The value includes the following fields:</para>
        /// <list type="bullet">
        /// <item><description><b>targetType</b>: specifies the dimension from which you manage proactive defense. UUIDs are supported. Set the value to <b>uuid</b>.</description></item>
        /// <item><description><b>target</b>: specifies the UUID of the server for which you want to configure proactive defense.</description></item>
        /// <item><description><b>flag</b>: specifies whether to enable or disable proactive defense for your server. Valid values are <b>add</b> and <b>del</b>. The value add indicates that proactive defense will be enabled for your server. The value del indicates that proactive defense will be disabled for your server.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>&quot;[{&quot;targetType&quot;:&quot;uuid&quot;,&quot;target&quot;:&quot;0585f81a-dd84-4ddf-9971-f59d12345678&quot;,&quot;flag&quot;:&quot;add&quot;},{&quot;targetType&quot;:&quot;uuid&quot;,&quot;target&quot;:&quot;01acfd9d-e6a4-4e61-b9eb-aae012345678&quot;,&quot;flag&quot;:&quot;add&quot;},{&quot;targetType&quot;:&quot;uuid&quot;,&quot;target&quot;:&quot;04a0e735-ad32-4835-b635-045812345678&quot;,&quot;flag&quot;:&quot;add&quot;}]&quot;</para>
        /// </summary>
        [NameInMap("TargetOperations")]
        [Validation(Required=false)]
        public string TargetOperations { get; set; }

        /// <summary>
        /// <para>The dimension from which you manage proactive defense. Only the server UUID dimension is supported.</para>
        /// <para>Set the value to <b>uuid</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>The type of proactive defense. Valid Values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_breaking</b>: automatic blocking</description></item>
        /// <item><description><b>webshell_cloud_breaking</b>: webshell defense</description></item>
        /// <item><description><b>alinet</b>: malicious behavior defense</description></item>
        /// <item><description><b>ransomware_breaking</b>: ransomware capture</description></item>
        /// <item><description><b>alisecguard</b>: client protection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>auto_breaking</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
