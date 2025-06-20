// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class ChangeCheckShrinkRequest : TeaModel {
        [NameInMap("AffectCustomer")]
        [Validation(Required=false)]
        public string AffectCustomer { get; set; }

        [NameInMap("ApproveFlowParam")]
        [Validation(Required=false)]
        public ChangeCheckShrinkRequestApproveFlowParam ApproveFlowParam { get; set; }
        public class ChangeCheckShrinkRequestApproveFlowParam : TeaModel {
            [NameInMap("ApproveNodes")]
            [Validation(Required=false)]
            public List<ChangeCheckShrinkRequestApproveFlowParamApproveNodes> ApproveNodes { get; set; }
            public class ChangeCheckShrinkRequestApproveFlowParamApproveNodes : TeaModel {
                [NameInMap("ApproverDTO")]
                [Validation(Required=false)]
                public List<ChangeCheckShrinkRequestApproveFlowParamApproveNodesApproverDTO> ApproverDTO { get; set; }
                public class ChangeCheckShrinkRequestApproveFlowParamApproveNodesApproverDTO : TeaModel {
                    [NameInMap("ApproveDesc")]
                    [Validation(Required=false)]
                    public string ApproveDesc { get; set; }

                    [NameInMap("ApproveTime")]
                    [Validation(Required=false)]
                    public string ApproveTime { get; set; }

                    [NameInMap("ApproverId")]
                    [Validation(Required=false)]
                    public string ApproverId { get; set; }

                    [NameInMap("ApproverName")]
                    [Validation(Required=false)]
                    public string ApproverName { get; set; }

                    [NameInMap("Opinion")]
                    [Validation(Required=false)]
                    public int? Opinion { get; set; }

                }

                [NameInMap("NodeStatus")]
                [Validation(Required=false)]
                public int? NodeStatus { get; set; }

                [NameInMap("ProcessName")]
                [Validation(Required=false)]
                public string ProcessName { get; set; }

                [NameInMap("ProcessNodeOrder")]
                [Validation(Required=false)]
                public int? ProcessNodeOrder { get; set; }

                [NameInMap("Strategy")]
                [Validation(Required=false)]
                public int? Strategy { get; set; }

            }

            [NameInMap("AuthKey")]
            [Validation(Required=false)]
            public string AuthKey { get; set; }

            [NameInMap("AuthSign")]
            [Validation(Required=false)]
            public string AuthSign { get; set; }

            [NameInMap("BgVid")]
            [Validation(Required=false)]
            public string BgVid { get; set; }

            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public int? FlowStatus { get; set; }

            [NameInMap("Timestamp")]
            [Validation(Required=false)]
            public long? Timestamp { get; set; }

        }

        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("BgCustomTemplateExtraDTO")]
        [Validation(Required=false)]
        public ChangeCheckShrinkRequestBgCustomTemplateExtraDTO BgCustomTemplateExtraDTO { get; set; }
        public class ChangeCheckShrinkRequestBgCustomTemplateExtraDTO : TeaModel {
            [NameInMap("BgCustomTemplate")]
            [Validation(Required=false)]
            public string BgCustomTemplate { get; set; }

            [NameInMap("BgCustomTemplateId")]
            [Validation(Required=false)]
            public long? BgCustomTemplateId { get; set; }

            [NameInMap("BgCustomTemplateInfo")]
            [Validation(Required=false)]
            public string BgCustomTemplateInfo { get; set; }

            [NameInMap("BgCustomTemplateTitle")]
            [Validation(Required=false)]
            public string BgCustomTemplateTitle { get; set; }

            [NameInMap("BgVid")]
            [Validation(Required=false)]
            public string BgVid { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

        }

        [NameInMap("BgVid")]
        [Validation(Required=false)]
        public string BgVid { get; set; }

        [NameInMap("BlockInfos")]
        [Validation(Required=false)]
        public List<ChangeCheckShrinkRequestBlockInfos> BlockInfos { get; set; }
        public class ChangeCheckShrinkRequestBlockInfos : TeaModel {
            [NameInMap("HitInfos")]
            [Validation(Required=false)]
            public List<ChangeCheckShrinkRequestBlockInfosHitInfos> HitInfos { get; set; }
            public class ChangeCheckShrinkRequestBlockInfosHitInfos : TeaModel {
                [NameInMap("HitInfo")]
                [Validation(Required=false)]
                public string HitInfo { get; set; }

                [NameInMap("HitObject")]
                [Validation(Required=false)]
                public string HitObject { get; set; }

                [NameInMap("Scope")]
                [Validation(Required=false)]
                public string Scope { get; set; }

            }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

        }

        [NameInMap("CallBackInfo")]
        [Validation(Required=false)]
        public ChangeCheckShrinkRequestCallBackInfo CallBackInfo { get; set; }
        public class ChangeCheckShrinkRequestCallBackInfo : TeaModel {
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("ApiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

            [NameInMap("ExtraInfo")]
            [Validation(Required=false)]
            public string ExtraInfo { get; set; }

            [NameInMap("PopProduct")]
            [Validation(Required=false)]
            public string PopProduct { get; set; }

            [NameInMap("RegionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("Url")]
            [Validation(Required=false)]
            public string Url { get; set; }

        }

        [NameInMap("ChangeDataType")]
        [Validation(Required=false)]
        public string ChangeDataType { get; set; }

        [NameInMap("ChangeDesc")]
        [Validation(Required=false)]
        public string ChangeDesc { get; set; }

        [NameInMap("ChangeEndTime")]
        [Validation(Required=false)]
        public long? ChangeEndTime { get; set; }

        [NameInMap("ChangeEnv")]
        [Validation(Required=false)]
        public string ChangeEnv { get; set; }

        [NameInMap("ChangeItems")]
        [Validation(Required=false)]
        public string ChangeItems { get; set; }

        [NameInMap("ChangeObject")]
        [Validation(Required=false)]
        public string ChangeObject { get; set; }

        [NameInMap("ChangeOptSubType")]
        [Validation(Required=false)]
        public string ChangeOptSubType { get; set; }

        [NameInMap("ChangeOptType")]
        [Validation(Required=false)]
        public string ChangeOptType { get; set; }

        [NameInMap("ChangeReason")]
        [Validation(Required=false)]
        public string ChangeReason { get; set; }

        [NameInMap("ChangeRmarks")]
        [Validation(Required=false)]
        public string ChangeRmarks { get; set; }

        [NameInMap("ChangeSchemes")]
        [Validation(Required=false)]
        public string ChangeSchemes { get; set; }

        [NameInMap("ChangeStartTime")]
        [Validation(Required=false)]
        public long? ChangeStartTime { get; set; }

        [NameInMap("ChangeSubTypeDesc")]
        [Validation(Required=false)]
        public string ChangeSubTypeDesc { get; set; }

        [NameInMap("ChangeSystem")]
        [Validation(Required=false)]
        public string ChangeSystem { get; set; }

        [NameInMap("ChangeTimes")]
        [Validation(Required=false)]
        public List<ChangeCheckShrinkRequestChangeTimes> ChangeTimes { get; set; }
        public class ChangeCheckShrinkRequestChangeTimes : TeaModel {
            [NameInMap("ChangeEndTime")]
            [Validation(Required=false)]
            public long? ChangeEndTime { get; set; }

            [NameInMap("ChangeStartTime")]
            [Validation(Required=false)]
            public long? ChangeStartTime { get; set; }

        }

        [NameInMap("ChangeTitle")]
        [Validation(Required=false)]
        public string ChangeTitle { get; set; }

        [NameInMap("ChangeValidation")]
        [Validation(Required=false)]
        public string ChangeValidation { get; set; }

        [NameInMap("CreatorEmpId")]
        [Validation(Required=false)]
        public string CreatorEmpId { get; set; }

        [NameInMap("DamagedChangeNotices")]
        [Validation(Required=false)]
        public string DamagedChangeNoticesShrink { get; set; }

        [NameInMap("ExecutorEmpId")]
        [Validation(Required=false)]
        public string ExecutorEmpId { get; set; }

        [NameInMap("ExtraInfo")]
        [Validation(Required=false)]
        public string ExtraInfo { get; set; }

        [NameInMap("Follower")]
        [Validation(Required=false)]
        public List<string> Follower { get; set; }

        [NameInMap("GrayStatus")]
        [Validation(Required=false)]
        public string GrayStatus { get; set; }

        [NameInMap("HarmChangeNoticeEnum")]
        [Validation(Required=false)]
        public string HarmChangeNoticeEnum { get; set; }

        [NameInMap("Incidence")]
        [Validation(Required=false)]
        public string Incidence { get; set; }

        [NameInMap("InfluenceInfo")]
        [Validation(Required=false)]
        public ChangeCheckShrinkRequestInfluenceInfo InfluenceInfo { get; set; }
        public class ChangeCheckShrinkRequestInfluenceInfo : TeaModel {
            [NameInMap("NoticeInfos")]
            [Validation(Required=false)]
            public List<ChangeCheckShrinkRequestInfluenceInfoNoticeInfos> NoticeInfos { get; set; }
            public class ChangeCheckShrinkRequestInfluenceInfoNoticeInfos : TeaModel {
                [NameInMap("Channel")]
                [Validation(Required=false)]
                public List<string> Channel { get; set; }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public string Content { get; set; }

                [NameInMap("EventId")]
                [Validation(Required=false)]
                public string EventId { get; set; }

            }

            [NameInMap("SensitiveCustomers")]
            [Validation(Required=false)]
            public List<ChangeCheckShrinkRequestInfluenceInfoSensitiveCustomers> SensitiveCustomers { get; set; }
            public class ChangeCheckShrinkRequestInfluenceInfoSensitiveCustomers : TeaModel {
                [NameInMap("CustomerInfo")]
                [Validation(Required=false)]
                public List<ChangeCheckShrinkRequestInfluenceInfoSensitiveCustomersCustomerInfo> CustomerInfo { get; set; }
                public class ChangeCheckShrinkRequestInfluenceInfoSensitiveCustomersCustomerInfo : TeaModel {
                    [NameInMap("ExtraInfo")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtraInfo { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("Uid")]
                    [Validation(Required=false)]
                    public string Uid { get; set; }

                }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

            }

        }

        [NameInMap("Instance")]
        [Validation(Required=false)]
        public ChangeCheckShrinkRequestInstance Instance { get; set; }
        public class ChangeCheckShrinkRequestInstance : TeaModel {
            [NameInMap("AttributionApp")]
            [Validation(Required=false)]
            public List<string> AttributionApp { get; set; }

            [NameInMap("InfluenceApp")]
            [Validation(Required=false)]
            public List<string> InfluenceApp { get; set; }

            [NameInMap("Instance")]
            [Validation(Required=false)]
            public List<string> Instance { get; set; }

            [NameInMap("Nc")]
            [Validation(Required=false)]
            public List<string> Nc { get; set; }

            [NameInMap("Uids")]
            [Validation(Required=false)]
            public List<string> Uids { get; set; }

        }

        [NameInMap("NeedModifyDoc")]
        [Validation(Required=false)]
        public string NeedModifyDoc { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public List<ChangeCheckShrinkRequestProduct> Product { get; set; }
        public class ChangeCheckShrinkRequestProduct : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("ReleasePackageInfos")]
        [Validation(Required=false)]
        public List<ChangeCheckShrinkRequestReleasePackageInfos> ReleasePackageInfos { get; set; }
        public class ChangeCheckShrinkRequestReleasePackageInfos : TeaModel {
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }

            [NameInMap("ReleasePackage")]
            [Validation(Required=false)]
            public List<string> ReleasePackage { get; set; }

        }

        [NameInMap("ReqTimestamp")]
        [Validation(Required=false)]
        public long? ReqTimestamp { get; set; }

        [NameInMap("ReuseSourceOrderId")]
        [Validation(Required=false)]
        public string ReuseSourceOrderId { get; set; }

        [NameInMap("RiskLevel")]
        [Validation(Required=false)]
        public string RiskLevel { get; set; }

        [NameInMap("Rollback")]
        [Validation(Required=false)]
        public string Rollback { get; set; }

        [NameInMap("SourceName")]
        [Validation(Required=false)]
        public string SourceName { get; set; }

        [NameInMap("SourceOrderId")]
        [Validation(Required=false)]
        public string SourceOrderId { get; set; }

        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        [NameInMap("WhiteType")]
        [Validation(Required=false)]
        public int? WhiteType { get; set; }

    }

}
