// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class GenerateRamPolicyResponseBody : TeaModel {
        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The content of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{     &quot;Version&quot;: &quot;1&quot;,     &quot;Statement&quot;: [         {             &quot;Effect&quot;: &quot;Deny&quot;,             &quot;Action&quot;: [                 &quot;hbr:CreateRestore&quot;,                 &quot;hbr:CreateRestoreJob&quot;,                 &quot;hbr:CreateHanaRestore&quot;,                 &quot;hbr:CreateUniRestorePlan&quot;,                 &quot;hbr:CreateSqlServerRestore&quot;             ],             &quot;Resource&quot;: [                 &quot;acs:hbr:<em>:1178</em><em><b><b>531:vault/v-000</b></b></em><em>blx06&quot;,                 &quot;acs:hbr:</em>:1178<b><b><b>531:vault/v-000</b></b></b>blx06/client/*&quot;             ]         }     ] }</para>
        /// </summary>
        [NameInMap("PolicyDocument")]
        [Validation(Required=false)]
        public string PolicyDocument { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>473469C7-AA6F-4DC5-B3DB-A3DC0DE3C83E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
