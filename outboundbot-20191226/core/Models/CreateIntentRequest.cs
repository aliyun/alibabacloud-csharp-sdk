// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OutboundBot20191226.Models
{
    public class CreateIntentRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>361c8a53-0e29-42f3-8aa7-c7752d010399</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>A description of the intent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>确定是本人的意图</para>
        /// </summary>
        [NameInMap("IntentDescription")]
        [Validation(Required=false)]
        public string IntentDescription { get; set; }

        /// <summary>
        /// <para>The name of the intent. This name must be unique within the script.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>是本人</para>
        /// </summary>
        [NameInMap("IntentName")]
        [Validation(Required=false)]
        public string IntentName { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string containing an array of keywords that help identify the intent.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;是&quot;,&quot;是的&quot;]</para>
        /// </summary>
        [NameInMap("Keywords")]
        [Validation(Required=false)]
        public string Keywords { get; set; }

        /// <summary>
        /// <para>The script ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c5c5d8c0-c0f1-48a7-be2b-dc46006d888a</para>
        /// </summary>
        [NameInMap("ScriptId")]
        [Validation(Required=false)]
        public string ScriptId { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string containing an array of sample utterances that trigger this intent.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;是&quot;,&quot;是的&quot;,&quot;是啊&quot;,&quot;嗯嗯&quot;,&quot;是我&quot;,&quot;是我，有事吗&quot;,&quot;对，是&quot;,&quot;对的&quot;,&quot;对是我&quot;,&quot;&quot;]</para>
        /// </summary>
        [NameInMap("Utterances")]
        [Validation(Required=false)]
        public string Utterances { get; set; }

    }

}
