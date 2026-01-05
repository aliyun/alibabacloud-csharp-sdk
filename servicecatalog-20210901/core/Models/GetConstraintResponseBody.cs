// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Servicecatalog20210901.Models
{
    public class GetConstraintResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the constraint.</para>
        /// </summary>
        [NameInMap("ConstraintDetail")]
        [Validation(Required=false)]
        public GetConstraintResponseBodyConstraintDetail ConstraintDetail { get; set; }
        public class GetConstraintResponseBodyConstraintDetail : TeaModel {
            /// <summary>
            /// <para>The configuration of the constraint.</para>
            /// <para>Format: { &quot;LocalRoleName&quot;: &quot;\<role_name>&quot; }.</para>
            /// 
            /// <b>Example:</b>
            /// <para>{ &quot;LocalRoleName&quot;: &quot;TestRole&quot; }</para>
            /// </summary>
            [NameInMap("Config")]
            [Validation(Required=false)]
            public string Config { get; set; }

            /// <summary>
            /// <para>The ID of the constraint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cons-bp1yx7x42v****</para>
            /// </summary>
            [NameInMap("ConstraintId")]
            [Validation(Required=false)]
            public string ConstraintId { get; set; }

            /// <summary>
            /// <para>The type of the constraint.</para>
            /// <para>The value is fixed as Launch, which indicates the launch constraint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Launch</para>
            /// </summary>
            [NameInMap("ConstraintType")]
            [Validation(Required=false)]
            public string ConstraintType { get; set; }

            /// <summary>
            /// <para>The time when the constraint was created.</para>
            /// <para>The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2022-04-12T06:11:26Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <para>The description of the constraint.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Launch as local role TestRole</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the product portfolio to which the constraint belongs.</para>
            /// 
            /// <b>Example:</b>
            /// <para>port-bp1yt7582g****</para>
            /// </summary>
            [NameInMap("PortfolioId")]
            [Validation(Required=false)]
            public string PortfolioId { get; set; }

            /// <summary>
            /// <para>The ID of the product for which the constraint is created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod-bp18r7q127****</para>
            /// </summary>
            [NameInMap("ProductId")]
            [Validation(Required=false)]
            public string ProductId { get; set; }

            /// <summary>
            /// <para>The name of the product.</para>
            /// 
            /// <b>Example:</b>
            /// <para>DEMO-Create an ECS instance.</para>
            /// </summary>
            [NameInMap("ProductName")]
            [Validation(Required=false)]
            public string ProductName { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0FEEF92D-4052-5202-87D0-3D8EC16F81BF</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
