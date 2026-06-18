// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Polardbx20200202.Models
{
    public class ModifyParameterRequest : TeaModel {
        /// <summary>
        /// <para>The client request token. You can set this parameter to any unique string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>FEA5DC20-6D8A-5979-97AA-FC57546ADC20</para>
        /// </summary>
        [NameInMap("ClientToken")]
        [Validation(Required=false)]
        public string ClientToken { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>pxc-hzjasdyuoo</para>
        /// </summary>
        [NameInMap("DBInstanceId")]
        [Validation(Required=false)]
        public string DBInstanceId { get; set; }

        /// <summary>
        /// <para>The parameter type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>compute</b>: compute layer parameters.</description></item>
        /// <item><description><b>storage</b>: storage layer parameters.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>compute</para>
        /// </summary>
        [NameInMap("ParamLevel")]
        [Validation(Required=false)]
        public string ParamLevel { get; set; }

        [NameInMap("ParameterGroupId")]
        [Validation(Required=false)]
        public string ParameterGroupId { get; set; }

        /// <summary>
        /// <para>A JSON-formatted string. MapKey specifies the parameter name, and MapValue specifies the parameter value. The modifiable parameters are dynamically added or removed. Call the <a href="https://help.aliyun.com/document_detail/196856.html">DescribeParameterTemplates</a> operation to query the available parameters. You can specify multiple parameters in a single request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;CONN_POOL_BLOCK_TIMEOUT&quot;:6000}</para>
        /// </summary>
        [NameInMap("Parameters")]
        [Validation(Required=false)]
        public string Parameters { get; set; }

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

    }

}
