// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dataworks_public20200518.Models
{
    public class DsgDesensPlanQueryListResponseBody : TeaModel {
        /// <summary>
        /// The error code.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// The pagination information.
        /// </summary>
        [NameInMap("PageData")]
        [Validation(Required=false)]
        public DsgDesensPlanQueryListResponseBodyPageData PageData { get; set; }
        public class DsgDesensPlanQueryListResponseBodyPageData : TeaModel {
            /// <summary>
            /// The information about the data masking rule.
            /// </summary>
            [NameInMap("Data")]
            [Validation(Required=false)]
            public List<DsgDesensPlanQueryListResponseBodyPageDataData> Data { get; set; }
            public class DsgDesensPlanQueryListResponseBodyPageDataData : TeaModel {
                /// <summary>
                /// Indicates whether a watermark is added. Valid values:
                /// 
                /// *   true
                /// *   false
                /// </summary>
                [NameInMap("CheckWatermark")]
                [Validation(Required=false)]
                public bool? CheckWatermark { get; set; }

                /// <summary>
                /// The sensitive field type.
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// The type of the data masking method.
                /// </summary>
                [NameInMap("DesenMode")]
                [Validation(Required=false)]
                public string DesenMode { get; set; }

                /// <summary>
                /// The details of the data masking rule.
                /// </summary>
                [NameInMap("DesensPlan")]
                [Validation(Required=false)]
                public DsgDesensPlanQueryListResponseBodyPageDataDataDesensPlan DesensPlan { get; set; }
                public class DsgDesensPlanQueryListResponseBodyPageDataDataDesensPlan : TeaModel {
                    /// <summary>
                    /// The type of the data masking rule.
                    /// </summary>
                    [NameInMap("DesensPlanType")]
                    [Validation(Required=false)]
                    public string DesensPlanType { get; set; }

                    /// <summary>
                    /// The parameters for the data masking rule. For more information about the parameters, see the [DsgDesensPlanAddOrUpdate](https://help.aliyun.com/document_detail/2786295.html) API reference.
                    /// </summary>
                    [NameInMap("ExtParam")]
                    [Validation(Required=false)]
                    public Dictionary<string, object> ExtParam { get; set; }

                }

                /// <summary>
                /// The data masking rule.
                /// </summary>
                [NameInMap("DesensRule")]
                [Validation(Required=false)]
                public string DesensRule { get; set; }

                /// <summary>
                /// The data masking method.
                /// </summary>
                [NameInMap("DesensWay")]
                [Validation(Required=false)]
                public string DesensWay { get; set; }

                /// <summary>
                /// The time when the data masking rule was created.
                /// </summary>
                [NameInMap("GmtCreate")]
                [Validation(Required=false)]
                public string GmtCreate { get; set; }

                /// <summary>
                /// The time when the data masking rule was modified.
                /// </summary>
                [NameInMap("GmtModified")]
                [Validation(Required=false)]
                public string GmtModified { get; set; }

                /// <summary>
                /// The ID of the data masking rule.
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public long? Id { get; set; }

                /// <summary>
                /// The owner of the data masking rule.
                /// </summary>
                [NameInMap("Owner")]
                [Validation(Required=false)]
                public string Owner { get; set; }

                /// <summary>
                /// The name of the data masking rule.
                /// </summary>
                [NameInMap("RuleName")]
                [Validation(Required=false)]
                public string RuleName { get; set; }

                /// <summary>
                /// The code of the level-1 data masking scenario to which the rule belongs. Valid values:
                /// 
                /// *   dataworks_display_desense_code: masking of displayed data in DataStudio and Data Map
                /// *   maxcompute_desense_code: data masking at the MaxCompute compute engine layer
                /// *   maxcompute_new_desense_code: data masking at the MaxCompute compute engine layer (new)
                /// *   hologres_display_desense_code: data masking at the Hologres compute engine layer
                /// *   dataworks_data_integration_desense_code: static data masking in Data Integration
                /// *   dataworks_analysis_desense_code: masking of displayed data in DataAnalysis
                /// </summary>
                [NameInMap("SceneCode")]
                [Validation(Required=false)]
                public string SceneCode { get; set; }

                /// <summary>
                /// The name of the level-2 data masking scenario to which the data masking rule belongs.
                /// </summary>
                [NameInMap("SceneName")]
                [Validation(Required=false)]
                public string SceneName { get; set; }

                /// <summary>
                /// The status of the data masking rule. Valid values:
                /// 
                /// *   0: expired
                /// *   1: effective
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public int? Status { get; set; }

            }

            /// <summary>
            /// The page number.
            /// </summary>
            [NameInMap("PageNumber")]
            [Validation(Required=false)]
            public int? PageNumber { get; set; }

            /// <summary>
            /// The number of entries per page. Maximum value: 100.
            /// </summary>
            [NameInMap("PageSize")]
            [Validation(Required=false)]
            public int? PageSize { get; set; }

            /// <summary>
            /// The number of data masking rules.
            /// </summary>
            [NameInMap("TotalCount")]
            [Validation(Required=false)]
            public int? TotalCount { get; set; }

        }

        /// <summary>
        /// The request ID. You can use the ID to locate logs and troubleshoot issues.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful. Valid values:
        /// 
        /// *   true
        /// *   false
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
