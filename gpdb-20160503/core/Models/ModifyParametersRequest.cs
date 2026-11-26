// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Gpdb20160503.Models
{
    public class ModifyParametersRequest : TeaModel {
        /// <summary>
        /// <para>The instance ID.</para>
        /// <remarks>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/86911.html">DescribeDBInstances</a> operation to query the details of all AnalyticDB for PostgreSQL instances in a specific region, including the instance IDs.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>gp-bp***************</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>Specifies whether to forcibly restart the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Forcibly restarts the instance.</description></item>
        /// <item><description><b>false</b> (default): Does not forcibly restart the instance.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("ForceRestartInstance")]
        [Validation(Required=false)]
        public bool? ForceRestartInstance { get; set; }

        /// <summary>
        /// <para>The names and values of the parameters to be modified. The format is <c>&lt;ParameterName&gt;:&lt;ParameterValue&gt;</c>.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/208310.html">DescribeParameters</a> operation to query the configuration parameters that can be modified.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;statement_timeout&quot;:&quot;11800010&quot;}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

    }

}
