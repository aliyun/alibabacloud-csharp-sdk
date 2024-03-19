// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class IntlFlightCreateOrderRequest : TeaModel {
        [NameInMap("async_create_order_key")]
        [Validation(Required=false)]
        public string AsyncCreateOrderKey { get; set; }

        [NameInMap("async_create_order_mode")]
        [Validation(Required=false)]
        public bool? AsyncCreateOrderMode { get; set; }

        [NameInMap("contact_info")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderRequestContactInfo ContactInfo { get; set; }
        public class IntlFlightCreateOrderRequestContactInfo : TeaModel {
            [NameInMap("contact_email")]
            [Validation(Required=false)]
            public string ContactEmail { get; set; }

            [NameInMap("contact_name")]
            [Validation(Required=false)]
            public string ContactName { get; set; }

            [NameInMap("contact_phone")]
            [Validation(Required=false)]
            public string ContactPhone { get; set; }

            [NameInMap("send_msg_to_passenger")]
            [Validation(Required=false)]
            public bool? SendMsgToPassenger { get; set; }

        }

        [NameInMap("cost_center")]
        [Validation(Required=false)]
        public IntlFlightCreateOrderRequestCostCenter CostCenter { get; set; }
        public class IntlFlightCreateOrderRequestCostCenter : TeaModel {
            [NameInMap("cost_center_name")]
            [Validation(Required=false)]
            public string CostCenterName { get; set; }

            [NameInMap("cost_center_number")]
            [Validation(Required=false)]
            public string CostCenterNumber { get; set; }

        }

        [NameInMap("extra_info")]
        [Validation(Required=false)]
        public Dictionary<string, string> ExtraInfo { get; set; }

        [NameInMap("isv_name")]
        [Validation(Required=false)]
        public string IsvName { get; set; }

        [NameInMap("language")]
        [Validation(Required=false)]
        public string Language { get; set; }

        [NameInMap("ota_item_id")]
        [Validation(Required=false)]
        public string OtaItemId { get; set; }

        [NameInMap("out_order_id")]
        [Validation(Required=false)]
        public string OutOrderId { get; set; }

        [NameInMap("passenger_list")]
        [Validation(Required=false)]
        public List<IntlFlightCreateOrderRequestPassengerList> PassengerList { get; set; }
        public class IntlFlightCreateOrderRequestPassengerList : TeaModel {
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
            public IntlFlightCreateOrderRequestPassengerListCertInfo CertInfo { get; set; }
            public class IntlFlightCreateOrderRequestPassengerListCertInfo : TeaModel {
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
            public List<IntlFlightCreateOrderRequestPassengerListSubsidiaryCertInfoList> SubsidiaryCertInfoList { get; set; }
            public class IntlFlightCreateOrderRequestPassengerListSubsidiaryCertInfoList : TeaModel {
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

        [NameInMap("render_key")]
        [Validation(Required=false)]
        public string RenderKey { get; set; }

        [NameInMap("total_price_cent")]
        [Validation(Required=false)]
        public long? TotalPriceCent { get; set; }

        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

        [NameInMap("user_name")]
        [Validation(Required=false)]
        public string UserName { get; set; }

    }

}
