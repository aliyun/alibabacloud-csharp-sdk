// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsDetailRequest : TeaModel {
        /// <summary>
        /// <para>The query condition.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The page number of the current page in a paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The public IP address that is exposed on the Internet for the asset to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>116.12.XX.XX</para>
        /// </summary>
        [NameInMap("ExposureIp")]
        [Validation(Required=false)]
        public string ExposureIp { get; set; }

        /// <summary>
        /// <para>The instance ID of the asset to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>s-bp1g6wxdwps7s9dz****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page in a paged query. Default value: 20. If you leave this parameter empty, 20 entries are returned per page.</para>
        /// <remarks>
        /// <para>Set PageSize to a non-empty value.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member accounts in the resource folder.</para>
        /// <remarks>
        /// <para>Invoke the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain this parameter.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1232428423234****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The type of statistics to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>exposureType</b>: gateway assets exposed on the Internet.</description></item>
        /// <item><description><b>exposurePort</b>: ports exposed on the Internet.</description></item>
        /// <item><description><b>exposureComponent</b>: system components exposed on the Internet.</description></item>
        /// <item><description><b>exposureIp</b>: IP addresses exposed on the Internet.</description></item>
        /// </list>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>exposureType</para>
        /// </summary>
        [NameInMap("StatisticsType")]
        [Validation(Required=false)]
        public string StatisticsType { get; set; }

        /// <summary>
        /// <para>The Asset Type of the gateway to query. This parameter takes effect only when <b>StatisticsType</b> is set to <b>exposureType</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SLB</b>: public IP address of a load balancing SLB instance.</description></item>
        /// <item><description><b>DNAT</b>: NAT gateway that uses the DNAT feature to connect to the Internet.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLB</para>
        /// </summary>
        [NameInMap("StatisticsTypeGatewayType")]
        [Validation(Required=false)]
        public string StatisticsTypeGatewayType { get; set; }

        /// <summary>
        /// <para>The instance ID of the gateway to query. This parameter takes effect only when <b>StatisticsType</b> is set to <b>exposureType</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2ze4rso39h4nczcqs****</para>
        /// </summary>
        [NameInMap("StatisticsTypeInstanceValue")]
        [Validation(Required=false)]
        public string StatisticsTypeInstanceValue { get; set; }

        /// <summary>
        /// <para>The UUID of the server to query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9107c04-942f-40c1-981a-f1c1***</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
