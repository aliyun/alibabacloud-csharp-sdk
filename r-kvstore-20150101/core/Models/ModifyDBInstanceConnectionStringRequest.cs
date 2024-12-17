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
        /// <para>The ID of the instance.</para>
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
        /// <item><description><b>Private</b>: internal network</description></item>
        /// <item><description><b>Public</b>: Internet</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Public</para>
        /// </summary>
        [NameInMap("IPType")]
        [Validation(Required=false)]
        public string IPType { get; set; }

        /// <summary>
        /// <para>The prefix of the new endpoint. Specify the endpoint in the <c>&lt;prefix&gt;.redis.rds.aliyuncs.com</c> format. The prefix must be 8 to 40 characters in length and can contain lowercase letters and digits. It must start with a lowercase letter.</para>
        /// <remarks>
        /// <para> You must specify one of the <b>NewConnectionString</b> and <b>Port</b> parameters.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>standardredis</para>
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
        /// <para>The port number that is used to connect to the instance. Valid values: <b>1024</b> to <b>65535</b>.</para>
        /// <remarks>
        /// <para>You must specify one of the <b>NewConnectionString</b> and <b>Port</b> parameters.</para>
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
