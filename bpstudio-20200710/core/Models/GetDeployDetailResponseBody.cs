// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BPStudio20200710.Models
{
    public class GetDeployDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetDeployDetailResponseBodyData> Data { get; set; }
        public class GetDeployDetailResponseBodyData : TeaModel {
            [NameInMap("AppId")]
            [Validation(Required=false)]
            public string AppId { get; set; }

            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public long? CreateTime { get; set; }

            [NameInMap("CurrentProcess")]
            [Validation(Required=false)]
            public string CurrentProcess { get; set; }

            [NameInMap("DeletingNodeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> DeletingNodeList { get; set; }

            [NameInMap("DeployPercent")]
            [Validation(Required=false)]
            public double? DeployPercent { get; set; }

            [NameInMap("DeployedNodeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> DeployedNodeList { get; set; }

            [NameInMap("DeployingNodeList")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> DeployingNodeList { get; set; }

            [NameInMap("Error")]
            [Validation(Required=false)]
            public string Error { get; set; }

            [NameInMap("ExecutionTime")]
            [Validation(Required=false)]
            public int? ExecutionTime { get; set; }

            [NameInMap("FailStatus")]
            [Validation(Required=false)]
            public int? FailStatus { get; set; }

            [NameInMap("OrderIdList")]
            [Validation(Required=false)]
            public List<string> OrderIdList { get; set; }

            [NameInMap("PdfUrl")]
            [Validation(Required=false)]
            public string PdfUrl { get; set; }

            [NameInMap("ResourceGroupId")]
            [Validation(Required=false)]
            public string ResourceGroupId { get; set; }

            [NameInMap("ResourceList")]
            [Validation(Required=false)]
            public List<GetDeployDetailResponseBodyDataResourceList> ResourceList { get; set; }
            public class GetDeployDetailResponseBodyDataResourceList : TeaModel {
                [NameInMap("BuyDuration")]
                [Validation(Required=false)]
                public string BuyDuration { get; set; }

                [NameInMap("ChargeType")]
                [Validation(Required=false)]
                public string ChargeType { get; set; }

                [NameInMap("ExecutionStrategy")]
                [Validation(Required=false)]
                public string ExecutionStrategy { get; set; }

                [NameInMap("ModifiedTime")]
                [Validation(Required=false)]
                public long? ModifiedTime { get; set; }

                [NameInMap("MonitorURL")]
                [Validation(Required=false)]
                public string MonitorURL { get; set; }

                [NameInMap("NodeName")]
                [Validation(Required=false)]
                public string NodeName { get; set; }

                [NameInMap("Operation")]
                [Validation(Required=false)]
                public GetDeployDetailResponseBodyDataResourceListOperation Operation { get; set; }
                public class GetDeployDetailResponseBodyDataResourceListOperation : TeaModel {
                    [NameInMap("Name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("Operations")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> Operations { get; set; }

                }

                [NameInMap("RefId")]
                [Validation(Required=false)]
                public long? RefId { get; set; }

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("ResourceCode")]
                [Validation(Required=false)]
                public string ResourceCode { get; set; }

                [NameInMap("ResourceId")]
                [Validation(Required=false)]
                public string ResourceId { get; set; }

                [NameInMap("ResourceTimeList")]
                [Validation(Required=false)]
                public List<GetDeployDetailResponseBodyDataResourceListResourceTimeList> ResourceTimeList { get; set; }
                public class GetDeployDetailResponseBodyDataResourceListResourceTimeList : TeaModel {
                    [NameInMap("BizId")]
                    [Validation(Required=false)]
                    public string BizId { get; set; }

                    [NameInMap("CreationEndTime")]
                    [Validation(Required=false)]
                    public long? CreationEndTime { get; set; }

                    [NameInMap("CreationStartTime")]
                    [Validation(Required=false)]
                    public long? CreationStartTime { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                }

                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("TerraformScriptUrl")]
            [Validation(Required=false)]
            public string TerraformScriptUrl { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public long? NextToken { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public long? TotalCount { get; set; }

    }

}
