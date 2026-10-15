// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BssOpenApi20171214.Models
{
    public class RenewChangeInstanceRequest : TeaModel {
        /// <summary>
        /// <para>Ensures the idempotence of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>JASIOFKVNVIXXXXXX</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-skjdhaskjdh</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>Module list</para>
        /// </summary>
        [NameInMap("Parameter")]
        [Validation(Required=false)]
        public List<RenewChangeInstanceRequestParameter> Parameter { get; set; }
        public class RenewChangeInstanceRequestParameter : TeaModel {
            /// <summary>
            /// <para>The code configuration for the Nth module property. The value of N can be an integer from 1 to 100. If you have multiple module properties, create a separate parameter for each by setting n to 1, 2, 3, and so on.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Bandwidth</para>
            /// </summary>
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            /// <summary>
            /// <para>The value configuration for the nth module property. The value of n ranges from 1 to 100.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>disk</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// <para>The product code. To obtain it, call <b>QueryProductList</b>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductCode")]
        [Validation(Required=false)]
        public string ProductCode { get; set; }

        /// <summary>
        /// <para>Product type</para>
        /// 
        /// <b>Example:</b>
        /// <para>rds</para>
        /// </summary>
        [NameInMap("ProductType")]
        [Validation(Required=false)]
        public string ProductType { get; set; }

        /// <summary>
        /// <para>The subscription renewal duration, in months. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>1-9</para>
        /// </description></item>
        /// <item><description><para>12</para>
        /// </description></item>
        /// <item><description><para>24</para>
        /// </description></item>
        /// <item><description><para>36</para>
        /// </description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("RenewPeriod")]
        [Validation(Required=false)]
        public long? RenewPeriod { get; set; }

    }

}
