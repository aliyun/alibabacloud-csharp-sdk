// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class ModifySecurityEventMarkMissIndividuallyRequest : TeaModel {
        /// <summary>
        /// <para>The alert handling rule that you want to delete.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;field\&quot;:\&quot;loginSourceIp\&quot;,\&quot;operate\&quot;:\&quot;contains\&quot;,\&quot;eventType\&quot;:\&quot;SIL_AI_ALERT\&quot;,\&quot;eventName\&quot;:\&quot;login_common_ip\&quot;,\&quot;fieldValue\&quot;:\&quot;10.12.XX.XX\&quot;,\&quot;uuids\&quot;:\&quot;\&quot;}]</para>
        /// </summary>
        [NameInMap("DeleteMarkMissParam")]
        [Validation(Required=false)]
        public string DeleteMarkMissParam { get; set; }

        /// <summary>
        /// <para>The ID of the request source. Set the value to <b>sas</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sas</para>
        /// </summary>
        [NameInMap("From")]
        [Validation(Required=false)]
        public string From { get; set; }

        /// <summary>
        /// <para>The alert handling that you want to add.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{\&quot;field\&quot;:\&quot;location\&quot;,\&quot;operate\&quot;:\&quot;contains\&quot;,\&quot;eventType\&quot;:\&quot;SIL_AI_ALERT\&quot;,\&quot;eventName\&quot;:\&quot;login_common_ip\&quot;,\&quot;fieldValue\&quot;:\&quot;xx\&quot;,\&quot;uuids\&quot;:\&quot;4296ee47-bf19-4fa4-a4a6-6bxxxxxxxxx\&quot;}]</para>
        /// </summary>
        [NameInMap("InsertMarkMissParam")]
        [Validation(Required=false)]
        public string InsertMarkMissParam { get; set; }

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
        /// <para>The source IP address of the request. You do not need to specify this parameter. It is automatically obtained by the system.</para>
        /// 
        /// <b>Example:</b>
        /// <para>127.0.XX.XX</para>
        /// </summary>
        [NameInMap("SourceIp")]
        [Validation(Required=false)]
        public string SourceIp { get; set; }

    }

}
