// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class CreateDispatchRuleRequest : TeaModel {
        /// <summary>
        /// <para>The dispatch rule configuration. The value is a JSON string. For more information about this parameter, see the following <b>additional information about the DispatchRule parameter</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{   &quot;system&quot;: false,   &quot;ruleid&quot;: 10282,   &quot;name&quot;: &quot;Prometheus Alert&quot;,   &quot;labelMatchExpressionGrid&quot;: {     &quot;labelMatchExpressionGroups&quot;: [       {         &quot;labelMatchExpressions&quot;: [           {             &quot;key&quot;: &quot;_aliyun_arms_involvedObject_kind&quot;,             &quot;value&quot;: &quot;app&quot;,             &quot;operator&quot;: &quot;eq&quot;           }         ]       }     ]   },   &quot;dispatchType&quot;: &quot;CREATE_ALERT/DISCARD_ALERT&quot;,   &quot;isRecover&quot;: true,   &quot;groupRules&quot;: [     {       &quot;groupId&quot;: 1,       &quot;groupingFields&quot;: [         &quot;alertname&quot;       ],       &quot;groupWait&quot;: 10,       &quot;groupInterval&quot;: 15,       &quot;repeatInterval&quot;: 20     }   ],   &quot;notifyRules&quot;: [     {       &quot;notifyObjects&quot;: [         {           &quot;notifyType&quot;: &quot;ARMS_CONTACT&quot;,           &quot;name&quot;: &quot;JohnDoe&quot;,           &quot;notifyObjectId&quot;: 1         },         {           &quot;notifyType&quot;: &quot;ARMS_CONTACT_GROUP&quot;,           &quot;name&quot;: &quot;JohnDoe_group&quot;,           &quot;notifyObjectId&quot;: 2         }       ],       &quot;notifyChannels&quot;:[&quot;dingTalk&quot;,&quot;wechat&quot;,&quot;webhook&quot;,&quot;email&quot;]     },   ], }</para>
        /// </summary>
        [NameInMap("DispatchRule")]
        [Validation(Required=false)]
        public string DispatchRule { get; set; }

        /// <summary>
        /// <para>The ID of the region.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
