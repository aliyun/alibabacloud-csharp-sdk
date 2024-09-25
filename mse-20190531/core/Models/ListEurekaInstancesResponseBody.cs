// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListEurekaInstancesResponseBody : TeaModel {
        /// <summary>
        /// <para>The details of the data.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListEurekaInstancesResponseBodyData> Data { get; set; }
        public class ListEurekaInstancesResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The name of the application.</para>
            /// 
            /// <b>Example:</b>
            /// <para>CONTACTINFO</para>
            /// </summary>
            [NameInMap("App")]
            [Validation(Required=false)]
            public string App { get; set; }

            /// <summary>
            /// <para>The timeout period of the instance.\
            /// After the specified timeout period expires, the service is unavailable by default and is deleted.</para>
            /// 
            /// <b>Example:</b>
            /// <para>90</para>
            /// </summary>
            [NameInMap("DurationInSecs")]
            [Validation(Required=false)]
            public int? DurationInSecs { get; set; }

            /// <summary>
            /// <para>The URL of the homepage.</para>
            /// 
            /// <b>Example:</b>
            /// <para><a href="http://30.5.XX.XX:8091/">http://30.5.XX.XX:8091/</a></para>
            /// </summary>
            [NameInMap("HomePageUrl")]
            [Validation(Required=false)]
            public string HomePageUrl { get; set; }

            /// <summary>
            /// <para>The hostname.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.5.XX.XX</para>
            /// </summary>
            [NameInMap("HostName")]
            [Validation(Required=false)]
            public string HostName { get; set; }

            /// <summary>
            /// <para>The ID of the instance.</para>
            /// 
            /// <b>Example:</b>
            /// <para>L-PC1A6A28-****.hz.ali.com:contactinfo:8091</para>
            /// </summary>
            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            /// <summary>
            /// <para>The IP address.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30.5.XX.XX</para>
            /// </summary>
            [NameInMap("IpAddr")]
            [Validation(Required=false)]
            public string IpAddr { get; set; }

            /// <summary>
            /// <para>The time when the instance was last modified.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201009115543</para>
            /// </summary>
            [NameInMap("LastDirtyTimestamp")]
            [Validation(Required=false)]
            public long? LastDirtyTimestamp { get; set; }

            /// <summary>
            /// <para>The time when the instance heartbeat was last checked.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20201010071203</para>
            /// </summary>
            [NameInMap("LastUpdatedTimestamp")]
            [Validation(Required=false)]
            public long? LastUpdatedTimestamp { get; set; }

            /// <summary>
            /// <para>The metadata.</para>
            /// 
            /// <b>Example:</b>
            /// <para>[string]</para>
            /// </summary>
            [NameInMap("Metadata")]
            [Validation(Required=false)]
            public Dictionary<string, object> Metadata { get; set; }

            /// <summary>
            /// <para>The service port number.</para>
            /// 
            /// <b>Example:</b>
            /// <para>8091</para>
            /// </summary>
            [NameInMap("Port")]
            [Validation(Required=false)]
            public int? Port { get; set; }

            /// <summary>
            /// <para>The maximum interval between two heartbeat checks after a heartbeat check times out.\
            /// Default value: 10.</para>
            /// 
            /// <b>Example:</b>
            /// <para>10</para>
            /// </summary>
            [NameInMap("RenewalIntervalInSecs")]
            [Validation(Required=false)]
            public int? RenewalIntervalInSecs { get; set; }

            /// <summary>
            /// <para>The security port.</para>
            /// 
            /// <b>Example:</b>
            /// <para>443</para>
            /// </summary>
            [NameInMap("SecurePort")]
            [Validation(Required=false)]
            public int? SecurePort { get; set; }

            /// <summary>
            /// <para>The number of service providers. The value is in the following format: Number of healthy instances/Total number of instances.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1/1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The virtual IP address (VIP).</para>
            /// 
            /// <b>Example:</b>
            /// <para>contactinfo</para>
            /// </summary>
            [NameInMap("VipAddress")]
            [Validation(Required=false)]
            public string VipAddress { get; set; }

        }

        /// <summary>
        /// <para>The error code returned if the request failed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mse-100-000</para>
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// <para>The HTTP status code returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>202</para>
        /// </summary>
        [NameInMap("HttpCode")]
        [Validation(Required=false)]
        public string HttpCode { get; set; }

        /// <summary>
        /// <para>The message returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The request is successfully processed.</para>
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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>316F5F64-F73D-42DC-8632-01E308B6****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>true</c>: The request was successful.</description></item>
        /// <item><description><c>false</c>: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of returned instances.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
