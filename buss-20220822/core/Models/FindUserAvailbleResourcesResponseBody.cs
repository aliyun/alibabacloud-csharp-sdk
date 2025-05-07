// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Buss20220822.Models
{
    public class FindUserAvailbleResourcesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Count")]
        [Validation(Required=false)]
        public long? Count { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public FindUserAvailbleResourcesResponseBodyData Data { get; set; }
        public class FindUserAvailbleResourcesResponseBodyData : TeaModel {
            [NameInMap("PegCoordinates")]
            [Validation(Required=false)]
            public List<FindUserAvailbleResourcesResponseBodyDataPegCoordinates> PegCoordinates { get; set; }
            public class FindUserAvailbleResourcesResponseBodyDataPegCoordinates : TeaModel {
                [NameInMap("BussinessCode")]
                [Validation(Required=false)]
                public string BussinessCode { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("Coordinate")]
                [Validation(Required=false)]
                public Dictionary<string, object> Coordinate { get; set; }

                [NameInMap("IdType")]
                [Validation(Required=false)]
                public string IdType { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                [NameInMap("ReleaseTime")]
                [Validation(Required=false)]
                public string ReleaseTime { get; set; }

                [NameInMap("ResCreateTime")]
                [Validation(Required=false)]
                public string ResCreateTime { get; set; }

                [NameInMap("ResourceStatus")]
                [Validation(Required=false)]
                public string ResourceStatus { get; set; }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("ServiceCreatedTime")]
                [Validation(Required=false)]
                public string ServiceCreatedTime { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

            }

            [NameInMap("UserInfo")]
            [Validation(Required=false)]
            public FindUserAvailbleResourcesResponseBodyDataUserInfo UserInfo { get; set; }
            public class FindUserAvailbleResourcesResponseBodyDataUserInfo : TeaModel {
                [NameInMap("GcLevel")]
                [Validation(Required=false)]
                public string GcLevel { get; set; }

                [NameInMap("HitWhiteReason")]
                [Validation(Required=false)]
                public string HitWhiteReason { get; set; }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("UserSite")]
                [Validation(Required=false)]
                public string UserSite { get; set; }

                [NameInMap("WhiteUser")]
                [Validation(Required=false)]
                public bool? WhiteUser { get; set; }

            }

        }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
