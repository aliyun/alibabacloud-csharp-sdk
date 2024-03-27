// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cloud_siem20220616.Models
{
    public class DescribeDataSourceParametersResponseBody : TeaModel {
        /// <summary>
        /// The data returned.
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<DescribeDataSourceParametersResponseBodyData> Data { get; set; }
        public class DescribeDataSourceParametersResponseBodyData : TeaModel {
            /// <summary>
            /// Indicates whether the edit operation is supported. Valid values:
            /// 
            /// *   **0**
            /// *   **1**
            /// </summary>
            [NameInMap("CanEditted")]
            [Validation(Required=false)]
            public int? CanEditted { get; set; }

            /// <summary>
            /// The code of the cloud service provider. Valid values:
            /// 
            /// *   **qcloud**: Tencent Cloud
            /// *   **aliyun**: Alibaba Cloud
            /// *   **hcloud**: Huawei Cloud
            /// </summary>
            [NameInMap("CloudCode")]
            [Validation(Required=false)]
            public string CloudCode { get; set; }

            /// <summary>
            /// The type of the data source. Valid values:
            /// 
            /// *   **obs**: Huawei Cloud Object Storage Service (OBS)
            /// *   **wafApi**: download API of Tencent Cloud Web Application Firewall (WAF)
            /// *   **ckafka**: Tencent Cloud TDMQ for CKafka
            /// </summary>
            [NameInMap("DataSourceType")]
            [Validation(Required=false)]
            public string DataSourceType { get; set; }

            /// <summary>
            /// The default value of the parameter.
            /// </summary>
            [NameInMap("DefaultValue")]
            [Validation(Required=false)]
            public string DefaultValue { get; set; }

            /// <summary>
            /// Indicates whether the modification operation is forbidden. Valid values:
            /// 
            /// *   **true**
            /// *   **false**
            /// </summary>
            [NameInMap("Disabled")]
            [Validation(Required=false)]
            public bool? Disabled { get; set; }

            /// <summary>
            /// The method that is used to check the parameter format.
            /// </summary>
            [NameInMap("FormatCheck")]
            [Validation(Required=false)]
            public string FormatCheck { get; set; }

            /// <summary>
            /// The additional information.
            /// </summary>
            [NameInMap("Hit")]
            [Validation(Required=false)]
            public string Hit { get; set; }

            /// <summary>
            /// The code of the parameter.
            /// </summary>
            [NameInMap("ParaCode")]
            [Validation(Required=false)]
            public string ParaCode { get; set; }

            /// <summary>
            /// The parameter level. Valid values:
            /// 
            /// *   **1**: the parameters of the data source
            /// *   **2**: the parameters of the log
            /// </summary>
            [NameInMap("ParaLevel")]
            [Validation(Required=false)]
            public int? ParaLevel { get; set; }

            /// <summary>
            /// The name of the parameter.
            /// </summary>
            [NameInMap("ParaName")]
            [Validation(Required=false)]
            public string ParaName { get; set; }

            /// <summary>
            /// The data type of the parameter.
            /// </summary>
            [NameInMap("ParaType")]
            [Validation(Required=false)]
            public string ParaType { get; set; }

            /// <summary>
            /// The value of the parameter.
            /// </summary>
            [NameInMap("ParamValue")]
            [Validation(Required=false)]
            public List<DescribeDataSourceParametersResponseBodyDataParamValue> ParamValue { get; set; }
            public class DescribeDataSourceParametersResponseBodyDataParamValue : TeaModel {
                /// <summary>
                /// The display value.
                /// </summary>
                [NameInMap("Label")]
                [Validation(Required=false)]
                public string Label { get; set; }

                /// <summary>
                /// The actual value.
                /// </summary>
                [NameInMap("Value")]
                [Validation(Required=false)]
                public string Value { get; set; }

            }

            /// <summary>
            /// Indicates whether the parameter is required. Valid values:
            /// 
            /// *   **1**: required
            /// *   **0**: optional
            /// </summary>
            [NameInMap("Required")]
            [Validation(Required=false)]
            public int? Required { get; set; }

            /// <summary>
            /// The note for the parameter value.
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
