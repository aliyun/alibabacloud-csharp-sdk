// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.BtripOpen20220520.Models
{
    public class TrainTicketScanQueryResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>成功</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The response data. The server returns null if no results are found or an exception occurs.</para>
        /// </summary>
        [NameInMap("module")]
        [Validation(Required=false)]
        public TrainTicketScanQueryResponseBodyModule Module { get; set; }
        public class TrainTicketScanQueryResponseBodyModule : TeaModel {
            /// <summary>
            /// <para>The paginated results.</para>
            /// </summary>
            [NameInMap("items")]
            [Validation(Required=false)]
            public List<TrainTicketScanQueryResponseBodyModuleItems> Items { get; set; }
            public class TrainTicketScanQueryResponseBodyModuleItems : TeaModel {
                /// <summary>
                /// <para>The approval number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>sdasdas123324</para>
                /// </summary>
                [NameInMap("apply_id")]
                [Validation(Required=false)]
                public string ApplyId { get; set; }

                /// <summary>
                /// <para>The arrival station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>杭州东</para>
                /// </summary>
                [NameInMap("arr_station")]
                [Validation(Required=false)]
                public string ArrStation { get; set; }

                /// <summary>
                /// <para>The billing date.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2022-12-01</para>
                /// </summary>
                [NameInMap("bill_date")]
                [Validation(Required=false)]
                public string BillDate { get; set; }

                /// <summary>
                /// <para>The coach name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>04车</para>
                /// </summary>
                [NameInMap("coach_name")]
                [Validation(Required=false)]
                public string CoachName { get; set; }

                /// <summary>
                /// <para>The cost center.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试成本中心</para>
                /// </summary>
                [NameInMap("cost_center")]
                [Validation(Required=false)]
                public string CostCenter { get; set; }

                /// <summary>
                /// <para>The departure station.</para>
                /// 
                /// <b>Example:</b>
                /// <para>上海虹桥</para>
                /// </summary>
                [NameInMap("dep_station")]
                [Validation(Required=false)]
                public string DepStation { get; set; }

                /// <summary>
                /// <para>The departure time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2023-01-12 10:00:00</para>
                /// </summary>
                [NameInMap("dep_time")]
                [Validation(Required=false)]
                public string DepTime { get; set; }

                /// <summary>
                /// <para>The department.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试公司-测试部门</para>
                /// </summary>
                [NameInMap("department")]
                [Validation(Required=false)]
                public string Department { get; set; }

                /// <summary>
                /// <para>The electronic ticket number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7647889000001X1</para>
                /// </summary>
                [NameInMap("electronic_ticket_no")]
                [Validation(Required=false)]
                public string ElectronicTicketNo { get; set; }

                /// <summary>
                /// <para>The invoice item. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: ticket price</description></item>
                /// <item><description>2: change or cancellation fee</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("fee_type_show_code")]
                [Validation(Required=false)]
                public int? FeeTypeShowCode { get; set; }

                /// <summary>
                /// <para>Indicates whether the ticket has been reissued.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("has_changed")]
                [Validation(Required=false)]
                public bool? HasChanged { get; set; }

                /// <summary>
                /// <para>The primary key ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>71</para>
                /// </summary>
                [NameInMap("id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <para>The invoice issue time.</para>
                /// 
                /// <b>Example:</b>
                /// <para>2025-04-07 00:00:00</para>
                /// </summary>
                [NameInMap("invoice_date")]
                [Validation(Required=false)]
                public string InvoiceDate { get; set; }

                /// <summary>
                /// <para>The invoice type. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>1: electronic train ticket voucher</description></item>
                /// <item><description>2: paper train ticket voucher</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("invoice_material")]
                [Validation(Required=false)]
                public int? InvoiceMaterial { get; set; }

                /// <summary>
                /// <para>The invoice title.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试发票抬头</para>
                /// </summary>
                [NameInMap("invoice_title")]
                [Validation(Required=false)]
                public string InvoiceTitle { get; set; }

                /// <summary>
                /// <para>The URL for obtaining the electronic invoicing document in OFD format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("ofd_url")]
                [Validation(Required=false)]
                public string OfdUrl { get; set; }

                /// <summary>
                /// <para>The business travel order number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>3137168772101111000</para>
                /// </summary>
                [NameInMap("order_id")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                /// <summary>
                /// <para>The original invoice number associated with the reissued ticket.</para>
                /// 
                /// <b>Example:</b>
                /// <para>112435451313</para>
                /// </summary>
                [NameInMap("origin_ticket_no")]
                [Validation(Required=false)]
                public string OriginTicketNo { get; set; }

                /// <summary>
                /// <para>The download URL.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("oss_url")]
                [Validation(Required=false)]
                public string OssUrl { get; set; }

                /// <summary>
                /// <para>The passenger.</para>
                /// 
                /// <b>Example:</b>
                /// <para>张三</para>
                /// </summary>
                [NameInMap("passenger")]
                [Validation(Required=false)]
                public string Passenger { get; set; }

                /// <summary>
                /// <para>The URL for obtaining the electronic invoicing document in PDF format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("pdf_url")]
                [Validation(Required=false)]
                public string PdfUrl { get; set; }

                /// <summary>
                /// <para>The ticket price.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100</para>
                /// </summary>
                [NameInMap("price")]
                [Validation(Required=false)]
                public string Price { get; set; }

                /// <summary>
                /// <para>The project.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试项目名称</para>
                /// </summary>
                [NameInMap("project")]
                [Validation(Required=false)]
                public string Project { get; set; }

                /// <summary>
                /// <para>The purchaser name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>测试购方抬头</para>
                /// </summary>
                [NameInMap("purchaser_name")]
                [Validation(Required=false)]
                public string PurchaserName { get; set; }

                /// <summary>
                /// <para>The purchaser tax number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>91441111111111111S</para>
                /// </summary>
                [NameInMap("purchaser_tax_no")]
                [Validation(Required=false)]
                public string PurchaserTaxNo { get; set; }

                /// <summary>
                /// <para>The seat class.</para>
                /// 
                /// <b>Example:</b>
                /// <para>二等座</para>
                /// </summary>
                [NameInMap("seat")]
                [Validation(Required=false)]
                public string Seat { get; set; }

                /// <summary>
                /// <para>The seat number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>10C号</para>
                /// </summary>
                [NameInMap("seat_no")]
                [Validation(Required=false)]
                public string SeatNo { get; set; }

                /// <summary>
                /// <para>The invoice number or ticket serial number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>30671211200127U123456</para>
                /// </summary>
                [NameInMap("serial_number")]
                [Validation(Required=false)]
                public string SerialNumber { get; set; }

                /// <summary>
                /// <para>The tax amount.</para>
                /// 
                /// <b>Example:</b>
                /// <para>8.26</para>
                /// </summary>
                [NameInMap("tax_amount")]
                [Validation(Required=false)]
                public string TaxAmount { get; set; }

                /// <summary>
                /// <para>The tax rate.</para>
                /// 
                /// <b>Example:</b>
                /// <para>9%</para>
                /// </summary>
                [NameInMap("tax_rate")]
                [Validation(Required=false)]
                public string TaxRate { get; set; }

                /// <summary>
                /// <para>The ticket collection number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>784-1111111111</para>
                /// </summary>
                [NameInMap("ticket_no")]
                [Validation(Required=false)]
                public string TicketNo { get; set; }

                /// <summary>
                /// <para>The train number.</para>
                /// 
                /// <b>Example:</b>
                /// <para>G99</para>
                /// </summary>
                [NameInMap("train_no")]
                [Validation(Required=false)]
                public string TrainNo { get; set; }

                /// <summary>
                /// <para>The URL for obtaining the electronic invoicing document in XML format.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="https://www.testurl.com">https://www.testurl.com</a></para>
                /// </summary>
                [NameInMap("xml_url")]
                [Validation(Required=false)]
                public string XmlUrl { get; set; }

            }

            /// <summary>
            /// <para>The page number of this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("page_no")]
            [Validation(Required=false)]
            public int? PageNo { get; set; }

            /// <summary>
            /// <para>The page size of this request.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("page_size")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// <para>The total number of pages.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("total_page")]
            [Validation(Required=false)]
            public int? TotalPage { get; set; }

            /// <summary>
            /// <para>The total number of entries.</para>
            /// 
            /// <b>Example:</b>
            /// <para>30</para>
            /// </summary>
            [NameInMap("total_size")]
            [Validation(Required=false)]
            public int? TotalSize { get; set; }

        }

        /// <summary>
        /// <para>requestId</para>
        /// 
        /// <b>Example:</b>
        /// <para>C61ECFF6-606B-5F66-B81D-D77369043A5F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

        /// <summary>
        /// <para>traceId</para>
        /// 
        /// <b>Example:</b>
        /// <para>21041ce316577904808056433edbb2</para>
        /// </summary>
        [NameInMap("traceId")]
        [Validation(Required=false)]
        public string TraceId { get; set; }

    }

}
