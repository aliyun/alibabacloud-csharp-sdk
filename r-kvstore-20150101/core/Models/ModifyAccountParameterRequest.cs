// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyAccountParameterRequest : TeaModel {
        /// <summary>
        /// <para>The account name.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>demoaccount</para>
        /// </summary>
        [NameInMap("AccountName")]
        [Validation(Required=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1s4h3oosz5y8ilc7</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The account parameters to modify, in JSON format. The modified values overwrite the original values. For example, if you want to modify only the access-db-id parameter to 1, pass in {&quot;access-db-id&quot;:&quot;1&quot;}.
        /// Only two parameters are supported: access-db-id (accessible DB ID) and cu-limit (CU Limit).</para>
        /// <remarks>
        /// <para>Notice: Currently, only Tair Serverless KV instances are supported.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;access-db-id&quot;:&quot;1&quot;,&quot;cu-limit&quot;:&quot;10&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
