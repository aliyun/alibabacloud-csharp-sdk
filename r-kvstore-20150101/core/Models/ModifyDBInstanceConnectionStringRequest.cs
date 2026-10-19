// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class ModifyDBInstanceConnectionStringRequest : TeaModel {
        /// <summary>
        /// <para>The current endpoint of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****.redis.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("CurrentConnectionString")]
        [Validation(Required=false)]
        public string CurrentConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The network type of the endpoint. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Private</b>: virtual private cloud (VPC).</description></item>
        /// <item><description><b>Public</b>: Internet.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("IPType")]
        [Validation(Required=false)]
        public string IPType { get; set; }

        /// <summary>
        /// <para>The prefix of the new endpoint. The endpoint of the instance is in the format of <c>&lt;prefix&gt;.redis.rds.aliyuncs.com</c>. The prefix must start with a lowercase letter and can contain lowercase letters and digits. The prefix must be 8 to 40 characters in length.</para>
        /// <remarks>
        /// <para>You must specify at least one of the request parameters <b>NewConnectionString</b> and <b>Port</b>.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standardredis123</para>
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

        /// <summary>
        /// <para>The service port number of the instance. Valid values: <b>1</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para>You must specify at least one of the request parameters <b>NewConnectionString</b> and <b>Port</b>.</para>
        /// </remarks>
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
