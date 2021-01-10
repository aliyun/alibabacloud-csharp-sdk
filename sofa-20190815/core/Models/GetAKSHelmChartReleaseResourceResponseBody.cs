// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.SOFA20190815.Models
{
    public class GetAKSHelmChartReleaseResourceResponseBody : TeaModel {
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("ResultCode")]
        [Validation(Required=false)]
        public string ResultCode { get; set; }

        [NameInMap("ResultMessage")]
        [Validation(Required=false)]
        public string ResultMessage { get; set; }

        [NameInMap("ChartResourceStatuses")]
        [Validation(Required=false)]
        public List<GetAKSHelmChartReleaseResourceResponseBodyChartResourceStatuses> ChartResourceStatuses { get; set; }
        public class GetAKSHelmChartReleaseResourceResponseBodyChartResourceStatuses : TeaModel {
            [NameInMap("ChartName")]
            [Validation(Required=false)]
            public string ChartName { get; set; }

            [NameInMap("ChartVersion")]
            [Validation(Required=false)]
            public string ChartVersion { get; set; }

            [NameInMap("ChartResourceItems")]
            [Validation(Required=false)]
            public List<GetAKSHelmChartReleaseResourceResponseBodyChartResourceStatusesChartResourceItems> ChartResourceItems { get; set; }
            public class GetAKSHelmChartReleaseResourceResponseBodyChartResourceStatusesChartResourceItems : TeaModel {
                [NameInMap("ResourceType")]
                [Validation(Required=false)]
                public string ResourceType { get; set; }

                [NameInMap("ColumnList")]
                [Validation(Required=false)]
                public List<string> ColumnList { get; set; }

                [NameInMap("DataList")]
                [Validation(Required=false)]
                public List<GetAKSHelmChartReleaseResourceResponseBodyChartResourceStatusesChartResourceItemsDataList> DataList { get; set; }
                public class GetAKSHelmChartReleaseResourceResponseBodyChartResourceStatusesChartResourceItemsDataList : TeaModel {
                    [NameInMap("Data")]
                    [Validation(Required=false)]
                    public List<string> Data { get; set; }

                }

            }

        }

    }

}
