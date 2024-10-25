// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ens20171110.Models
{
    public class CreateStorageGatewayRequest : TeaModel {
        /// <summary>
        /// <para>The array of orders.</para>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("OrderDetails")]
        [Validation(Required=false)]
        public List<CreateStorageGatewayRequestOrderDetails> OrderDetails { get; set; }
        public class CreateStorageGatewayRequestOrderDetails : TeaModel {
            /// <summary>
            /// <para>The description of the gateway. The description must be 2 to 256 characters in length and cannot start with <c>http://</c> or <c>https://</c>.</para>
            /// 
            /// <b>Example:</b>
            /// <para>testDescription</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The ID of the node.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-shenzhen-3</para>
            /// </summary>
            [NameInMap("EnsRegionId")]
            [Validation(Required=false)]
            public string EnsRegionId { get; set; }

            /// <summary>
            /// <para>The name of the gateway. The name must be 2 to 128 characters in length. The name must start with a letter and cannot start with <c>http://</c> or <c>https://</c>. The name can contain letters, digits, colons (.), underscores (_), and hyphens (-).</para>
            /// 
            /// <b>Example:</b>
            /// <para>testGatewayName</para>
            /// </summary>
            [NameInMap("GatewayName")]
            [Validation(Required=false)]
            public string GatewayName { get; set; }

            /// <summary>
            /// <para>The type of the gateway. Set this parameter to <b>1</b>. <b>1</b> indicates iSCSI.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("GatewayType")]
            [Validation(Required=false)]
            public string GatewayType { get; set; }

            /// <summary>
            /// <para>The ID of the VPC.</para>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>n-123</para>
            /// </summary>
            [NameInMap("VpcId")]
            [Validation(Required=false)]
            public string VpcId { get; set; }

        }

    }

}
