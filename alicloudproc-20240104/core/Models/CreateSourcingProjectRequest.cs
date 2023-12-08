// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Alicloudproc20240104.Models
{
    public class CreateSourcingProjectRequest : TeaModel {
        [NameInMap("Address")]
        [Validation(Required=false)]
        public CreateSourcingProjectRequestAddress Address { get; set; }
        public class CreateSourcingProjectRequestAddress : TeaModel {
            [NameInMap("CityCode")]
            [Validation(Required=false)]
            public string CityCode { get; set; }

            [NameInMap("Detail")]
            [Validation(Required=false)]
            public string Detail { get; set; }

            [NameInMap("DistrictCode")]
            [Validation(Required=false)]
            public string DistrictCode { get; set; }

            [NameInMap("ProvinceCode")]
            [Validation(Required=false)]
            public string ProvinceCode { get; set; }

        }

        [NameInMap("BizId")]
        [Validation(Required=false)]
        public string BizId { get; set; }

        [NameInMap("BizNo")]
        [Validation(Required=false)]
        public string BizNo { get; set; }

        [NameInMap("BizType")]
        [Validation(Required=false)]
        public string BizType { get; set; }

        [NameInMap("Company")]
        [Validation(Required=false)]
        public CreateSourcingProjectRequestCompany Company { get; set; }
        public class CreateSourcingProjectRequestCompany : TeaModel {
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Uscc")]
            [Validation(Required=false)]
            public string Uscc { get; set; }

        }

        [NameInMap("Contact")]
        [Validation(Required=false)]
        public CreateSourcingProjectRequestContact Contact { get; set; }
        public class CreateSourcingProjectRequestContact : TeaModel {
            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

        }

        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        [NameInMap("ExpireTime")]
        [Validation(Required=false)]
        public string ExpireTime { get; set; }

        [NameInMap("ExtendInfo")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtendInfo { get; set; }

        [NameInMap("SourceUrl")]
        [Validation(Required=false)]
        public string SourceUrl { get; set; }

        [NameInMap("SubBizType")]
        [Validation(Required=false)]
        public string SubBizType { get; set; }

        [NameInMap("Subjects")]
        [Validation(Required=false)]
        public List<CreateSourcingProjectRequestSubjects> Subjects { get; set; }
        public class CreateSourcingProjectRequestSubjects : TeaModel {
            [NameInMap("Address")]
            [Validation(Required=false)]
            public CreateSourcingProjectRequestSubjectsAddress Address { get; set; }
            public class CreateSourcingProjectRequestSubjectsAddress : TeaModel {
                [NameInMap("CityCode")]
                [Validation(Required=false)]
                public string CityCode { get; set; }

                [NameInMap("Detail")]
                [Validation(Required=false)]
                public string Detail { get; set; }

                [NameInMap("DistrictCode")]
                [Validation(Required=false)]
                public string DistrictCode { get; set; }

                [NameInMap("ProvinceCode")]
                [Validation(Required=false)]
                public string ProvinceCode { get; set; }

            }

            [NameInMap("Code")]
            [Validation(Required=false)]
            public string Code { get; set; }

            [NameInMap("ExtendInfo")]
            [Validation(Required=false)]
            public Dictionary<string, string> ExtendInfo { get; set; }

            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            [NameInMap("Quantity")]
            [Validation(Required=false)]
            public double? Quantity { get; set; }

            [NameInMap("Spec")]
            [Validation(Required=false)]
            public string Spec { get; set; }

            [NameInMap("Unit")]
            [Validation(Required=false)]
            public string Unit { get; set; }

        }

        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
