// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightInventoryPriceCheckRequest : TeaModel {
        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("order_price")]
        [Validation(Required=false)]
        public long? OrderPrice { get; set; }

        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightInventoryPriceCheckRequestPassengerList> PassengerList { get; set; }
        public class IntlFlightInventoryPriceCheckRequestPassengerList : TeaModel {
            [NameInMap("birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            [NameInMap("cascade_dept_mask")]
            [Validation(Required=false)]
            public string CascadeDeptMask { get; set; }

            [NameInMap("cascade_dept_name")]
            [Validation(Required=false)]
            public string CascadeDeptName { get; set; }

            [NameInMap("cert_info")]
            [Validation(Required=false)]
            public IntlFlightInventoryPriceCheckRequestPassengerListCertInfo CertInfo { get; set; }
            public class IntlFlightInventoryPriceCheckRequestPassengerListCertInfo : TeaModel {
                [NameInMap("cert_nation")]
                [Validation(Required=false)]
                public string CertNation { get; set; }

                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                [NameInMap("cert_valid_date")]
                [Validation(Required=false)]
                public string CertValidDate { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("cost_center_name")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            [NameInMap("cost_center_number")]
            [Validation(Required=false)]
            public string CostCenterNumber { get; set; }

            [NameInMap("dept_id")]
            [Validation(Required=false)]
            public string DeptId { get; set; }

            [NameInMap("dept_name")]
            [Validation(Required=false)]
            public string DeptName { get; set; }

            [NameInMap("gender")]
            [Validation(Required=false)]
            public int? Gender { get; set; }

            [NameInMap("invoice_id")]
            [Validation(Required=false)]
            public string InvoiceId { get; set; }

            [NameInMap("invoice_title")]
            [Validation(Required=false)]
            public string InvoiceTitle { get; set; }

            [NameInMap("job_no")]
            [Validation(Required=false)]
            public string JobNo { get; set; }

            [NameInMap("mobile_country_code")]
            [Validation(Required=false)]
            public string MobileCountryCode { get; set; }

            [NameInMap("nationality")]
            [Validation(Required=false)]
            public string Nationality { get; set; }

            [NameInMap("nationality_code")]
            [Validation(Required=false)]
            public string NationalityCode { get; set; }

            [NameInMap("passenger_type")]
            [Validation(Required=false)]
            public int? PassengerType { get; set; }

            [NameInMap("phone")]
            [Validation(Required=false)]
            public string Phone { get; set; }

            [NameInMap("project_code")]
            [Validation(Required=false)]
            public string ProjectCode { get; set; }

            [NameInMap("project_title")]
            [Validation(Required=false)]
            public string ProjectTitle { get; set; }

            [NameInMap("subsidiary_cert_info_list")]
            [Validation(Required=false)]
            public List<IntlFlightInventoryPriceCheckRequestPassengerListSubsidiaryCertInfoList> SubsidiaryCertInfoList { get; set; }
            public class IntlFlightInventoryPriceCheckRequestPassengerListSubsidiaryCertInfoList : TeaModel {
                [NameInMap("cert_nation")]
                [Validation(Required=false)]
                public string CertNation { get; set; }

                [NameInMap("cert_no")]
                [Validation(Required=false)]
                public string CertNo { get; set; }

                [NameInMap("cert_type")]
                [Validation(Required=false)]
                public int? CertType { get; set; }

                [NameInMap("cert_valid_date")]
                [Validation(Required=false)]
                public string CertValidDate { get; set; }

                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

            [NameInMap("user_id")]
            [Validation(Required=false)]
            public string UserId { get; set; }

            [NameInMap("user_type")]
            [Validation(Required=false)]
            public int? UserType { get; set; }

        }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
