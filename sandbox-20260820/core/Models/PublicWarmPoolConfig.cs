// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sandbox20260820.Models
{
    public class PublicWarmPoolConfig : TeaModel {
        /// <summary>
        /// <para>The warm pool capacity policy, which includes the base target capacity and optional scheduling rules.</para>
        /// </summary>
        [NameInMap("capacityPolicy")]
        [Validation(Required=false)]
        public WarmPoolCapacityPolicy CapacityPolicy { get; set; }

        /// <summary>
        /// <para>Indicates whether the warm pool is being deleted.</para>
        /// </summary>
        [NameInMap("deleting")]
        [Validation(Required=false)]
        public bool? Deleting { get; set; }

        /// <summary>
        /// <para>The team ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>team-example1234567890</para>
        /// </summary>
        [NameInMap("teamID")]
        [Validation(Required=false)]
        public string TeamID { get; set; }

        /// <summary>
        /// <para>The template ID, which specifies the template associated with the warm pool.</para>
        /// 
        /// <b>Example:</b>
        /// <para>tpl-example1234567890</para>
        /// </summary>
        [NameInMap("templateID")]
        [Validation(Required=false)]
        public string TemplateID { get; set; }

    }

}
