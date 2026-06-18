// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class UpdatePolarDBXInstanceNodeRequest : TeaModel {
        [NameInMap("AddDNSpec")]
        [Validation(Required=false)]
        public string AddDNSpec { get; set; }

        /// <summary>
        /// <para>The number of compute nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("CNNodeCount")]
        [Validation(Required=false)]
        public int? CNNodeCount { get; set; }

        /// <summary>
        /// <para>The client token. You can set this parameter to any random string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance name ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzjasdyuoo</para>
        /// </summary>
        [NameInMap("DBInstanceName")]
        [Validation(Required=false)]
        public string DBInstanceName { get; set; }

        /// <summary>
        /// <para>The number of storage nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("DNNodeCount")]
        [Validation(Required=false)]
        public int? DNNodeCount { get; set; }

        /// <summary>
        /// <para>The target number of nodes for the instance. Valid values: 0 to 99.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("DbInstanceNodeCount")]
        [Validation(Required=false)]
        public int? DbInstanceNodeCount { get; set; }

        [NameInMap("DeleteDNIds")]
        [Validation(Required=false)]
        public string DeleteDNIds { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        [NameInMap("StoragePoolName")]
        [Validation(Required=false)]
        public string StoragePoolName { get; set; }

    }

}
