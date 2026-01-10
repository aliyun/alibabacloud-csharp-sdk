// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDifyInstancesResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Root")]
        [Validation(Required=false)]
        public ListDifyInstancesResponseBodyRoot Root { get; set; }
        public class ListDifyInstancesResponseBodyRoot : TeaModel {
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<ListDifyInstancesResponseBodyRootData> Data { get; set; }
            public class ListDifyInstancesResponseBodyRootData : TeaModel {
                [NameInMap("AppUuid")]
                [Validation(Required=false)]
                public string AppUuid { get; set; }

                [NameInMap("CreatedTime")]
                [Validation(Required=false)]
                public string CreatedTime { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>实例描述</para>
                /// </summary>
                [NameInMap("Description")]
                [Validation(Required=false)]
                public string Description { get; set; }

                [NameInMap("Edition")]
                [Validation(Required=false)]
                public string Edition { get; set; }

                [NameInMap("EnterpriseInternetUrl")]
                [Validation(Required=false)]
                public string EnterpriseInternetUrl { get; set; }

                [NameInMap("EnterpriseIntranetUrl")]
                [Validation(Required=false)]
                public string EnterpriseIntranetUrl { get; set; }

                [NameInMap("InstanceId")]
                [Validation(Required=false)]
                public string InstanceId { get; set; }

                [NameInMap("InstanceName")]
                [Validation(Required=false)]
                public string InstanceName { get; set; }

                [NameInMap("InternetUrl")]
                [Validation(Required=false)]
                public string InternetUrl { get; set; }

                [NameInMap("IntranetUrl")]
                [Validation(Required=false)]
                public string IntranetUrl { get; set; }

                [NameInMap("MajorVersion")]
                [Validation(Required=false)]
                public string MajorVersion { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>地域信息</para>
                /// </summary>
                [NameInMap("RegionCode")]
                [Validation(Required=false)]
                public string RegionCode { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>running</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

                [NameInMap("WorkspaceId")]
                [Validation(Required=false)]
                public string WorkspaceId { get; set; }

                [NameInMap("ZoneId")]
                [Validation(Required=false)]
                public string ZoneId { get; set; }

            }

        }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
