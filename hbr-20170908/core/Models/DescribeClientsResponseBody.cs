// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Hbr20170908.Models
{
    public class DescribeClientsResponseBody : TeaModel {
        [NameInMap("Clients")]
        [Validation(Required=false)]
        public DescribeClientsResponseBodyClients Clients { get; set; }
        public class DescribeClientsResponseBodyClients : TeaModel {
            [NameInMap("Client")]
            [Validation(Required=false)]
            public List<DescribeClientsResponseBodyClientsClient> Client { get; set; }
            public class DescribeClientsResponseBodyClientsClient : TeaModel {
                [NameInMap("AlertSetting")]
                [Validation(Required=false)]
                public string AlertSetting { get; set; }

                [NameInMap("ClientId")]
                [Validation(Required=false)]
                public string ClientId { get; set; }

                [NameInMap("ClientName")]
                [Validation(Required=false)]
                public string ClientName { get; set; }

                [NameInMap("ClientType")]
                [Validation(Required=false)]
                public string ClientType { get; set; }

                [NameInMap("ClientVersion")]
                [Validation(Required=false)]
                public string ClientVersion { get; set; }

                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public long? CreatedTime { get; set; }

                [NameInMap("HeartBeatTime")]
                [Validation(Required=false)]
                public long? HeartBeatTime { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("MaxVersion")]
                [Validation(Required=false)]
                public string MaxVersion { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("StatusMessage")]
                [Validation(Required=false)]
                public string StatusMessage { get; set; }

                [NameInMap("UpdatedTime")]
                [Validation(Required=false)]
                public long? UpdatedTime { get; set; }

                [NameInMap("UseHttps")]
                [Validation(Required=false)]
                public bool? UseHttps { get; set; }

                [NameInMap("VaultId")]
                [Validation(Required=false)]
                public string VaultId { get; set; }

            }

        }

        /// <summary>
        /// <para>The response code. The status code 200 indicates that the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The returned message. If the request was successful, &quot;successful&quot; is returned. If the request failed, an error message is returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The page number. Pages start from page 1. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 99. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>17189276-465D-5EF3-8FFD-0FF51B5A41A0</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
