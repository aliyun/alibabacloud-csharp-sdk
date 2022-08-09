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
                public string ActiveTime { get; set; }
                public string ActiveType { get; set; }
                public string AliFee { get; set; }
                public string AliyunOrderId { get; set; }
                public string ApnName { get; set; }
                public string CertifyType { get; set; }
                public string CredentialInstanceId { get; set; }
                public string CredentialNo { get; set; }
                public string CredentialType { get; set; }
                public string DataLevel { get; set; }
                public string DataType { get; set; }
                public long? DirectionalGroupId { get; set; }
                public string DirectionalGroupName { get; set; }
                public string ExpireTime { get; set; }
                public string Iccid { get; set; }
                public List<string> Imsi { get; set; }
                public bool? IsAutoRecharge { get; set; }
                public List<string> Msisdn { get; set; }
                public string NotifyId { get; set; }
                public string OpenAccountTime { get; set; }
                public string OsStatus { get; set; }
                public string Period { get; set; }
                public string PeriodAddFlow { get; set; }
                public string PeriodRestFlow { get; set; }
                public string PeriodSmsUse { get; set; }
                public string PrivateNetworkSegment { get; set; }
                public string Remark { get; set; }
                public string SimType { get; set; }
                public string Status { get; set; }
                public List<ListCardInfoResponseBodyDataListTagList> TagList { get; set; }
                public class ListCardInfoResponseBodyDataListTagList : TeaModel {
                    public long? Id { get; set; }
                    public string TagName { get; set; }
                }
                public string Vendor { get; set; }
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
