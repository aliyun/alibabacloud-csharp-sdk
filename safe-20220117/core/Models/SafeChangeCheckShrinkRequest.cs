// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safe20220117.Models
{
    public class SafeChangeCheckShrinkRequest : TeaModel {
        [NameInMap("AffectCustomer")]
        [Validation(Required=false)]
        public string AffectCustomer { get; set; }

        [NameInMap("ApproveFlowParam")]
        [Validation(Required=false)]
        public SafeChangeCheckShrinkRequestApproveFlowParam ApproveFlowParam { get; set; }
        public class SafeChangeCheckShrinkRequestApproveFlowParam : TeaModel {
            [NameInMap("ApproveNodes")]
            [Validation(Required=false)]
            public List<SafeChangeCheckShrinkRequestApproveFlowParamApproveNodes> ApproveNodes { get; set; }
            public class SafeChangeCheckShrinkRequestApproveFlowParamApproveNodes : TeaModel {
                [NameInMap("ApproverDTO")]
                [Validation(Required=false)]
                public List<SafeChangeCheckShrinkRequestApproveFlowParamApproveNodesApproverDTO> ApproverDTO { get; set; }
                public class SafeChangeCheckShrinkRequestApproveFlowParamApproveNodesApproverDTO : TeaModel {
                    [NameInMap("ApproveDesc")]
                    [Validation(Required=false)]
                    public string ApproveDesc { get; set; }

                    [NameInMap("ApproveTime")]
                    [Validation(Required=false)]
                    public long? ApproveTime { get; set; }

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

            [NameInMap("FlowStatus")]
            [Validation(Required=false)]
            public int? FlowStatus { get; set; }

        }

        [NameInMap("AuthKey")]
        [Validation(Required=false)]
        public string AuthKey { get; set; }

        [NameInMap("AuthSign")]
        [Validation(Required=false)]
        public string AuthSign { get; set; }

        [NameInMap("BgCustomTemplateExtraDTO")]
        [Validation(Required=false)]
        public SafeChangeCheckShrinkRequestBgCustomTemplateExtraDTO BgCustomTemplateExtraDTO { get; set; }
        public class SafeChangeCheckShrinkRequestBgCustomTemplateExtraDTO : TeaModel {
            [NameInMap("BgCustomTemplateInfo")]
            [Validation(Required=false)]
            public string BgCustomTemplateInfo { get; set; }

        }

        [NameInMap("BlockInfos")]
        [Validation(Required=false)]
        public List<SafeChangeCheckShrinkRequestBlockInfos> BlockInfos { get; set; }
        public class SafeChangeCheckShrinkRequestBlockInfos : TeaModel {
            [NameInMap("HitInfos")]
            [Validation(Required=false)]
            public List<SafeChangeCheckShrinkRequestBlockInfosHitInfos> HitInfos { get; set; }
            public class SafeChangeCheckShrinkRequestBlockInfosHitInfos : TeaModel {
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
        public SafeChangeCheckShrinkRequestCallBackInfo CallBackInfo { get; set; }
        public class SafeChangeCheckShrinkRequestCallBackInfo : TeaModel {
            [NameInMap("Api")]
            [Validation(Required=false)]
            public string Api { get; set; }

            [NameInMap("ApiVersion")]
            [Validation(Required=false)]
            public string ApiVersion { get; set; }

            [NameInMap("EndPoint")]
            [Validation(Required=false)]
            public string EndPoint { get; set; }

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
        public List<SafeChangeCheckShrinkRequestChangeTimes> ChangeTimes { get; set; }
        public class SafeChangeCheckShrinkRequestChangeTimes : TeaModel {
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

        [NameInMap("Checker")]
        [Validation(Required=false)]
        public List<string> Checker { get; set; }

        [NameInMap("CreatorEmpId")]
        [Validation(Required=false)]
        public string CreatorEmpId { get; set; }

        [NameInMap("DamagedChangeNotices")]
        [Validation(Required=false)]
        public List<SafeChangeCheckShrinkRequestDamagedChangeNotices> DamagedChangeNotices { get; set; }
        public class SafeChangeCheckShrinkRequestDamagedChangeNotices : TeaModel {
            [NameInMap("BgCancelNoticeContent")]
            [Validation(Required=false)]
            public string BgCancelNoticeContent { get; set; }

            [NameInMap("BgCancelNoticeEventId")]
            [Validation(Required=false)]
            public string BgCancelNoticeEventId { get; set; }

            [NameInMap("Channel")]
            [Validation(Required=false)]
            public List<string> Channel { get; set; }

            [NameInMap("Content")]
            [Validation(Required=false)]
            public string Content { get; set; }

            [NameInMap("EventId")]
            [Validation(Required=false)]
            public string EventId { get; set; }

            [NameInMap("SensitiveCustomers")]
            [Validation(Required=false)]
            public List<SafeChangeCheckShrinkRequestDamagedChangeNoticesSensitiveCustomers> SensitiveCustomers { get; set; }
            public class SafeChangeCheckShrinkRequestDamagedChangeNoticesSensitiveCustomers : TeaModel {
                [NameInMap("CustomerInfo")]
                [Validation(Required=false)]
                public List<SafeChangeCheckShrinkRequestDamagedChangeNoticesSensitiveCustomersCustomerInfo> CustomerInfo { get; set; }
                public class SafeChangeCheckShrinkRequestDamagedChangeNoticesSensitiveCustomersCustomerInfo : TeaModel {
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

            [NameInMap("Type")]
            [Validation(Required=false)]
            public string Type { get; set; }

        }

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

        [NameInMap("HarmNoticeCombineParam")]
        [Validation(Required=false)]
        public string HarmNoticeCombineParamShrink { get; set; }

        [NameInMap("Incidence")]
        [Validation(Required=false)]
        public string Incidence { get; set; }

        [NameInMap("InfluenceInfo")]
        [Validation(Required=false)]
        public SafeChangeCheckShrinkRequestInfluenceInfo InfluenceInfo { get; set; }
        public class SafeChangeCheckShrinkRequestInfluenceInfo : TeaModel {
            [NameInMap("NoticeInfos")]
            [Validation(Required=false)]
            public List<SafeChangeCheckShrinkRequestInfluenceInfoNoticeInfos> NoticeInfos { get; set; }
            public class SafeChangeCheckShrinkRequestInfluenceInfoNoticeInfos : TeaModel {
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
            public List<SafeChangeCheckShrinkRequestInfluenceInfoSensitiveCustomers> SensitiveCustomers { get; set; }
            public class SafeChangeCheckShrinkRequestInfluenceInfoSensitiveCustomers : TeaModel {
                [NameInMap("CustomerInfo")]
                [Validation(Required=false)]
                public List<SafeChangeCheckShrinkRequestInfluenceInfoSensitiveCustomersCustomerInfo> CustomerInfo { get; set; }
                public class SafeChangeCheckShrinkRequestInfluenceInfoSensitiveCustomersCustomerInfo : TeaModel {
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
        public SafeChangeCheckShrinkRequestInstance Instance { get; set; }
        public class SafeChangeCheckShrinkRequestInstance : TeaModel {
            [NameInMap("Nc")]
            [Validation(Required=false)]
            public List<string> Nc { get; set; }

            [NameInMap("Uids")]
            [Validation(Required=false)]
            public List<string> Uids { get; set; }

            [NameInMap("attributionApp")]
            [Validation(Required=false)]
            public List<string> AttributionApp { get; set; }

            [NameInMap("influenceApp")]
            [Validation(Required=false)]
            public List<string> InfluenceApp { get; set; }

            [NameInMap("instance")]
            [Validation(Required=false)]
            public List<string> Instance { get; set; }

        }

        [NameInMap("NeedModifyDoc")]
        [Validation(Required=false)]
        public string NeedModifyDoc { get; set; }

        [NameInMap("OperateEmpNo")]
        [Validation(Required=false)]
        public string OperateEmpNo { get; set; }

        [NameInMap("Product")]
        [Validation(Required=false)]
        public List<SafeChangeCheckShrinkRequestProduct> Product { get; set; }
        public class SafeChangeCheckShrinkRequestProduct : TeaModel {
            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

        }

        [NameInMap("ReleasePackageInfos")]
        [Validation(Required=false)]
        public List<SafeChangeCheckShrinkRequestReleasePackageInfos> ReleasePackageInfos { get; set; }
        public class SafeChangeCheckShrinkRequestReleasePackageInfos : TeaModel {
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

        [NameInMap("whiteType")]
        [Validation(Required=false)]
        public int? WhiteType { get; set; }

    }

}
