// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifySrvNetworkAddressRequest : TeaModel {
        /// <summary>
        /// <para>The type of the SRV endpoint to be modified. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>VPC</b>: VPC</description></item>
        /// <item><description><b>Public</b>: public network connection</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>VPC</para>
        /// </summary>
        [NameInMap("ConnectionType")]
        [Validation(Required=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dds-bp1fd530f271****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The new endpoint. The endpoint must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description>Start with a lowercase letter.</description></item>
        /// <item><description>End with a lowercase letter or a digit.</description></item>
        /// <item><description>Contain only lowercase letters, digits, and hyphens (-).</description></item>
        /// <item><description>Be 8 to 63 characters in length.</description></item>
        /// </list>
        /// <remarks>
        /// <para>Specify only the prefix of the endpoint. The remaining part cannot be modified.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aliyuntest111</para>
        /// </summary>
        [NameInMap("NewConnectionString")]
        [Validation(Required=false)]
        public string NewConnectionString { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

    }

}
