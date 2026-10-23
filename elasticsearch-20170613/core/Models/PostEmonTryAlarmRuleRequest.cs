// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class PostEmonTryAlarmRuleRequest : TeaModel {
        /// <summary>
        /// <para>The information about the test alert rule, notification method, and message recipients.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;alarmRuleName&quot;:&quot;test_rule&quot;,&quot;AlarmChannel&quot;:{&quot;phone&quot;:true,&quot;sms&quot;:true,&quot;dingWebHook&quot;:true},&quot;receivers&quot;:[{&quot;id&quot;:19,&quot;contactGroup&quot;:false}]}</para>
        /// </summary>
        [NameInMap("body")]
        [Validation(Required=false)]
        public string Body { get; set; }

    }

}
