// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20190103.Models
{
    public class DescribeEventDetailResponseBody : TeaModel {
        [NameInMap("Event")]
        [Validation(Required=false)]
        public DescribeEventDetailResponseBodyEvent Event { get; set; }
        public class DescribeEventDetailResponseBodyEvent : TeaModel {
            [NameInMap("AlertTime")]
            [Validation(Required=false)]
            public long? AlertTime { get; set; }
            [NameInMap("Backed")]
            [Validation(Required=false)]
            public bool? Backed { get; set; }
            [NameInMap("DataInstance")]
            [Validation(Required=false)]
            public string DataInstance { get; set; }
            [NameInMap("DealDisplayName")]
            [Validation(Required=false)]
            public string DealDisplayName { get; set; }
            [NameInMap("DealLoginName")]
            [Validation(Required=false)]
            public string DealLoginName { get; set; }
            [NameInMap("DealReason")]
            [Validation(Required=false)]
            public string DealReason { get; set; }
            [NameInMap("DealTime")]
            [Validation(Required=false)]
            public long? DealTime { get; set; }
            [NameInMap("DealUserId")]
            [Validation(Required=false)]
            public long? DealUserId { get; set; }
            [NameInMap("Detail")]
            [Validation(Required=false)]
            public DescribeEventDetailResponseBodyEventDetail Detail { get; set; }
            public class DescribeEventDetailResponseBodyEventDetail : TeaModel {
                [NameInMap("Chart")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailChart> Chart { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailChart : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public DescribeEventDetailResponseBodyEventDetailChartData Data { get; set; }
                    public class DescribeEventDetailResponseBodyEventDetailChartData : TeaModel {
                        [NameInMap("X")]
                        [Validation(Required=false)]
                        public string X { get; set; }
                        [NameInMap("Y")]
                        [Validation(Required=false)]
                        public string Y { get; set; }
                    };

                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Type")]
                    [Validation(Required=false)]
                    public string Type { get; set; }

                    [NameInMap("XLabel")]
                    [Validation(Required=false)]
                    public string XLabel { get; set; }

                    [NameInMap("YLabel")]
                    [Validation(Required=false)]
                    public string YLabel { get; set; }

                }

                [NameInMap("Content")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailContent> Content { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailContent : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

                [NameInMap("ResourceInfo")]
                [Validation(Required=false)]
                public List<DescribeEventDetailResponseBodyEventDetailResourceInfo> ResourceInfo { get; set; }
                public class DescribeEventDetailResponseBodyEventDetailResourceInfo : TeaModel {
                    [NameInMap("Label")]
                    [Validation(Required=false)]
                    public string Label { get; set; }

                    [NameInMap("Value")]
                    [Validation(Required=false)]
                    public string Value { get; set; }

                }

            }
            [NameInMap("DisplayName")]
            [Validation(Required=false)]
            public string DisplayName { get; set; }
            [NameInMap("EventTime")]
            [Validation(Required=false)]
            public long? EventTime { get; set; }
            [NameInMap("HandleInfoList")]
            [Validation(Required=false)]
            public List<DescribeEventDetailResponseBodyEventHandleInfoList> HandleInfoList { get; set; }
            public class DescribeEventDetailResponseBodyEventHandleInfoList : TeaModel {
                public string CurrentValue { get; set; }
                public long? DisableTime { get; set; }
                public long? EnableTime { get; set; }
                public string HandlerName { get; set; }
                public string HandlerType { get; set; }
                public int? HandlerValue { get; set; }
                public long? Id { get; set; }
                public int? Status { get; set; }
            }
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }
            [NameInMap("LogDetail")]
            [Validation(Required=false)]
            public string LogDetail { get; set; }
            [NameInMap("LoginName")]
            [Validation(Required=false)]
            public string LoginName { get; set; }
            [NameInMap("ProductCode")]
            [Validation(Required=false)]
            public string ProductCode { get; set; }
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }
            [NameInMap("StatusName")]
            [Validation(Required=false)]
            public string StatusName { get; set; }
            [NameInMap("SubTypeCode")]
            [Validation(Required=false)]
            public string SubTypeCode { get; set; }
            [NameInMap("SubTypeName")]
            [Validation(Required=false)]
            public string SubTypeName { get; set; }
            [NameInMap("TypeCode")]
            [Validation(Required=false)]
            public string TypeCode { get; set; }
            [NameInMap("TypeName")]
            [Validation(Required=false)]
            public string TypeName { get; set; }
            [NameInMap("UserId")]
            [Validation(Required=false)]
            public long? UserId { get; set; }
        };

        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
