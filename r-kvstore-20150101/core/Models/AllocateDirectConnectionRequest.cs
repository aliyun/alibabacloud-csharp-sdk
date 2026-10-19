// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class AllocateDirectConnectionRequest : TeaModel {
        /// <summary>
        /// <para>The prefix of the direct connection endpoint. The prefix must be 8 to 40 characters in length and can contain lowercase letters and digits. It must start with a lowercase letter. Default value: the instance ID followed by <c>-direct</c>. For example, if the instance ID is r-8vbwsicr5d5gse****, the default value is <c>r-8vbwsicr5d5gse****-direct</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>redisdirect123</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID. Only cluster instances deployed in classic mode are supported. For instances deployed in classic mode, the value of the ComputingType parameter is Machine. You can call the DescribeInstances operation to query the ComputingType parameter.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The port number. Valid values: <b>1024</b> to <b>65535</b>. Default value: <b>6379</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6379</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        [NameInMap("SecurityToken")]
        [Validation(Required=false)]
        public string SecurityToken { get; set; }

    }

}
