// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class CreateWarmPoolInput : TeaModel {
        /// <summary>
        /// <para>The warm pool capacity policy, which includes the base target capacity and optional scheduled rules.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("capacityPolicy")]
        [Validation(Required=false)]
        public WarmPoolCapacityPolicyInput CapacityPolicy { get; set; }

        /// <summary>
        /// <para>The template ID, which specifies the template associated with the warm pool.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl-example1234567890</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
