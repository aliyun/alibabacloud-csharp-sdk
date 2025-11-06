// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeExposedStatisticsDetailRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>{}</para>
        /// </summary>
        [NameInMap("Criteria")]
        [Validation(Required=false)]
        public string Criteria { get; set; }

        /// <summary>
        /// <para>The number of the page to return.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: 20. If you leave this parameter empty, 20 entries are returned on each page.</para>
        /// <remarks>
        /// <para> We recommend that you do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The Alibaba Cloud account ID of the member in the resource directory.</para>
        /// <remarks>
        /// <para> You can call the <a href="~~DescribeMonitorAccounts~~">DescribeMonitorAccounts</a> operation to obtain the ID.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>127608589417****</para>
        /// </summary>
        [NameInMap("ResourceDirectoryAccountId")]
        [Validation(Required=false)]
        public long? ResourceDirectoryAccountId { get; set; }

        /// <summary>
        /// <para>The type of the exposed asset. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>exposureType</b>: gateway assets</description></item>
        /// <item><description><b>exposurePort</b>: ports</description></item>
        /// <item><description><b>exposureComponent</b>: system components</description></item>
        /// <item><description><b>exposureIp</b>: IP addresses</description></item>
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
        /// <para>The type of the gateway asset. This parameter is required when the <b>StatisticsType</b> parameter is set to <b>exposureType</b>. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>SLB</b>: the public IP address of a Server Load Balancer (SLB) instance</description></item>
        /// <item><description><b>DNAT</b>: the NAT gateway that connects to the Internet by using the DNAT feature</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>SLB</para>
        /// </summary>
        [NameInMap("StatisticsTypeGatewayType")]
        [Validation(Required=false)]
        public string StatisticsTypeGatewayType { get; set; }

        /// <summary>
        /// <para>The ID of the gateway asset. This parameter is required when the <b>StatisticsType</b> parameter is set to <b>exposureType</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>lb-2ze4rso39h4nczcqs****</para>
        /// </summary>
        [NameInMap("StatisticsTypeInstanceValue")]
        [Validation(Required=false)]
        public string StatisticsTypeInstanceValue { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>c9107c04-942f-40c1-981a-f1c1***</para>
        /// </summary>
        [NameInMap("Uuid")]
        [Validation(Required=false)]
        public string Uuid { get; set; }

    }

}
