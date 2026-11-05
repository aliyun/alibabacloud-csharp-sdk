// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class OperateSuspiciousTargetConfigRequest : TeaModel {
        /// <summary>
        /// <para>Specifies the language of the request and response. Default value: <b>zh</b>. Valid values:</para>
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
        /// <para>The source IP address.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.2.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

        /// <summary>
        /// <para>Specifies the proactive defense parameters for servers. The following parameters are included:</para>
        /// <list type="bullet">
        /// <item><description><b>targetType</b>: the dimension of the defense configuration. Currently, only the UUID dimension is supported. Fixed value: <b>uuid</b>.</description></item>
        /// <item><description><b>target</b>: the UUID of the server for which you want to configure defense settings.</description></item>
        /// <item><description><b>flag</b>: specifies whether to enable or disable proactive defense for the server. Valid values: <b>add</b> (enable) and <b>del</b> (disable).</description></item>
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
        /// <para>Specifies the dimension for managing proactive defense. Currently, only the server UUID dimension is supported.</para>
        /// <para>Valid value: <b>uuid</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>uuid</para>
        /// </summary>
        [NameInMap("TargetType")]
        [Validation(Required=false)]
        public string TargetType { get; set; }

        /// <summary>
        /// <para>Specifies the type of proactive defense. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>auto_breaking</b>: automatic interception</description></item>
        /// <item><description><b>webshell_cloud_breaking</b>: web shell connection defense</description></item>
        /// <item><description><b>alinet</b>: malicious network behavior defense</description></item>
        /// <item><description><b>ransomware_breaking</b>: anti-ransomware (bait capture)</description></item>
        /// <item><description><b>alisecguard</b>: client self-protection</description></item>
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
