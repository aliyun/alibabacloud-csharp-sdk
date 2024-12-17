// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class MasterNodeShutDownFailOverRequest : TeaModel {
        /// <summary>
        /// <para>The resource category. Set the value to instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specify: This mode allows you to specify a database node to use.</description></item>
        /// <item><description>Random: In this mode, a random database node is selected when no database node is specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Random</para>
        /// </summary>
        [NameInMap("DBFaultMode")]
        [Validation(Required=false)]
        public string DBFaultMode { get; set; }

        /// <summary>
        /// <para>The IDs of the database nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-rdsdavinx01003-db-0,r-rdsdavinx01003-db-1</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public string DBNodes { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Safe: safe shutdown. This mode involves using redis_safe to shut down the Redis process.</description></item>
        /// <item><description>UnSafe: non-secure shutdown. This mode involves using the shutdown command to shut down the Redis process.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Safe</para>
        /// </summary>
        [NameInMap("FailMode")]
        [Validation(Required=false)]
        public string FailMode { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/60933.html">DescribeInstances</a> operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description>Specify: This mode allows you to specify a proxy node to use.</description></item>
        /// <item><description>Random: In this mode, a random proxy node is selected when no proxy node is specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Specify</para>
        /// </summary>
        [NameInMap("ProxyFaultMode")]
        [Validation(Required=false)]
        public string ProxyFaultMode { get; set; }

        /// <summary>
        /// <para>The IDs of the proxy nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6981,6982</para>
        /// </summary>
        [NameInMap("ProxyInstanceIds")]
        [Validation(Required=false)]
        public string ProxyInstanceIds { get; set; }

    }

}
