// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Trademark20180724.Models
{
    public class QueryMaterialResponseBody : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public string Address { get; set; }

        [NameInMap("BusinessLicenceUrl")]
        [Validation(Required=false)]
        public string BusinessLicenceUrl { get; set; }

        [NameInMap("CardNumber")]
        [Validation(Required=false)]
        public string CardNumber { get; set; }

        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("ContactAddress")]
        [Validation(Required=false)]
        public string ContactAddress { get; set; }

        [NameInMap("ContactCity")]
        [Validation(Required=false)]
        public string ContactCity { get; set; }

        [NameInMap("ContactCounty")]
        [Validation(Required=false)]
        public string ContactCounty { get; set; }

        [NameInMap("ContactDistrict")]
        [Validation(Required=false)]
        public string ContactDistrict { get; set; }

        [NameInMap("ContactEmail")]
        [Validation(Required=false)]
        public string ContactEmail { get; set; }

        [NameInMap("ContactName")]
        [Validation(Required=false)]
        public string ContactName { get; set; }

        [NameInMap("ContactNumber")]
        [Validation(Required=false)]
        public string ContactNumber { get; set; }

        [NameInMap("ContactProvince")]
        [Validation(Required=false)]
        public string ContactProvince { get; set; }

        [NameInMap("ContactZipcode")]
        [Validation(Required=false)]
        public string ContactZipcode { get; set; }

        [NameInMap("Country")]
        [Validation(Required=false)]
        public string Country { get; set; }

        [NameInMap("EAddress")]
        [Validation(Required=false)]
        public string EAddress { get; set; }

        [NameInMap("EName")]
        [Validation(Required=false)]
        public string EName { get; set; }

        [NameInMap("EvidenceCatalogPath")]
        [Validation(Required=false)]
        public string EvidenceCatalogPath { get; set; }

        [NameInMap("EvidenceOfservicePath")]
        [Validation(Required=false)]
        public string EvidenceOfservicePath { get; set; }

        [NameInMap("EvidencePath")]
        [Validation(Required=false)]
        public string EvidencePath { get; set; }

        [NameInMap("ExpirationDate")]
        [Validation(Required=false)]
        public long? ExpirationDate { get; set; }

        [NameInMap("FactandreasonPdfPath")]
        [Validation(Required=false)]
        public string FactandreasonPdfPath { get; set; }

        [NameInMap("FgsqPath")]
        [Validation(Required=false)]
        public string FgsqPath { get; set; }

        [NameInMap("FileBgPath")]
        [Validation(Required=false)]
        public string FileBgPath { get; set; }

        [NameInMap("FileFsSqPath")]
        [Validation(Required=false)]
        public string FileFsSqPath { get; set; }

        [NameInMap("FileGtPath")]
        [Validation(Required=false)]
        public string FileGtPath { get; set; }

        [NameInMap("FileYgPath")]
        [Validation(Required=false)]
        public string FileYgPath { get; set; }

        /// <summary>
        /// id
        /// </summary>
        [NameInMap("Id")]
        [Validation(Required=false)]
        public long? Id { get; set; }

        [NameInMap("IdCardName")]
        [Validation(Required=false)]
        public string IdCardName { get; set; }

        [NameInMap("IdCardNumber")]
        [Validation(Required=false)]
        public string IdCardNumber { get; set; }

        [NameInMap("IdCardUrl")]
        [Validation(Required=false)]
        public string IdCardUrl { get; set; }

        [NameInMap("LegalNoticeKey")]
        [Validation(Required=false)]
        public string LegalNoticeKey { get; set; }

        [NameInMap("LegalNoticeUrl")]
        [Validation(Required=false)]
        public string LegalNoticeUrl { get; set; }

        [NameInMap("LoaStatus")]
        [Validation(Required=false)]
        public int? LoaStatus { get; set; }

        [NameInMap("LoaUrl")]
        [Validation(Required=false)]
        public string LoaUrl { get; set; }

        [NameInMap("MaterialVersion")]
        [Validation(Required=false)]
        public string MaterialVersion { get; set; }

        [NameInMap("Name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        [NameInMap("Note")]
        [Validation(Required=false)]
        public string Note { get; set; }

        [NameInMap("PassportUrl")]
        [Validation(Required=false)]
        public string PassportUrl { get; set; }

        [NameInMap("PersonalType")]
        [Validation(Required=false)]
        public long? PersonalType { get; set; }

        [NameInMap("PrincipalDescription")]
        [Validation(Required=false)]
        public string PrincipalDescription { get; set; }

        [NameInMap("PrincipalName")]
        [Validation(Required=false)]
        public int? PrincipalName { get; set; }

        [NameInMap("Province")]
        [Validation(Required=false)]
        public string Province { get; set; }

        [NameInMap("Reason")]
        [Validation(Required=false)]
        public string Reason { get; set; }

        [NameInMap("Region")]
        [Validation(Required=false)]
        public int? Region { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ReviewAdditionalFiles")]
        [Validation(Required=false)]
        public QueryMaterialResponseBodyReviewAdditionalFiles ReviewAdditionalFiles { get; set; }
        public class QueryMaterialResponseBodyReviewAdditionalFiles : TeaModel {
            [NameInMap("ReviewAdditionalFile")]
            [Validation(Required=false)]
            public List<string> ReviewAdditionalFile { get; set; }

        }

        [NameInMap("ReviewApplicationFile")]
        [Validation(Required=false)]
        public string ReviewApplicationFile { get; set; }

        [NameInMap("Status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("SupplementEvidenceCatalogFile")]
        [Validation(Required=false)]
        public string SupplementEvidenceCatalogFile { get; set; }

        [NameInMap("SupplementEvidenceMaterialFile")]
        [Validation(Required=false)]
        public string SupplementEvidenceMaterialFile { get; set; }

        [NameInMap("SupplementReasonFile")]
        [Validation(Required=false)]
        public string SupplementReasonFile { get; set; }

        [NameInMap("SystemVersion")]
        [Validation(Required=false)]
        public string SystemVersion { get; set; }

        [NameInMap("Town")]
        [Validation(Required=false)]
        public string Town { get; set; }

        [NameInMap("Type")]
        [Validation(Required=false)]
        public int? Type { get; set; }

        [NameInMap("ValidDate")]
        [Validation(Required=false)]
        public long? ValidDate { get; set; }

    }

}
