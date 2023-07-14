// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyData Data { get; set; }
        public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyData : TeaModel {
            [NameInMap("PrometheusInstances")]
            [Validation(Required=false)]
            public List<ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstances> PrometheusInstances { get; set; }
            public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstances : TeaModel {
                [NameInMap("ClusterId")]
                [Validation(Required=false)]
                public string ClusterId { get; set; }

                [NameInMap("ClusterName")]
                [Validation(Required=false)]
                public string ClusterName { get; set; }

                [NameInMap("ClusterType")]
                [Validation(Required=false)]
                public string ClusterType { get; set; }

                [NameInMap("GrafanaInstanceId")]
                [Validation(Required=false)]
                public string GrafanaInstanceId { get; set; }

                [NameInMap("PaymentType")]
                [Validation(Required=false)]
                public string PaymentType { get; set; }

                [NameInMap("RegionId")]
                [Validation(Required=false)]
                public string RegionId { get; set; }

                [NameInMap("ResourceGroupId")]
                [Validation(Required=false)]
                public string ResourceGroupId { get; set; }

                /// <summary>
                /// 资源类型
                /// </summary>
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("SecurityGroupId")]
                [Validation(Required=false)]
                public string SecurityGroupId { get; set; }

                [NameInMap("SubClustersJson")]
                [Validation(Required=false)]
                public string SubClustersJson { get; set; }

                [NameInMap("Tags")]
                [Validation(Required=false)]
                public List<ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstancesTags> Tags { get; set; }
                public class ListPrometheusInstanceByTagAndResourceGroupIdResponseBodyDataPrometheusInstancesTags : TeaModel {
                    [NameInMap("TagKey")]
                    [Validation(Required=false)]
                    public string TagKey { get; set; }

                    [NameInMap("TagValue")]
                    [Validation(Required=false)]
                    public string TagValue { get; set; }

                }

                [NameInMap("UserId")]
                [Validation(Required=false)]
                public string UserId { get; set; }

                [NameInMap("VSwitchId")]
                [Validation(Required=false)]
                public string VSwitchId { get; set; }

                [NameInMap("VpcId")]
                [Validation(Required=false)]
                public string VpcId { get; set; }

            }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
