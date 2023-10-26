// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class CarApplyAddShrinkRequest : TeaModel {
        [NameInMap("cause")]
        [Validation(Required=false)]
        public string Cause { get; set; }

        [NameInMap("city")]
        [Validation(Required=false)]
        public string City { get; set; }

        [NameInMap("city_code_set")]
        [Validation(Required=false)]
        public string CityCodeSet { get; set; }

        [NameInMap("date")]
        [Validation(Required=false)]
        public string Date { get; set; }

        [NameInMap("finished_date")]
        [Validation(Required=false)]
        public string FinishedDate { get; set; }

        [NameInMap("project_code")]
        [Validation(Required=false)]
        public string ProjectCode { get; set; }

        [NameInMap("project_name")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        [NameInMap("status")]
        [Validation(Required=false)]
        public int? Status { get; set; }

        [NameInMap("third_part_apply_id")]
        [Validation(Required=false)]
        public string ThirdPartApplyId { get; set; }

        [NameInMap("third_part_cost_center_id")]
        [Validation(Required=false)]
        public string ThirdPartCostCenterId { get; set; }

        [NameInMap("third_part_invoice_id")]
        [Validation(Required=false)]
        public string ThirdPartInvoiceId { get; set; }

        [NameInMap("times_total")]
        [Validation(Required=false)]
        public int? TimesTotal { get; set; }

        [NameInMap("times_type")]
        [Validation(Required=false)]
        public int? TimesType { get; set; }

        [NameInMap("times_used")]
        [Validation(Required=false)]
        public int? TimesUsed { get; set; }

        [NameInMap("title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        [NameInMap("traveler_standard")]
        [Validation(Required=false)]
        public string TravelerStandardShrink { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
