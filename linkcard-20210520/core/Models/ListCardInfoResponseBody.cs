// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class ListCardInfoResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListCardInfoResponseBodyData Data { get; set; }
        public class ListCardInfoResponseBodyData : TeaModel {
            [NameInMap("List")]
            [Validation(Required=false)]
            public List<ListCardInfoResponseBodyDataList> List { get; set; }
            public class ListCardInfoResponseBodyDataList : TeaModel {
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

                [NameInMap("CertifyType")]
                [Validation(Required=false)]
                public string CertifyType { get; set; }

                [NameInMap("CredentialInstanceId")]
                [Validation(Required=false)]
                public string CredentialInstanceId { get; set; }

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

                [NameInMap("DirectionalGroupId")]
                [Validation(Required=false)]
                public long? DirectionalGroupId { get; set; }

                [NameInMap("DirectionalGroupName")]
                [Validation(Required=false)]
                public string DirectionalGroupName { get; set; }

                [NameInMap("ExpireTime")]
                [Validation(Required=false)]
                public string ExpireTime { get; set; }

                [NameInMap("FlowLatestModifiedTime")]
                [Validation(Required=false)]
                public string FlowLatestModifiedTime { get; set; }

                [NameInMap("Iccid")]
                [Validation(Required=false)]
                public string Iccid { get; set; }

                [NameInMap("Imsi")]
                [Validation(Required=false)]
                public List<string> Imsi { get; set; }

                [NameInMap("IsAutoRecharge")]
                [Validation(Required=false)]
                public bool? IsAutoRecharge { get; set; }

                [NameInMap("Msisdn")]
                [Validation(Required=false)]
                public List<string> Msisdn { get; set; }

                [NameInMap("NetworkType")]
                [Validation(Required=false)]
                public string NetworkType { get; set; }

                [NameInMap("NotifyId")]
                [Validation(Required=false)]
                public string NotifyId { get; set; }

                [NameInMap("OpenAccountTime")]
                [Validation(Required=false)]
                public string OpenAccountTime { get; set; }

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

                [NameInMap("Remark")]
                [Validation(Required=false)]
                public string Remark { get; set; }

                [NameInMap("SimType")]
                [Validation(Required=false)]
                public string SimType { get; set; }

                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

                [NameInMap("TagList")]
                [Validation(Required=false)]
                public List<ListCardInfoResponseBodyDataListTagList> TagList { get; set; }
                public class ListCardInfoResponseBodyDataListTagList : TeaModel {
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
                public long? VsimInstanceId { get; set; }

            }

            [NameInMap("PageCount")]
            [Validation(Required=false)]
            public int? PageCount { get; set; }

            [NameInMap("PageNo")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            [NameInMap("Total")]
            [Validation(Required=false)]
            public int? Total { get; set; }

        }

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
