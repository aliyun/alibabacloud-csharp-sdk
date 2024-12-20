// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyDBInstanceSSLRequest : TeaModel {
        /// <summary>
        /// <para>The encrypted endpoint. By default, the wildcards are used for instances that are hosted on ECS instances. This way, the endpoints that can be resolved to the same IP address are encrypted.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxxxx-master.gpdbmaster.singapore.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The ID of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-xxxxxxxxxxx</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The status of SSL encryption. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disables SSL encryption.</description></item>
        /// <item><description>1: enables SSL encryption.</description></item>
        /// <item><description>2: updates SSL encryption.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("SSLEnabled")]
        [Validation(Required=false)]
        public int? SSLEnabled { get; set; }

    }

}
