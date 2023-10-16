// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class GetNotaryOrderResponseBody : TeaModel {
        [NameInMap("AliyunOrderId")]
        [Validation(Required=false)]
        public string AliyunOrderId { get; set; }

        [NameInMap("ApplyPostStatus")]
        [Validation(Required=false)]
        public int? ApplyPostStatus { get; set; }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BusinessLicense")]
        [Validation(Required=false)]
        public string BusinessLicense { get; set; }

        [NameInMap("BusinessLicenseId")]
        [Validation(Required=false)]
        public string BusinessLicenseId { get; set; }

        [NameInMap("CompanyContactName")]
        [Validation(Required=false)]
        public string CompanyContactName { get; set; }

        [NameInMap("CompanyContactPhone")]
        [Validation(Required=false)]
        public string CompanyContactPhone { get; set; }

        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        [NameInMap("ErrorMsg")]
        [Validation(Required=false)]
        public string ErrorMsg { get; set; }

        [NameInMap("LegalPersonIdCard")]
        [Validation(Required=false)]
        public string LegalPersonIdCard { get; set; }

        [NameInMap("LegalPersonName")]
        [Validation(Required=false)]
        public string LegalPersonName { get; set; }

        [NameInMap("LegalPersonPhone")]
        [Validation(Required=false)]
        public string LegalPersonPhone { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("NotaryAcceptDate")]
        [Validation(Required=false)]
        public long? NotaryAcceptDate { get; set; }

        [NameInMap("NotaryCertificate")]
        [Validation(Required=false)]
        public string NotaryCertificate { get; set; }

        [NameInMap("NotaryFailedDate")]
        [Validation(Required=false)]
        public long? NotaryFailedDate { get; set; }

        [NameInMap("NotaryFailedReason")]
        [Validation(Required=false)]
        public string NotaryFailedReason { get; set; }

        [NameInMap("NotaryOrderId")]
        [Validation(Required=false)]
        public long? NotaryOrderId { get; set; }

        [NameInMap("NotaryPlatformName")]
        [Validation(Required=false)]
        public string NotaryPlatformName { get; set; }

        [NameInMap("NotaryPostReceipt")]
        [Validation(Required=false)]
        public string NotaryPostReceipt { get; set; }

        [NameInMap("NotaryStatus")]
        [Validation(Required=false)]
        public int? NotaryStatus { get; set; }

        [NameInMap("NotarySucceedDate")]
        [Validation(Required=false)]
        public long? NotarySucceedDate { get; set; }

        [NameInMap("NotaryType")]
        [Validation(Required=false)]
        public int? NotaryType { get; set; }

        [NameInMap("OrderDate")]
        [Validation(Required=false)]
        public long? OrderDate { get; set; }

        [NameInMap("OrderPrice")]
        [Validation(Required=false)]
        public float? OrderPrice { get; set; }

        [NameInMap("Phone")]
        [Validation(Required=false)]
        public string Phone { get; set; }

        [NameInMap("ReceiverAddress")]
        [Validation(Required=false)]
        public string ReceiverAddress { get; set; }

        [NameInMap("ReceiverName")]
        [Validation(Required=false)]
        public string ReceiverName { get; set; }

        [NameInMap("ReceiverPhone")]
        [Validation(Required=false)]
        public string ReceiverPhone { get; set; }

        [NameInMap("ReceiverPostalCode")]
        [Validation(Required=false)]
        public string ReceiverPostalCode { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("SellerBackOfIdCard")]
        [Validation(Required=false)]
        public string SellerBackOfIdCard { get; set; }

        [NameInMap("SellerCompanyName")]
        [Validation(Required=false)]
        public string SellerCompanyName { get; set; }

        [NameInMap("SellerFrontOfIdCard")]
        [Validation(Required=false)]
        public string SellerFrontOfIdCard { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TmAcceptCertificate")]
        [Validation(Required=false)]
        public string TmAcceptCertificate { get; set; }

        [NameInMap("TmClassification")]
        [Validation(Required=false)]
        public string TmClassification { get; set; }

        [NameInMap("TmImage")]
        [Validation(Required=false)]
        public string TmImage { get; set; }

        [NameInMap("TmName")]
        [Validation(Required=false)]
        public string TmName { get; set; }

        [NameInMap("TmRegisterCertificate")]
        [Validation(Required=false)]
        public string TmRegisterCertificate { get; set; }

        [NameInMap("TmRegisterChangeCertificate")]
        [Validation(Required=false)]
        public string TmRegisterChangeCertificate { get; set; }

        [NameInMap("TmRegisterNo")]
        [Validation(Required=false)]
        public string TmRegisterNo { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
