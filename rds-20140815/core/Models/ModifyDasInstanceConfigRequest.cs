// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDasInstanceConfigRequest : TeaModel {
        /// <summary>
        /// <para>The client token that is used to ensure the idempotence of the request and prevent duplicate submissions. You can generate the value of this parameter on the client side. The value must be unique across different requests and can be up to 64 ASCII characters in length. The value cannot contain non-ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ETnLKlblzczshOTUbOCz****</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>Instance ID of the instance. You can call the DescribeDBInstances operation to query instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>Specifies whether to enable automatic storage expansion. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Enable</b>: Enables automatic storage expansion.</description></item>
        /// <item><description><b>Disable</b>: Disables automatic storage expansion.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Enable</para>
        /// </summary>
        [NameInMap("StorageAutoScale")]
        [Validation(Required=false)]
        public string StorageAutoScale { get; set; }

        /// <summary>
        /// <para>The threshold percentage that triggers automatic storage expansion. When the percentage of remaining storage space reaches the specified threshold, automatic storage expansion is triggered. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>10</b></description></item>
        /// <item><description><b>20</b></description></item>
        /// <item><description><b>30</b></description></item>
        /// <item><description><b>40</b></description></item>
        /// <item><description><b>50</b></description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required when <b>StorageAutoScale</b> is set to <b>Enable</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("StorageThreshold")]
        [Validation(Required=false)]
        public int? StorageThreshold { get; set; }

        /// <summary>
        /// <para>The upper limit for automatic storage expansion. The value must be greater than or equal to the current total storage capacity of the instance.</para>
        /// <list type="bullet">
        /// <item><description>Upper limit for ESSDs: 32,000 GB</description></item>
        /// <item><description>Upper limit for standard SSDs: 6,000 GB<remarks>
        /// <para>This parameter is required when <b>StorageAutoScale</b> is set to <b>Enable</b>.</para>
        /// </remarks>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("StorageUpperBound")]
        [Validation(Required=false)]
        public int? StorageUpperBound { get; set; }

    }

}
