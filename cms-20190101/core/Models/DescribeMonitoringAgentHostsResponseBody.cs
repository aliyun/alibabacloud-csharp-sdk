// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeMonitoringAgentHostsResponseBody : TeaModel {
        /// <summary>
        /// <para>The HTTP status code.</para>
        /// <remarks>
        /// <para>The status code 200 indicates that the call is successful.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Hosts")]
        [Validation(Required=false)]
        public DescribeMonitoringAgentHostsResponseBodyHosts Hosts { get; set; }
        public class DescribeMonitoringAgentHostsResponseBodyHosts : TeaModel {
            [NameInMap("Host")]
            [Validation(Required=false)]
            public List<DescribeMonitoringAgentHostsResponseBodyHostsHost> Host { get; set; }
            public class DescribeMonitoringAgentHostsResponseBodyHostsHost : TeaModel {
                [NameInMap("AgentVersion")]
                [Validation(Required=false)]
                public string AgentVersion { get; set; }

                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                [NameInMap("EipAddress")]
                [Validation(Required=false)]
                public string EipAddress { get; set; }

                [NameInMap("EipId")]
                [Validation(Required=false)]
                public string EipId { get; set; }

                [NameInMap("HostName")]
                [Validation(Required=false)]
                public string HostName { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceTypeFamily")]
                [Validation(Required=false)]
                public string InstanceTypeFamily { get; set; }

                [NameInMap("IpGroup")]
                [Validation(Required=false)]
                public string IpGroup { get; set; }

                [NameInMap("NatIp")]
                [Validation(Required=false)]
                public string NatIp { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("OperatingSystem")]
                [Validation(Required=false)]
                public string OperatingSystem { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("SerialNumber")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                [NameInMap("isAliyunHost")]
                [Validation(Required=false)]
                public bool? IsAliyunHost { get; set; }

            }

        }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The Request is not authorization.</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries returned per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>50</para>
        /// </summary>
        [NameInMap("PageTotal")]
        [Validation(Required=false)]
        public int? PageTotal { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>63EEBB2A-9E51-41E4-9E83-5DE7F3B292E0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the call is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The call is successful.</description></item>
        /// <item><description>false: The call fails.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned entries.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Total")]
        [Validation(Required=false)]
        public int? Total { get; set; }

    }

}
