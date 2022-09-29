// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Linkcard20210520.Models
{
    public class ListCardInfoRequest : TeaModel {
        [NameInMap("ActiveTimeEnd")]
        [Validation(Required=false)]
        public string ActiveTimeEnd { get; set; }

        [NameInMap("ActiveTimeStart")]
        [Validation(Required=false)]
        public string ActiveTimeStart { get; set; }

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

        [NameInMap("CredentialNo")]
        [Validation(Required=false)]
        public string CredentialNo { get; set; }

        [NameInMap("DataLevel")]
        [Validation(Required=false)]
        public string DataLevel { get; set; }

        [NameInMap("DataType")]
        [Validation(Required=false)]
        public string DataType { get; set; }

        [NameInMap("DirectionalGroupId")]
        [Validation(Required=false)]
        public string DirectionalGroupId { get; set; }

        [NameInMap("ExpireTimeEnd")]
        [Validation(Required=false)]
        public string ExpireTimeEnd { get; set; }

        [NameInMap("ExpireTimeStart")]
        [Validation(Required=false)]
        public string ExpireTimeStart { get; set; }

        [NameInMap("Iccid")]
        [Validation(Required=false)]
        public string Iccid { get; set; }

        [NameInMap("Imsi")]
        [Validation(Required=false)]
        public string Imsi { get; set; }

        [NameInMap("IsAutoRecharge")]
        [Validation(Required=false)]
        public bool? IsAutoRecharge { get; set; }

        [NameInMap("MaxFlow")]
        [Validation(Required=false)]
        public string MaxFlow { get; set; }

        [NameInMap("MaxRestFlowPercentage")]
        [Validation(Required=false)]
        public double? MaxRestFlowPercentage { get; set; }

        [NameInMap("MinFlow")]
        [Validation(Required=false)]
        public string MinFlow { get; set; }

        [NameInMap("Msisdn")]
        [Validation(Required=false)]
        public string Msisdn { get; set; }

        [NameInMap("NotifyId")]
        [Validation(Required=false)]
        public string NotifyId { get; set; }

        [NameInMap("OsStatus")]
        [Validation(Required=false)]
        public string OsStatus { get; set; }

        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("Period")]
        [Validation(Required=false)]
        public string Period { get; set; }

        [NameInMap("PoolId")]
        [Validation(Required=false)]
        public string PoolId { get; set; }

        [NameInMap("SimType")]
        [Validation(Required=false)]
        public string SimType { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        [NameInMap("TagName")]
        [Validation(Required=false)]
        public string TagName { get; set; }

        [NameInMap("Vendor")]
        [Validation(Required=false)]
        public string Vendor { get; set; }

    }

}
