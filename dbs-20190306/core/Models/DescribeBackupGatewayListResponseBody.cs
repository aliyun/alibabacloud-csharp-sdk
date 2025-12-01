// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeBackupGatewayListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The details of backup gateways.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupGatewayListResponseBodyItems Items { get; set; }
        public class DescribeBackupGatewayListResponseBodyItems : TeaModel {
            [NameInMap("BackupGateway")]
            [Validation(Required=false)]
            public List<DescribeBackupGatewayListResponseBodyItemsBackupGateway> BackupGateway { get; set; }
            public class DescribeBackupGatewayListResponseBodyItemsBackupGateway : TeaModel {
                /// <summary>
                /// <para>The time when the backup gateway was created, such as 1554560477000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554560477000</para>
                /// </summary>
                [NameInMap("BackupGatewayCreateTime")]
                [Validation(Required=false)]
                public long? BackupGatewayCreateTime { get; set; }

                /// <summary>
                /// <para>The ID of the backup gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2321313123</para>
                /// </summary>
                [NameInMap("BackupGatewayId")]
                [Validation(Required=false)]
                public string BackupGatewayId { get; set; }

                /// <summary>
                /// <para>The status of the backup gateway. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>ONLINE: The backup gateway is online.</description></item>
                /// <item><description>OFFLINE: The backup gateway is offline.</description></item>
                /// <item><description>STOPPED: The backup gateway is stopped.</description></item>
                /// <item><description>UPGRADING: The backup gateway is being upgraded.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>ONLINE</para>
                /// </summary>
                [NameInMap("BackupGatewayStatus")]
                [Validation(Required=false)]
                public string BackupGatewayStatus { get; set; }

                /// <summary>
                /// <para>The display name of the backup gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                /// <summary>
                /// <para>The unique identifier of the backup gateway.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sgdsajhdgu</para>
                /// </summary>
                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                /// <summary>
                /// <para>The last time when a heartbeat message was sent, such as 1554560477000.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1554560477000</para>
                /// </summary>
                [NameInMap("LastHeartbeatTime")]
                [Validation(Required=false)]
                public long? LastHeartbeatTime { get; set; }

                /// <summary>
                /// <para>The ID of the region.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn-hangzhou</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The name of the host on which the backup gateway is installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>test</para>
                /// </summary>
                [NameInMap("SourceEndpointHostname")]
                [Validation(Required=false)]
                public string SourceEndpointHostname { get; set; }

                /// <summary>
                /// <para>The public IP address of the host on which the backup gateway is installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX.XX.XX.XX</para>
                /// </summary>
                [NameInMap("SourceEndpointInternetIP")]
                [Validation(Required=false)]
                public string SourceEndpointInternetIP { get; set; }

                /// <summary>
                /// <para>The private IP address of the host on which the backup gateway is installed.</para>
                /// 
                /// <b>Example:</b>
                /// <para>XX.XX.XX.XX</para>
                /// </summary>
                [NameInMap("SourceEndpointIntranetIP")]
                [Validation(Required=false)]
                public string SourceEndpointIntranetIP { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number of the returned page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of entries returned on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46361705-8531-492F-807E-A97E482DD4A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>The total number of backup gateways.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("TotalElements")]
        [Validation(Required=false)]
        public int? TotalElements { get; set; }

        /// <summary>
        /// <para>The total number of returned pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
