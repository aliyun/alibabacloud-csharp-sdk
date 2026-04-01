// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class CreateDBInstanceResponseBody : TeaModel {
        /// <summary>
        /// <para>The internal endpoint of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID. If the value of the <b>Amount</b> parameter is greater than <b>1</b>, more than one instance ID is returned. The number of instance IDs that are returned is the same as the value of the Amount parameter. The returned instance IDs are separated by commas (,).</para>
        /// <para>For example, if the value of the <b>Amount</b> parameter is <b>3</b>, three instance IDs are returned. Examples: <c>rm-uf6wjk5*****1,rm-uf6wjk5*****2,rm-uf6wjk5*****3</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5*****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Indicates that the system performed a dry run.</para>
        /// <list type="bullet">
        /// <item><description>The value is fixed as <b>true</b>.</description></item>
        /// <item><description>If the system does not perform a dry run, this parameter is not returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Indicates whether the request passed the dry run. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b></description></item>
        /// <item><description><b>false</b></description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If the system does not perform a dry run, this parameter is not returned.</description></item>
        /// <item><description>If the request failed the dry run, an error message is returned.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRunResult")]
        [Validation(Required=false)]
        public bool? DryRunResult { get; set; }

        /// <summary>
        /// <para>The message that indicates whether multiple instances are created.</para>
        /// <remarks>
        /// <para>The parameter is returned only when the value of the <b>Amount</b> parameter is greater than 1.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Batch Create DBInstance Task Is In Process.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The order ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1007893702*****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The internal IP address and port number that are used to connect to the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E43AAE0-BEE8-43DA-860D-EAF2AA0724DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the specified tag is added to the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: The specified tag is added to the instance.</description></item>
        /// <item><description><b>false</b>: The specified tag fails to be added to the instance.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If you do not add a tag to the instance, this parameter is not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TagResult")]
        [Validation(Required=false)]
        public bool? TagResult { get; set; }

        /// <summary>
        /// <para>The ID of the task that is run to create multiple instances.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is returned only when the value of <b>Amount</b> is greater than 1.</description></item>
        /// <item><description>The <b>TaskID</b> parameter cannot be used to query a task.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s2365879-a9d0-55af-fgae-f2*****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
