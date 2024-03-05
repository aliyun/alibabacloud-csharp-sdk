// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CustomerService20231228.Models
{
    public class GetServiceDetailResponseBody : TeaModel {
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("data")]
        [Validation(Required=false)]
        public GetServiceDetailResponseBodyData Data { get; set; }
        public class GetServiceDetailResponseBodyData : TeaModel {
            [NameInMap("applierId")]
            [Validation(Required=false)]
            public string ApplierId { get; set; }

            [NameInMap("applyCode")]
            [Validation(Required=false)]
            public string ApplyCode { get; set; }

            [NameInMap("applyTime")]
            [Validation(Required=false)]
            public long? ApplyTime { get; set; }

            [NameInMap("appointments")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataAppointments> Appointments { get; set; }
            public class GetServiceDetailResponseBodyDataAppointments : TeaModel {
                [NameInMap("huhangId")]
                [Validation(Required=false)]
                public long? HuhangId { get; set; }

                [NameInMap("purchaseCode")]
                [Validation(Required=false)]
                public int? PurchaseCode { get; set; }

                [NameInMap("purchaseDesc")]
                [Validation(Required=false)]
                public string PurchaseDesc { get; set; }

                [NameInMap("supportDays")]
                [Validation(Required=false)]
                public int? SupportDays { get; set; }

                [NameInMap("travelDays")]
                [Validation(Required=false)]
                public int? TravelDays { get; set; }

            }

            [NameInMap("buyUrl")]
            [Validation(Required=false)]
            public string BuyUrl { get; set; }

            [NameInMap("creatorEmpId")]
            [Validation(Required=false)]
            public string CreatorEmpId { get; set; }

            [NameInMap("customerName")]
            [Validation(Required=false)]
            public string CustomerName { get; set; }

            [NameInMap("cycleService")]
            [Validation(Required=false)]
            public bool? CycleService { get; set; }

            [NameInMap("executedCount")]
            [Validation(Required=false)]
            public long? ExecutedCount { get; set; }

            [NameInMap("finishCount")]
            [Validation(Required=false)]
            public long? FinishCount { get; set; }

            [NameInMap("formMap")]
            [Validation(Required=false)]
            public Dictionary<string, object> FormMap { get; set; }

            [NameInMap("gmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("gmtModified")]
            [Validation(Required=false)]
            public string GmtModified { get; set; }

            [NameInMap("id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            [NameInMap("mergeSolutionAndReporterOneStep")]
            [Validation(Required=false)]
            public bool? MergeSolutionAndReporterOneStep { get; set; }

            [NameInMap("modifierEmpId")]
            [Validation(Required=false)]
            public string ModifierEmpId { get; set; }

            [NameInMap("packDetails")]
            [Validation(Required=false)]
            public List<Dictionary<string, object>> PackDetails { get; set; }

            [NameInMap("payOrders")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataPayOrders> PayOrders { get; set; }
            public class GetServiceDetailResponseBodyDataPayOrders : TeaModel {
                [NameInMap("amount")]
                [Validation(Required=false)]
                public string Amount { get; set; }

                [NameInMap("compassCommodityCode")]
                [Validation(Required=false)]
                public string CompassCommodityCode { get; set; }

                [NameInMap("compassCommodityName")]
                [Validation(Required=false)]
                public string CompassCommodityName { get; set; }

                [NameInMap("creatorEmpId")]
                [Validation(Required=false)]
                public string CreatorEmpId { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("modifierEmpId")]
                [Validation(Required=false)]
                public string ModifierEmpId { get; set; }

                [NameInMap("operate")]
                [Validation(Required=false)]
                public Dictionary<string, object> Operate { get; set; }

                [NameInMap("orderDetail")]
                [Validation(Required=false)]
                public object OrderDetail { get; set; }

                [NameInMap("orderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("originalPrice")]
                [Validation(Required=false)]
                public double? OriginalPrice { get; set; }

                [NameInMap("payAmount")]
                [Validation(Required=false)]
                public double? PayAmount { get; set; }

                [NameInMap("payTime")]
                [Validation(Required=false)]
                public string PayTime { get; set; }

                [NameInMap("productName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

                [NameInMap("reneWalUrl")]
                [Validation(Required=false)]
                public string ReneWalUrl { get; set; }

                [NameInMap("serviceContentMap")]
                [Validation(Required=false)]
                public Dictionary<string, object> ServiceContentMap { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("statusStr")]
                [Validation(Required=false)]
                public string StatusStr { get; set; }

                [NameInMap("supportDays")]
                [Validation(Required=false)]
                public int? SupportDays { get; set; }

                [NameInMap("uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("payUrl")]
            [Validation(Required=false)]
            public string PayUrl { get; set; }

            [NameInMap("performanceOrders")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataPerformanceOrders> PerformanceOrders { get; set; }
            public class GetServiceDetailResponseBodyDataPerformanceOrders : TeaModel {
                [NameInMap("applyFileVOList")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersApplyFileVOList> ApplyFileVOList { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersApplyFileVOList : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("appointmentCode")]
                [Validation(Required=false)]
                public string AppointmentCode { get; set; }

                [NameInMap("appointmentEndTime")]
                [Validation(Required=false)]
                public long? AppointmentEndTime { get; set; }

                [NameInMap("appointmentId")]
                [Validation(Required=false)]
                public string AppointmentId { get; set; }

                [NameInMap("appointmentPassTime")]
                [Validation(Required=false)]
                public long? AppointmentPassTime { get; set; }

                [NameInMap("appointmentTime")]
                [Validation(Required=false)]
                public long? AppointmentTime { get; set; }

                [NameInMap("commodityDesc")]
                [Validation(Required=false)]
                public string CommodityDesc { get; set; }

                [NameInMap("creatorEmpId")]
                [Validation(Required=false)]
                public string CreatorEmpId { get; set; }

                [NameInMap("cycleService")]
                [Validation(Required=false)]
                public bool? CycleService { get; set; }

                [NameInMap("extList")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersExtList> ExtList { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersExtList : TeaModel {
                    [NameInMap("keyCode")]
                    [Validation(Required=false)]
                    public string KeyCode { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                    [NameInMap("view")]
                    [Validation(Required=false)]
                    public string View { get; set; }

                }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("mergeSolutionAndReporterOneStep")]
                [Validation(Required=false)]
                public bool? MergeSolutionAndReporterOneStep { get; set; }

                [NameInMap("modifierEmpId")]
                [Validation(Required=false)]
                public string ModifierEmpId { get; set; }

                [NameInMap("orderDetail")]
                [Validation(Required=false)]
                public object OrderDetail { get; set; }

                [NameInMap("orderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("packCount")]
                [Validation(Required=false)]
                public int? PackCount { get; set; }

                [NameInMap("packDetails")]
                [Validation(Required=false)]
                public List<Dictionary<string, object>> PackDetails { get; set; }

                [NameInMap("performanceNodeDTOS")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformanceNodeDTOS> PerformanceNodeDTOS { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformanceNodeDTOS : TeaModel {
                    [NameInMap("display")]
                    [Validation(Required=false)]
                    public bool? Display { get; set; }

                    [NameInMap("extendInfo")]
                    [Validation(Required=false)]
                    public object ExtendInfo { get; set; }

                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("nodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

                [NameInMap("performancePacks")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacks> PerformancePacks { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacks : TeaModel {
                    [NameInMap("applyFileVOList")]
                    [Validation(Required=false)]
                    public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksApplyFileVOList> ApplyFileVOList { get; set; }
                    public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksApplyFileVOList : TeaModel {
                        [NameInMap("appointmentId")]
                        [Validation(Required=false)]
                        public string AppointmentId { get; set; }

                        [NameInMap("batchGroup")]
                        [Validation(Required=false)]
                        public string BatchGroup { get; set; }

                        [NameInMap("customerId")]
                        [Validation(Required=false)]
                        public string CustomerId { get; set; }

                        [NameInMap("fileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        [NameInMap("fileType")]
                        [Validation(Required=false)]
                        public int? FileType { get; set; }

                        [NameInMap("gmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("gmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("remarke")]
                        [Validation(Required=false)]
                        public string Remarke { get; set; }

                        [NameInMap("serviceApplyId")]
                        [Validation(Required=false)]
                        public long? ServiceApplyId { get; set; }

                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("appointmentCode")]
                    [Validation(Required=false)]
                    public string AppointmentCode { get; set; }

                    [NameInMap("appointmentEndTime")]
                    [Validation(Required=false)]
                    public long? AppointmentEndTime { get; set; }

                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("appointmentPassTime")]
                    [Validation(Required=false)]
                    public long? AppointmentPassTime { get; set; }

                    [NameInMap("appointmentTime")]
                    [Validation(Required=false)]
                    public long? AppointmentTime { get; set; }

                    [NameInMap("commodityDesc")]
                    [Validation(Required=false)]
                    public string CommodityDesc { get; set; }

                    [NameInMap("creatorEmpId")]
                    [Validation(Required=false)]
                    public string CreatorEmpId { get; set; }

                    [NameInMap("cycleService")]
                    [Validation(Required=false)]
                    public bool? CycleService { get; set; }

                    [NameInMap("extList")]
                    [Validation(Required=false)]
                    public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksExtList> ExtList { get; set; }
                    public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksExtList : TeaModel {
                        [NameInMap("keyCode")]
                        [Validation(Required=false)]
                        public string KeyCode { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("value")]
                        [Validation(Required=false)]
                        public object Value { get; set; }

                        [NameInMap("view")]
                        [Validation(Required=false)]
                        public string View { get; set; }

                    }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("mergeSolutionAndReporterOneStep")]
                    [Validation(Required=false)]
                    public bool? MergeSolutionAndReporterOneStep { get; set; }

                    [NameInMap("modifierEmpId")]
                    [Validation(Required=false)]
                    public string ModifierEmpId { get; set; }

                    [NameInMap("orderDetail")]
                    [Validation(Required=false)]
                    public object OrderDetail { get; set; }

                    [NameInMap("orderId")]
                    [Validation(Required=false)]
                    public long? OrderId { get; set; }

                    [NameInMap("performanceNodeDTOS")]
                    [Validation(Required=false)]
                    public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksPerformanceNodeDTOS> PerformanceNodeDTOS { get; set; }
                    public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksPerformanceNodeDTOS : TeaModel {
                        [NameInMap("display")]
                        [Validation(Required=false)]
                        public bool? Display { get; set; }

                        [NameInMap("extendInfo")]
                        [Validation(Required=false)]
                        public object ExtendInfo { get; set; }

                        [NameInMap("index")]
                        [Validation(Required=false)]
                        public int? Index { get; set; }

                        [NameInMap("nodeName")]
                        [Validation(Required=false)]
                        public string NodeName { get; set; }

                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                    }

                    [NameInMap("purchasePackCode")]
                    [Validation(Required=false)]
                    public int? PurchasePackCode { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("serviceMonthReports")]
                    [Validation(Required=false)]
                    public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksServiceMonthReports> ServiceMonthReports { get; set; }
                    public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksServiceMonthReports : TeaModel {
                        [NameInMap("appointmentId")]
                        [Validation(Required=false)]
                        public string AppointmentId { get; set; }

                        [NameInMap("batchGroup")]
                        [Validation(Required=false)]
                        public string BatchGroup { get; set; }

                        [NameInMap("customerId")]
                        [Validation(Required=false)]
                        public string CustomerId { get; set; }

                        [NameInMap("fileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        [NameInMap("fileType")]
                        [Validation(Required=false)]
                        public int? FileType { get; set; }

                        [NameInMap("gmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("gmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("remarke")]
                        [Validation(Required=false)]
                        public string Remarke { get; set; }

                        [NameInMap("serviceApplyId")]
                        [Validation(Required=false)]
                        public long? ServiceApplyId { get; set; }

                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("serviceReports")]
                    [Validation(Required=false)]
                    public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksServiceReports> ServiceReports { get; set; }
                    public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksServiceReports : TeaModel {
                        [NameInMap("appointmentId")]
                        [Validation(Required=false)]
                        public string AppointmentId { get; set; }

                        [NameInMap("batchGroup")]
                        [Validation(Required=false)]
                        public string BatchGroup { get; set; }

                        [NameInMap("customerId")]
                        [Validation(Required=false)]
                        public string CustomerId { get; set; }

                        [NameInMap("fileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        [NameInMap("fileType")]
                        [Validation(Required=false)]
                        public int? FileType { get; set; }

                        [NameInMap("gmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("gmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("remarke")]
                        [Validation(Required=false)]
                        public string Remarke { get; set; }

                        [NameInMap("serviceApplyId")]
                        [Validation(Required=false)]
                        public long? ServiceApplyId { get; set; }

                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("serviceSchemes")]
                    [Validation(Required=false)]
                    public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksServiceSchemes> ServiceSchemes { get; set; }
                    public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksServiceSchemes : TeaModel {
                        [NameInMap("appointmentId")]
                        [Validation(Required=false)]
                        public string AppointmentId { get; set; }

                        [NameInMap("batchGroup")]
                        [Validation(Required=false)]
                        public string BatchGroup { get; set; }

                        [NameInMap("customerId")]
                        [Validation(Required=false)]
                        public string CustomerId { get; set; }

                        [NameInMap("fileName")]
                        [Validation(Required=false)]
                        public string FileName { get; set; }

                        [NameInMap("fileType")]
                        [Validation(Required=false)]
                        public int? FileType { get; set; }

                        [NameInMap("gmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("gmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("remarke")]
                        [Validation(Required=false)]
                        public string Remarke { get; set; }

                        [NameInMap("serviceApplyId")]
                        [Validation(Required=false)]
                        public long? ServiceApplyId { get; set; }

                        [NameInMap("status")]
                        [Validation(Required=false)]
                        public int? Status { get; set; }

                        [NameInMap("url")]
                        [Validation(Required=false)]
                        public string Url { get; set; }

                    }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("statusStr")]
                    [Validation(Required=false)]
                    public string StatusStr { get; set; }

                    [NameInMap("supportTime")]
                    [Validation(Required=false)]
                    public List<long?> SupportTime { get; set; }

                    [NameInMap("tamEngineers")]
                    [Validation(Required=false)]
                    public List<GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksTamEngineers> TamEngineers { get; set; }
                    public class GetServiceDetailResponseBodyDataPerformanceOrdersPerformancePacksTamEngineers : TeaModel {
                        [NameInMap("creatorEmpId")]
                        [Validation(Required=false)]
                        public string CreatorEmpId { get; set; }

                        [NameInMap("gmtCreate")]
                        [Validation(Required=false)]
                        public string GmtCreate { get; set; }

                        [NameInMap("gmtModified")]
                        [Validation(Required=false)]
                        public string GmtModified { get; set; }

                        [NameInMap("hrStatus")]
                        [Validation(Required=false)]
                        public string HrStatus { get; set; }

                        [NameInMap("id")]
                        [Validation(Required=false)]
                        public long? Id { get; set; }

                        [NameInMap("lastName")]
                        [Validation(Required=false)]
                        public string LastName { get; set; }

                        [NameInMap("modifierEmpId")]
                        [Validation(Required=false)]
                        public string ModifierEmpId { get; set; }

                        [NameInMap("name")]
                        [Validation(Required=false)]
                        public string Name { get; set; }

                        [NameInMap("nickNameEn")]
                        [Validation(Required=false)]
                        public string NickNameEn { get; set; }

                        [NameInMap("realmId")]
                        [Validation(Required=false)]
                        public long? RealmId { get; set; }

                        [NameInMap("workid")]
                        [Validation(Required=false)]
                        public string Workid { get; set; }

                    }

                }

                [NameInMap("purchasePackCode")]
                [Validation(Required=false)]
                public int? PurchasePackCode { get; set; }

                [NameInMap("serviceApplyId")]
                [Validation(Required=false)]
                public long? ServiceApplyId { get; set; }

                [NameInMap("serviceMonthReports")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersServiceMonthReports> ServiceMonthReports { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersServiceMonthReports : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("serviceReports")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersServiceReports> ServiceReports { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersServiceReports : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("serviceSchemes")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersServiceSchemes> ServiceSchemes { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersServiceSchemes : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("statusStr")]
                [Validation(Required=false)]
                public string StatusStr { get; set; }

                [NameInMap("supportTime")]
                [Validation(Required=false)]
                public List<long?> SupportTime { get; set; }

                [NameInMap("tamEngineers")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformanceOrdersTamEngineers> TamEngineers { get; set; }
                public class GetServiceDetailResponseBodyDataPerformanceOrdersTamEngineers : TeaModel {
                    [NameInMap("creatorEmpId")]
                    [Validation(Required=false)]
                    public string CreatorEmpId { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("hrStatus")]
                    [Validation(Required=false)]
                    public string HrStatus { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("lastName")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    [NameInMap("modifierEmpId")]
                    [Validation(Required=false)]
                    public string ModifierEmpId { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nickNameEn")]
                    [Validation(Required=false)]
                    public string NickNameEn { get; set; }

                    [NameInMap("realmId")]
                    [Validation(Required=false)]
                    public long? RealmId { get; set; }

                    [NameInMap("workid")]
                    [Validation(Required=false)]
                    public string Workid { get; set; }

                }

            }

            [NameInMap("performancePacks")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataPerformancePacks> PerformancePacks { get; set; }
            public class GetServiceDetailResponseBodyDataPerformancePacks : TeaModel {
                [NameInMap("applyFileVOList")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformancePacksApplyFileVOList> ApplyFileVOList { get; set; }
                public class GetServiceDetailResponseBodyDataPerformancePacksApplyFileVOList : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("appointmentCode")]
                [Validation(Required=false)]
                public string AppointmentCode { get; set; }

                [NameInMap("appointmentEndTime")]
                [Validation(Required=false)]
                public long? AppointmentEndTime { get; set; }

                [NameInMap("appointmentId")]
                [Validation(Required=false)]
                public string AppointmentId { get; set; }

                [NameInMap("appointmentPassTime")]
                [Validation(Required=false)]
                public long? AppointmentPassTime { get; set; }

                [NameInMap("appointmentTime")]
                [Validation(Required=false)]
                public long? AppointmentTime { get; set; }

                [NameInMap("commodityDesc")]
                [Validation(Required=false)]
                public string CommodityDesc { get; set; }

                [NameInMap("creatorEmpId")]
                [Validation(Required=false)]
                public string CreatorEmpId { get; set; }

                [NameInMap("cycleService")]
                [Validation(Required=false)]
                public bool? CycleService { get; set; }

                [NameInMap("extList")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformancePacksExtList> ExtList { get; set; }
                public class GetServiceDetailResponseBodyDataPerformancePacksExtList : TeaModel {
                    [NameInMap("keyCode")]
                    [Validation(Required=false)]
                    public string KeyCode { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("value")]
                    [Validation(Required=false)]
                    public object Value { get; set; }

                    [NameInMap("view")]
                    [Validation(Required=false)]
                    public string View { get; set; }

                }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("mergeSolutionAndReporterOneStep")]
                [Validation(Required=false)]
                public bool? MergeSolutionAndReporterOneStep { get; set; }

                [NameInMap("modifierEmpId")]
                [Validation(Required=false)]
                public string ModifierEmpId { get; set; }

                [NameInMap("orderDetail")]
                [Validation(Required=false)]
                public object OrderDetail { get; set; }

                [NameInMap("orderId")]
                [Validation(Required=false)]
                public long? OrderId { get; set; }

                [NameInMap("performanceNodeDTOS")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformancePacksPerformanceNodeDTOS> PerformanceNodeDTOS { get; set; }
                public class GetServiceDetailResponseBodyDataPerformancePacksPerformanceNodeDTOS : TeaModel {
                    [NameInMap("display")]
                    [Validation(Required=false)]
                    public bool? Display { get; set; }

                    [NameInMap("extendInfo")]
                    [Validation(Required=false)]
                    public object ExtendInfo { get; set; }

                    [NameInMap("index")]
                    [Validation(Required=false)]
                    public int? Index { get; set; }

                    [NameInMap("nodeName")]
                    [Validation(Required=false)]
                    public string NodeName { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                }

                [NameInMap("purchasePackCode")]
                [Validation(Required=false)]
                public int? PurchasePackCode { get; set; }

                [NameInMap("serviceApplyId")]
                [Validation(Required=false)]
                public long? ServiceApplyId { get; set; }

                [NameInMap("serviceMonthReports")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformancePacksServiceMonthReports> ServiceMonthReports { get; set; }
                public class GetServiceDetailResponseBodyDataPerformancePacksServiceMonthReports : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("serviceReports")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformancePacksServiceReports> ServiceReports { get; set; }
                public class GetServiceDetailResponseBodyDataPerformancePacksServiceReports : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("serviceSchemes")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformancePacksServiceSchemes> ServiceSchemes { get; set; }
                public class GetServiceDetailResponseBodyDataPerformancePacksServiceSchemes : TeaModel {
                    [NameInMap("appointmentId")]
                    [Validation(Required=false)]
                    public string AppointmentId { get; set; }

                    [NameInMap("batchGroup")]
                    [Validation(Required=false)]
                    public string BatchGroup { get; set; }

                    [NameInMap("customerId")]
                    [Validation(Required=false)]
                    public string CustomerId { get; set; }

                    [NameInMap("fileName")]
                    [Validation(Required=false)]
                    public string FileName { get; set; }

                    [NameInMap("fileType")]
                    [Validation(Required=false)]
                    public int? FileType { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("remarke")]
                    [Validation(Required=false)]
                    public string Remarke { get; set; }

                    [NameInMap("serviceApplyId")]
                    [Validation(Required=false)]
                    public long? ServiceApplyId { get; set; }

                    [NameInMap("status")]
                    [Validation(Required=false)]
                    public int? Status { get; set; }

                    [NameInMap("url")]
                    [Validation(Required=false)]
                    public string Url { get; set; }

                }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("statusStr")]
                [Validation(Required=false)]
                public string StatusStr { get; set; }

                [NameInMap("supportTime")]
                [Validation(Required=false)]
                public List<long?> SupportTime { get; set; }

                [NameInMap("tamEngineers")]
                [Validation(Required=false)]
                public List<GetServiceDetailResponseBodyDataPerformancePacksTamEngineers> TamEngineers { get; set; }
                public class GetServiceDetailResponseBodyDataPerformancePacksTamEngineers : TeaModel {
                    [NameInMap("creatorEmpId")]
                    [Validation(Required=false)]
                    public string CreatorEmpId { get; set; }

                    [NameInMap("gmtCreate")]
                    [Validation(Required=false)]
                    public string GmtCreate { get; set; }

                    [NameInMap("gmtModified")]
                    [Validation(Required=false)]
                    public string GmtModified { get; set; }

                    [NameInMap("hrStatus")]
                    [Validation(Required=false)]
                    public string HrStatus { get; set; }

                    [NameInMap("id")]
                    [Validation(Required=false)]
                    public long? Id { get; set; }

                    [NameInMap("lastName")]
                    [Validation(Required=false)]
                    public string LastName { get; set; }

                    [NameInMap("modifierEmpId")]
                    [Validation(Required=false)]
                    public string ModifierEmpId { get; set; }

                    [NameInMap("name")]
                    [Validation(Required=false)]
                    public string Name { get; set; }

                    [NameInMap("nickNameEn")]
                    [Validation(Required=false)]
                    public string NickNameEn { get; set; }

                    [NameInMap("realmId")]
                    [Validation(Required=false)]
                    public long? RealmId { get; set; }

                    [NameInMap("workid")]
                    [Validation(Required=false)]
                    public string Workid { get; set; }

                }

            }

            [NameInMap("reneWalUrl")]
            [Validation(Required=false)]
            public string ReneWalUrl { get; set; }

            [NameInMap("serviceCode")]
            [Validation(Required=false)]
            public string ServiceCode { get; set; }

            [NameInMap("serviceName")]
            [Validation(Required=false)]
            public string ServiceName { get; set; }

            [NameInMap("serviceReports")]
            [Validation(Required=false)]
            public List<GetServiceDetailResponseBodyDataServiceReports> ServiceReports { get; set; }
            public class GetServiceDetailResponseBodyDataServiceReports : TeaModel {
                [NameInMap("appointmentId")]
                [Validation(Required=false)]
                public string AppointmentId { get; set; }

                [NameInMap("batchGroup")]
                [Validation(Required=false)]
                public string BatchGroup { get; set; }

                [NameInMap("customerId")]
                [Validation(Required=false)]
                public string CustomerId { get; set; }

                [NameInMap("fileName")]
                [Validation(Required=false)]
                public string FileName { get; set; }

                [NameInMap("fileType")]
                [Validation(Required=false)]
                public int? FileType { get; set; }

                [NameInMap("gmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                [NameInMap("gmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                [NameInMap("id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                [NameInMap("remarke")]
                [Validation(Required=false)]
                public string Remarke { get; set; }

                [NameInMap("serviceApplyId")]
                [Validation(Required=false)]
                public long? ServiceApplyId { get; set; }

                [NameInMap("status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

                [NameInMap("url")]
                [Validation(Required=false)]
                public string Url { get; set; }

            }

            [NameInMap("serviceTimeRange")]
            [Validation(Required=false)]
            public List<long?> ServiceTimeRange { get; set; }

            [NameInMap("status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            [NameInMap("statusCode")]
            [Validation(Required=false)]
            public int? StatusCode { get; set; }

            [NameInMap("statusStr")]
            [Validation(Required=false)]
            public string StatusStr { get; set; }

            [NameInMap("termOfValidity")]
            [Validation(Required=false)]
            public string TermOfValidity { get; set; }

            [NameInMap("totalPack")]
            [Validation(Required=false)]
            public int? TotalPack { get; set; }

            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            [NameInMap("usePack")]
            [Validation(Required=false)]
            public long? UsePack { get; set; }

        }

        [NameInMap("httpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
