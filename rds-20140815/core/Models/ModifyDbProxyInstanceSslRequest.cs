// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Rds20140815.Models
{
    public class ModifyDbProxyInstanceSslRequest : TeaModel {
        /// <summary>
        /// <para>A reserved parameter. You do not need to specify this parameter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>normal</para>
        /// </summary>
        [NameInMap("DBProxyEngineType")]
        [Validation(Required=false)]
        public string DBProxyEngineType { get; set; }

        /// <summary>
        /// <para>The instance ID. You can call the DescribeDBInstances operation to query the instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rm-t4n3axxxxx</para>
        /// </summary>
        [NameInMap("DbInstanceId")]
        [Validation(Required=false)]
        public string DbInstanceId { get; set; }

        /// <summary>
        /// <para>The dedicated proxy endpoint of the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test123456.rwlb.rds.aliyuncs.com</para>
        /// </summary>
        [NameInMap("DbProxyConnectString")]
        [Validation(Required=false)]
        public string DbProxyConnectString { get; set; }

        /// <summary>
        /// <para>The ID of the proxy endpoint. You can call the DescribeDBProxyEndpoint operation to query the ID of the proxy endpoint.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ta9um4xxxxx</para>
        /// </summary>
        [NameInMap("DbProxyEndpointId")]
        [Validation(Required=false)]
        public string DbProxyEndpointId { get; set; }

        /// <summary>
        /// <para>The SSL configuration setting that you want to apply on the instance. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: disables SSL encryption.</description></item>
        /// <item><description>1: enables SSL encryption or modifies the endpoint that requires SSL encryption.</description></item>
        /// <item><description>2: updates the validity period of the SSL certificate.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This setting causes your instance to restart. Proceed with caution.</para>
        /// </remarks>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("DbProxySslEnabled")]
        [Validation(Required=false)]
        public string DbProxySslEnabled { get; set; }

        /// <summary>
        /// <para>The region ID. You can call the DescribeRegions operation to query the most recent region list.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

    }

}
