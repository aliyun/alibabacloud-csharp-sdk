// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyTairAIGatewayPluginSwitchRequest : TeaModel {
        /// <summary>
        /// <para>The Tair AI gateway instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tg-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The plug-in switch parameters for the Tair AI gateway instance. Format: {&quot;PluginName1&quot;:&quot;true/false&quot;,&quot;PluginName2&quot;:&quot;true/false&quot;,...}. The specified values overwrite the existing values.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{\&quot;lang_cache\&quot;:\&quot;false\&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-beijing</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
