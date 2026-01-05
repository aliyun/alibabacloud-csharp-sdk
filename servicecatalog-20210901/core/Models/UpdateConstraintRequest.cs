// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class UpdateConstraintRequest : TeaModel {
        /// <summary>
        /// <para>The configurations of the constraint.</para>
        /// <para>Format: { &quot;LocalRoleName&quot;: &quot;\<role_name>&quot; }.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{ &quot;LocalRoleName&quot;: &quot;TestRole&quot; }</para>
        /// </summary>
        [NameInMap("Config")]
        [Validation(Required=false)]
        public string Config { get; set; }

        /// <summary>
        /// <para>The ID of the constraint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cons-bp1yx7x42v****</para>
        /// </summary>
        [NameInMap("ConstraintId")]
        [Validation(Required=false)]
        public string ConstraintId { get; set; }

        /// <summary>
        /// <para>The description of the constraint.</para>
        /// <para>The value must be 1 to 128 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Launch as local role TestRole</para>
        /// 
        /// <b>if can be null:</b>
        /// <c>true</c>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

    }

}
