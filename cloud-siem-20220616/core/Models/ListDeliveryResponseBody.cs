// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class ListDeliveryResponseBody : TeaModel {
        [NameInMap("Code")]
        [Validation(Required=false)]
        public int? Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListDeliveryResponseBodyData Data { get; set; }
        public class ListDeliveryResponseBodyData : TeaModel {
            [NameInMap("DashboardUrl")]
            [Validation(Required=false)]
            public string DashboardUrl { get; set; }

            [NameInMap("DisplaySwitchOrNot")]
            [Validation(Required=false)]
            public bool? DisplaySwitchOrNot { get; set; }

            [NameInMap("LogStoreName")]
            [Validation(Required=false)]
            public string LogStoreName { get; set; }

            [NameInMap("ProductList")]
            [Validation(Required=false)]
            public List<ListDeliveryResponseBodyDataProductList> ProductList { get; set; }
            public class ListDeliveryResponseBodyDataProductList : TeaModel {
                [NameInMap("LogList")]
                [Validation(Required=false)]
                public List<ListDeliveryResponseBodyDataProductListLogList> LogList { get; set; }
                public class ListDeliveryResponseBodyDataProductListLogList : TeaModel {
                    [NameInMap("CanOperateOrNot")]
                    [Validation(Required=false)]
                    public bool? CanOperateOrNot { get; set; }

                    [NameInMap("ExtraParameters")]
                    [Validation(Required=false)]
                    public List<ListDeliveryResponseBodyDataProductListLogListExtraParameters> ExtraParameters { get; set; }
                    public class ListDeliveryResponseBodyDataProductListLogListExtraParameters : TeaModel {
                        [NameInMap("Key")]
                        [Validation(Required=false)]
                        public string Key { get; set; }

                        [NameInMap("Value")]
                        [Validation(Required=false)]
                        public string Value { get; set; }

                    }

                    [NameInMap("LogCode")]
                    [Validation(Required=false)]
                    public string LogCode { get; set; }

                    [NameInMap("LogName")]
                    [Validation(Required=false)]
                    public string LogName { get; set; }

                    [NameInMap("LogNameEn")]
                    [Validation(Required=false)]
                    public string LogNameEn { get; set; }

                    [NameInMap("LogNameKey")]
                    [Validation(Required=false)]
                    public string LogNameKey { get; set; }

                    [NameInMap("Status")]
                    [Validation(Required=false)]
                    public bool? Status { get; set; }

                    [NameInMap("Topic")]
                    [Validation(Required=false)]
                    public string Topic { get; set; }

                }

                [NameInMap("LogMap")]
                [Validation(Required=false)]
                public Dictionary<string, List<DataProductListLogMapValue>> LogMap { get; set; }

                [NameInMap("ProductCode")]
                [Validation(Required=false)]
                public string ProductCode { get; set; }

                [NameInMap("ProductName")]
                [Validation(Required=false)]
                public string ProductName { get; set; }

            }

            [NameInMap("ProjectName")]
            [Validation(Required=false)]
            public string ProjectName { get; set; }

            [NameInMap("SearchUrl")]
            [Validation(Required=false)]
            public string SearchUrl { get; set; }

        }

        [NameInMap("DyCode")]
        [Validation(Required=false)]
        public string DyCode { get; set; }

        [NameInMap("DyMessage")]
        [Validation(Required=false)]
        public string DyMessage { get; set; }

        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
