// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class GetCardDetailResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetCardDetailResponseBodyData Data { get; set; }
        public class GetCardDetailResponseBodyData : TeaModel {
            [NameInMap("ListPsimCards")]
            [Validation(Required=false)]
            public List<GetCardDetailResponseBodyDataListPsimCards> ListPsimCards { get; set; }
            public class GetCardDetailResponseBodyDataListPsimCards : TeaModel {
                public string ApnName { get; set; }
                public string CertifyStatus { get; set; }
                public string Iccid { get; set; }
                public List<string> Imsi { get; set; }
                public List<string> Ip { get; set; }
                public List<string> Msisdn { get; set; }
                public bool? OpenSms { get; set; }
                public string OsStatus { get; set; }
                public string PeriodAddFlow { get; set; }
                public string PeriodSmsUse { get; set; }
                public string PrivateNetworkSegment { get; set; }
                public string Status { get; set; }
                public string Vendor { get; set; }
            }
            [NameInMap("VsimCardInfo")]
            [Validation(Required=false)]
            public GetCardDetailResponseBodyDataVsimCardInfo VsimCardInfo { get; set; }
            public class GetCardDetailResponseBodyDataVsimCardInfo : TeaModel {
                [NameInMap("ActiveTime")]
                [Validation(Required=false)]
                public string ActiveTime { get; set; }

                [NameInMap("ActiveType")]
                [Validation(Required=false)]
                public string ActiveType { get; set; }

                [NameInMap("AliFee")]
                [Validation(Required=false)]
                public string AliFee { get; set; }

                [NameInMap("AliyunOrderId")]
                [Validation(Required=false)]
                public string AliyunOrderId { get; set; }

                [NameInMap("ApnName")]
                [Validation(Required=false)]
                public string ApnName { get; set; }

                [NameInMap("AutoLimitResume")]
                [Validation(Required=false)]
                public bool? AutoLimitResume { get; set; }

                [NameInMap("AutoRebindReuse")]
                [Validation(Required=false)]
                public bool? AutoRebindReuse { get; set; }

                [NameInMap("CardLimitSpeedThreshold")]
                [Validation(Required=false)]
                public int? CardLimitSpeedThreshold { get; set; }

                [NameInMap("CardLimitStopThreshold")]
                [Validation(Required=false)]
                public int? CardLimitStopThreshold { get; set; }

                [NameInMap("CertifyStatus")]
                [Validation(Required=false)]
                public string CertifyStatus { get; set; }

                [NameInMap("CertifyType")]
                [Validation(Required=false)]
                public string CertifyType { get; set; }

                [NameInMap("CredentialInstanceId")]
                [Validation(Required=false)]
                public string CredentialInstanceId { get; set; }

                [NameInMap("CredentialLimitSpeedThreshold")]
                [Validation(Required=false)]
                public int? CredentialLimitSpeedThreshold { get; set; }

                [NameInMap("CredentialLimitStopThreshold")]
                [Validation(Required=false)]
                public int? CredentialLimitStopThreshold { get; set; }

                [NameInMap("CredentialNo")]
                [Validation(Required=false)]
                public string CredentialNo { get; set; }

                [NameInMap("CredentialType")]
                [Validation(Required=false)]
                public string CredentialType { get; set; }

                [NameInMap("DataLevel")]
                [Validation(Required=false)]
                public string DataLevel { get; set; }

                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("DeviceImei")]
                [Validation(Required=false)]
                public string DeviceImei { get; set; }

                [NameInMap("DirectionalGroupId")]
                [Validation(Required=false)]
                public string DirectionalGroupId { get; set; }

                [NameInMap("DirectionalGroupName")]
                [Validation(Required=false)]
                public string DirectionalGroupName { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("FlowThresholdUnit")]
                [Validation(Required=false)]
                public string FlowThresholdUnit { get; set; }

                [NameInMap("Iccid")]
                [Validation(Required=false)]
                public string Iccid { get; set; }

                [NameInMap("Imsi")]
                [Validation(Required=false)]
                public List<string> Imsi { get; set; }

                [NameInMap("Ip")]
                [Validation(Required=false)]
                public List<string> Ip { get; set; }

                [NameInMap("IsAutoRecharge")]
                [Validation(Required=false)]
                public bool? IsAutoRecharge { get; set; }

                [NameInMap("Msisdn")]
                [Validation(Required=false)]
                public List<string> Msisdn { get; set; }

                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public string NotifyId { get; set; }

                [NameInMap("OpenAccountTime")]
                [Validation(Required=false)]
                public string OpenAccountTime { get; set; }

                [NameInMap("OpenSms")]
                [Validation(Required=false)]
                public bool? OpenSms { get; set; }

                [NameInMap("OsStatus")]
                [Validation(Required=false)]
                public string OsStatus { get; set; }

                [NameInMap("Period")]
                [Validation(Required=false)]
                public string Period { get; set; }

                [NameInMap("PeriodAddFlow")]
                [Validation(Required=false)]
                public string PeriodAddFlow { get; set; }

                [NameInMap("PeriodRestFlow")]
                [Validation(Required=false)]
                public string PeriodRestFlow { get; set; }

                [NameInMap("PeriodSmsUse")]
                [Validation(Required=false)]
                public string PeriodSmsUse { get; set; }

                [NameInMap("PrivateNetworkSegment")]
                [Validation(Required=false)]
                public string PrivateNetworkSegment { get; set; }

                [NameInMap("SimType")]
                [Validation(Required=false)]
                public string SimType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<GetCardDetailResponseBodyDataVsimCardInfoTagList> TagList { get; set; }
                public class GetCardDetailResponseBodyDataVsimCardInfoTagList : TeaModel {
                    [NameInMap("Id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("TagName")]
                    [Validation(Required=false)]
                    public string TagName { get; set; }

                }

                [NameInMap("Vendor")]
                [Validation(Required=false)]
                public string Vendor { get; set; }

                [NameInMap("VsimInstanceId")]
                [Validation(Required=false)]
                public int? VsimInstanceId { get; set; }

            }
        };

        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        [NameInMap("LocalizedMessage")]
        [Validation(Required=false)]
        public string LocalizedMessage { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
