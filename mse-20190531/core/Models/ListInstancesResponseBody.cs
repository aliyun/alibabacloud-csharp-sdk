// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class ListInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<ListInstancesResponseBodyData> Data { get; set; }
        public class ListInstancesResponseBodyData : TeaModel {
            [NameInMap("AppClusterId")]
            [Validation(Required=false)]
            public string AppClusterId { get; set; }

            [NameInMap("AppVersion")]
            [Validation(Required=false)]
            public string AppVersion { get; set; }

            [NameInMap("DbPassword")]
            [Validation(Required=false)]
            public string DbPassword { get; set; }

            [NameInMap("DbUrl")]
            [Validation(Required=false)]
            public string DbUrl { get; set; }

            [NameInMap("DbUserName")]
            [Validation(Required=false)]
            public string DbUserName { get; set; }

            [NameInMap("EndDate")]
            [Validation(Required=false)]
            public long? EndDate { get; set; }

            [NameInMap("EnvironmentId")]
            [Validation(Required=false)]
            public long? EnvironmentId { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("ImageVersion")]
            [Validation(Required=false)]
            public string ImageVersion { get; set; }

            [NameInMap("InstanceId")]
            [Validation(Required=false)]
            public string InstanceId { get; set; }

            [NameInMap("IsCreatedRedis")]
            [Validation(Required=false)]
            public bool? IsCreatedRedis { get; set; }

            [NameInMap("K8sResourceId")]
            [Validation(Required=false)]
            public long? K8sResourceId { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("NameServer")]
            [Validation(Required=false)]
            public string NameServer { get; set; }

            [NameInMap("OrderId")]
            [Validation(Required=false)]
            public string OrderId { get; set; }

            [NameInMap("PodCidr")]
            [Validation(Required=false)]
            public string PodCidr { get; set; }

            [NameInMap("PrimaryUser")]
            [Validation(Required=false)]
            public string PrimaryUser { get; set; }

            [NameInMap("Region")]
            [Validation(Required=false)]
            public string Region { get; set; }

            [NameInMap("Replica")]
            [Validation(Required=false)]
            public long? Replica { get; set; }

            [NameInMap("SeataServerUniqueId")]
            [Validation(Required=false)]
            public string SeataServerUniqueId { get; set; }

            [NameInMap("SecurityGroup")]
            [Validation(Required=false)]
            public string SecurityGroup { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("StartDate")]
            [Validation(Required=false)]
            public string StartDate { get; set; }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public long? Status { get; set; }

            [NameInMap("StatusDesc")]
            [Validation(Required=false)]
            public string StatusDesc { get; set; }

            [NameInMap("StoreMode")]
            [Validation(Required=false)]
            public string StoreMode { get; set; }

            [NameInMap("Vpc")]
            [Validation(Required=false)]
            public string Vpc { get; set; }

            [NameInMap("Vswitch")]
            [Validation(Required=false)]
            public string Vswitch { get; set; }

            [NameInMap("ZoneId")]
            [Validation(Required=false)]
            public string ZoneId { get; set; }

        }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// Id of the request
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
