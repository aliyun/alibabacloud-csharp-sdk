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

        [NameInMap("Items")]
        [Validation(Required=false)]
        public DescribeBackupGatewayListResponseBodyItems Items { get; set; }
        public class DescribeBackupGatewayListResponseBodyItems : TeaModel {
            [NameInMap("BackupGateway")]
            [Validation(Required=false)]
            public List<DescribeBackupGatewayListResponseBodyItemsBackupGateway> BackupGateway { get; set; }
            public class DescribeBackupGatewayListResponseBodyItemsBackupGateway : TeaModel {
                [NameInMap("BackupGatewayCreateTime")]
                [Validation(Required=false)]
                public long? BackupGatewayCreateTime { get; set; }

                [NameInMap("BackupGatewayId")]
                [Validation(Required=false)]
                public string BackupGatewayId { get; set; }

                [NameInMap("BackupGatewayStatus")]
                [Validation(Required=false)]
                public string BackupGatewayStatus { get; set; }

                [NameInMap("DisplayName")]
                [Validation(Required=false)]
                public string DisplayName { get; set; }

                [NameInMap("Identifier")]
                [Validation(Required=false)]
                public string Identifier { get; set; }

                [NameInMap("LastHeartbeatTime")]
                [Validation(Required=false)]
                public long? LastHeartbeatTime { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("SourceEndpointHostname")]
                [Validation(Required=false)]
                public string SourceEndpointHostname { get; set; }

                [NameInMap("SourceEndpointInternetIP")]
                [Validation(Required=false)]
                public string SourceEndpointInternetIP { get; set; }

                [NameInMap("SourceEndpointIntranetIP")]
                [Validation(Required=false)]
                public string SourceEndpointIntranetIP { get; set; }

            }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        /// <summary>
        /// <para>The number of records on each page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46361705-8531-492F-807E-A97E482DD4A1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
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
        /// <para>The total number of pages.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("TotalPages")]
        [Validation(Required=false)]
        public int? TotalPages { get; set; }

    }

}
