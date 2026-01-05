// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class CreateConstraintRequest : TeaModel {
        /// <summary>
        /// <para>The configuration of the constraint.</para>
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
        /// <para>The type of the constraint.</para>
        /// <para>The value is fixed as Launch, which specifies the launch constraint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Launch</para>
        /// </summary>
        [NameInMap("ConstraintType")]
        [Validation(Required=false)]
        public string ConstraintType { get; set; }

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

        /// <summary>
        /// <para>The ID of the product portfolio to which the constraint belongs.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>port-bp1yt7582g****</para>
        /// </summary>
        [NameInMap("PortfolioId")]
        [Validation(Required=false)]
        public string PortfolioId { get; set; }

        /// <summary>
        /// <para>The ID of the product for which the constraint is created.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>prod-bp18r7q127****</para>
        /// </summary>
        [NameInMap("ProductId")]
        [Validation(Required=false)]
        public string ProductId { get; set; }

    }

}
