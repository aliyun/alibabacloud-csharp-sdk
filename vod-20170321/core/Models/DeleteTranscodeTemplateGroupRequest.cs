// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class DeleteTranscodeTemplateGroupRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to forcibly delete the transcoding template group. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: deletes the transcoding template group and all the transcoding templates in the group.</description></item>
        /// <item><description><b>false</b> (default): deletes only the specified transcoding templates from the transcoding template group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ForceDelGroup")]
        [Validation(Required=false)]
        public string ForceDelGroup { get; set; }

        /// <summary>
        /// <para>The ID of the transcoding template group.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4c71a339fec*****152b4fa6f4527</para>
        /// </summary>
        [NameInMap("TranscodeTemplateGroupId")]
        [Validation(Required=false)]
        public string TranscodeTemplateGroupId { get; set; }

        /// <summary>
        /// <para>The IDs of the transcoding templates that you want to delete.</para>
        /// <list type="bullet">
        /// <item><description>Separate multiple IDs with commas (,).</description></item>
        /// <item><description>You can specify a maximum of 10 IDs.</description></item>
        /// <item><description>This parameter is required if you set ForceDelGroup to false or leave ForceDelGroup empty.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;613702defdc4<em><b><b>6a3b94cace1129e&quot;,&quot;bfd6c90253a2</b></b></em>7fc054d7c5825&quot;]</para>
        /// </summary>
        [NameInMap("TranscodeTemplateIds")]
        [Validation(Required=false)]
        public string TranscodeTemplateIds { get; set; }

    }

}
