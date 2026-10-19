// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.R_kvstore20150101.Models
{
    public class MasterNodeShutDownFailOverRequest : TeaModel {
        /// <summary>
        /// <para>The resource type. Set the value to <c>instance</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>instance</para>
        /// </summary>
        [NameInMap("Category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Specify</b>: Specifies the data nodes.</description></item>
        /// <item><description><b>Random</b>: The system randomly simulates a failure for one-fourth of the data nodes (rounded up to the nearest integer, with a minimum of 1). This parameter takes effect only when no data nodes are specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Random</para>
        /// </summary>
        [NameInMap("DBFaultMode")]
        [Validation(Required=false)]
        public string DBFaultMode { get; set; }

        /// <summary>
        /// <para>The specified data nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-rdsdavinx01003-db-0,r-rdsdavinx01003-db-1</para>
        /// </summary>
        [NameInMap("DBNodes")]
        [Validation(Required=false)]
        public string DBNodes { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Hard</b>: Simulates an unrecoverable hardware failure. A switchover (HA) is directly triggered.</description></item>
        /// <item><description><b>Soft</b> (default): Simulates a recoverable hardware failure. The system preferentially attempts to recover the failed node. If the recovery fails, a switchover (HA) is triggered.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Hard</para>
        /// </summary>
        [NameInMap("FailMode")]
        [Validation(Required=false)]
        public string FailMode { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the <a href="https://help.aliyun.com/document_detail/473778.html">DescribeInstances</a> operation to query the instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>r-bp1zxszhcgatnx****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <list type="bullet">
        /// <item><description><b>Specify</b>: Specifies the proxy nodes.</description></item>
        /// <item><description><b>Random</b>: The system randomly simulates a failure for one-fourth of the proxy nodes (rounded up to the nearest integer, with a minimum of 1). This parameter takes effect only when no proxy nodes are specified.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Specify</para>
        /// </summary>
        [NameInMap("ProxyFaultMode")]
        [Validation(Required=false)]
        public string ProxyFaultMode { get; set; }

        /// <summary>
        /// <para>The specified proxy nodes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6981,6982</para>
        /// </summary>
        [NameInMap("ProxyInstanceIds")]
        [Validation(Required=false)]
        public string ProxyInstanceIds { get; set; }

    }

}
