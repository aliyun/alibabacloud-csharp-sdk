// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Emr20210320.Models
{
    public class PrivatePoolOptions : TeaModel {
        /// <summary>
        /// <para>The type of private pool that you want to use to start ECS instances. A private pool is generated when an elasticity assurance or a capacity reservation takes effect. You can select a private pool for starting ECS instances. Valid values: Open, Target, and None. If you set the parameter to Open, the system selects an open private pool to start instances. If no matching open private pools exist, the resources in the public pool are used. In this case, you do not need to specify the ID of the private pool. If you set the parameter to Target, the resources in the specified private pool are used to start ECS instances. If the specified private pool does not exist, ECS instances cannot be started. You must specify the ID of the private pool when you set the parameter to Target. If you set the parameter to None, the resources in private pools are not used to start instances. Default value: None.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Open</para>
        /// </summary>
        [NameInMap("MatchCriteria")]
        [Validation(Required=false)]
        public string MatchCriteria { get; set; }

        /// <summary>
        /// <para>The IDs of the private pools.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eap-bp67acfmxazb4****</para>
        /// </summary>
        [NameInMap("PrivatePoolIds")]
        [Validation(Required=false)]
        public List<string> PrivatePoolIds { get; set; }

    }

}
