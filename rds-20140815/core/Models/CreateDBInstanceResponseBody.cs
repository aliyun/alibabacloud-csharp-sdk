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
        /// <para>rm-uf6wjk5****.mysql.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("ConnectionString")]
        [Validation(Required=false)]
        public string ConnectionString { get; set; }

        /// <summary>
        /// <para>The instance ID. If the <b>Amount</b> parameter is set to a value greater than <b>1</b>, the number of instance IDs returned corresponds to the value, separated by commas.</para>
        /// <para>For example, if the <b>Amount</b> parameter is set to <b>3</b>, three instance IDs are returned. Example:
        /// <c>rm-uf6wjk5*****1, rm-uf6wjk5*****2, rm-uf6wjk5*****3</c></para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-uf6wjk5****</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Indicates whether the current request requires a precheck before creating the instance.</para>
        /// <list type="bullet">
        /// <item><description>The return value is fixed to <b>true</b>.</description></item>
        /// <item><description>If no precheck is performed, this parameter is not returned.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("DryRun")]
        [Validation(Required=false)]
        public bool? DryRun { get; set; }

        /// <summary>
        /// <para>Indicates whether the precheck for creating the instance is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Passed.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>If no precheck is performed, this parameter is not returned.</description></item>
        /// <item><description>If the precheck fails, the corresponding error is returned.</description></item>
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
        /// <para>The prompt message for the batch creation task.</para>
        /// <remarks>
        /// <para>This parameter is returned only when the <b>Amount</b> parameter is greater than 1.</para>
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
        /// <para>1007893702****</para>
        /// </summary>
        [NameInMap("OrderId")]
        [Validation(Required=false)]
        public string OrderId { get; set; }

        /// <summary>
        /// <para>The port number corresponding to the internal endpoint of the instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3306</para>
        /// </summary>
        [NameInMap("Port")]
        [Validation(Required=false)]
        public string Port { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1E43AAE0-BEE8-43DA-860D-EAF2AA0724DC</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the instance is successfully tagged. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Succeeded.</description></item>
        /// <item><description><b>false</b>: Failed.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If no tag is bound to the instance, this parameter is not returned.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("TagResult")]
        [Validation(Required=false)]
        public bool? TagResult { get; set; }

        /// <summary>
        /// <para>The task ID of the batch creation task.</para>
        /// <list type="bullet">
        /// <item><description>This parameter is returned only when the <b>Amount</b> parameter is greater than 1.</description></item>
        /// <item><description>Currently, you cannot view the task by using the value of <b>TaskId</b>.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>s2365879-a9d0-55af-fgae-f2****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public string TaskId { get; set; }

    }

}
