// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dt_oc_info20220829.Models
{
    public class GetOcIcBasicResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetOcIcBasicResponseBodyData Data { get; set; }
        public class GetOcIcBasicResponseBodyData : TeaModel {
            [NameInMap("CheckDate")]
            [Validation(Required=false)]
            public string CheckDate { get; set; }

            [NameInMap("EntAddress")]
            [Validation(Required=false)]
            public string EntAddress { get; set; }

            [NameInMap("EntBrief")]
            [Validation(Required=false)]
            public string EntBrief { get; set; }

            [NameInMap("EntName")]
            [Validation(Required=false)]
            public string EntName { get; set; }

            [NameInMap("EntNameEng")]
            [Validation(Required=false)]
            public string EntNameEng { get; set; }

            [NameInMap("EntStatus")]
            [Validation(Required=false)]
            public string EntStatus { get; set; }

            [NameInMap("EntType")]
            [Validation(Required=false)]
            public string EntType { get; set; }

            [NameInMap("EsDate")]
            [Validation(Required=false)]
            public string EsDate { get; set; }

            [NameInMap("FormerNames")]
            [Validation(Required=false)]
            public string FormerNames { get; set; }

            [NameInMap("IndustryNameLv1")]
            [Validation(Required=false)]
            public string IndustryNameLv1 { get; set; }

            [NameInMap("IndustryNameLv2")]
            [Validation(Required=false)]
            public string IndustryNameLv2 { get; set; }

            [NameInMap("InsuredNum")]
            [Validation(Required=false)]
            public string InsuredNum { get; set; }

            [NameInMap("LegalName")]
            [Validation(Required=false)]
            public string LegalName { get; set; }

            [NameInMap("LicenseNumber")]
            [Validation(Required=false)]
            public string LicenseNumber { get; set; }

            [NameInMap("OpFrom")]
            [Validation(Required=false)]
            public string OpFrom { get; set; }

            [NameInMap("OpScope")]
            [Validation(Required=false)]
            public string OpScope { get; set; }

            [NameInMap("OpTo")]
            [Validation(Required=false)]
            public string OpTo { get; set; }

            [NameInMap("OrgNo")]
            [Validation(Required=false)]
            public string OrgNo { get; set; }

            [NameInMap("RecCap")]
            [Validation(Required=false)]
            public string RecCap { get; set; }

            [NameInMap("RegCap")]
            [Validation(Required=false)]
            public string RegCap { get; set; }

            [NameInMap("RegOrg")]
            [Validation(Required=false)]
            public string RegOrg { get; set; }

            [NameInMap("RegOrgCity")]
            [Validation(Required=false)]
            public string RegOrgCity { get; set; }

            [NameInMap("RegOrgDistrict")]
            [Validation(Required=false)]
            public string RegOrgDistrict { get; set; }

            [NameInMap("RegOrgProvince")]
            [Validation(Required=false)]
            public string RegOrgProvince { get; set; }

            [NameInMap("SocialCreditCode")]
            [Validation(Required=false)]
            public string SocialCreditCode { get; set; }

            [NameInMap("StaffNum")]
            [Validation(Required=false)]
            public string StaffNum { get; set; }

            [NameInMap("TaxNum")]
            [Validation(Required=false)]
            public string TaxNum { get; set; }

        }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("PageIndex")]
        [Validation(Required=false)]
        public int? PageIndex { get; set; }

        [NameInMap("PageNum")]
        [Validation(Required=false)]
        public int? PageNum { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        [NameInMap("TotalNum")]
        [Validation(Required=false)]
        public int? TotalNum { get; set; }

    }

}
