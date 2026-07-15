// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dds20151201.Models
{
    public class ModifySrvNetworkAddressRequest : TeaModel {
        /// <summary>
        /// <para>The type of the SRV connection address to modify. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>VPC</b>: virtual private cloud (VPC)</para>
        /// </description></item>
        /// <item><description><para><b>Public</b>: Internet connection</para>
        /// </description></item>
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
        /// <para>The new connection address. The address must meet the following requirements:</para>
        /// <list type="bullet">
        /// <item><description><para>Starts with a lowercase letter.</para>
        /// </description></item>
        /// <item><description><para>Ends with a lowercase letter or a digit.</para>
        /// </description></item>
        /// <item><description><para>Contains only lowercase letters, digits, and hyphens (-).</para>
        /// </description></item>
        /// <item><description><para>Is 8 to 63 characters in length.</para>
        /// </description></item>
        /// </list>
        /// <remarks>
        /// <para>You only need to specify the prefix of the connection address. The rest of the address cannot be modified.</para>
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
