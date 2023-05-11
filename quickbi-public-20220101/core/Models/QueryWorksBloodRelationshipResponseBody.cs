// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksBloodRelationshipResponseBody : TeaModel {
        /// <summary>
        /// Indicates whether the request is successful. Valid values:
        /// 
        /// *   true: The request was successful.
        /// *   false: The request failed.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryWorksBloodRelationshipResponseBodyResult> Result { get; set; }
        public class QueryWorksBloodRelationshipResponseBodyResult : TeaModel {
            /// <summary>
            /// List of work blood information.
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// The ID of the component that you want to modify.
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// Line
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public int? ComponentType { get; set; }

            /// <summary>
            /// The type of the image component.
            /// </summary>
            [NameInMap("ComponentTypeName")]
            [Validation(Required=false)]
            public string ComponentTypeName { get; set; }

            /// <summary>
            /// Column (Measure)
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// The name of the component type.
            /// </summary>
            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public List<QueryWorksBloodRelationshipResponseBodyResultQueryParams> QueryParams { get; set; }
            public class QueryWorksBloodRelationshipResponseBodyResultQueryParams : TeaModel {
                /// <summary>
                /// Indices whether the metric. Valid values:
                /// 
                /// true false
                /// </summary>
                [NameInMap("AreaId")]
                [Validation(Required=false)]
                public string AreaId { get; set; }

                /// <summary>
                /// The ID of the owning location.
                /// </summary>
                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// The globally unique PathId.
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// The display name of the field.
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                /// <summary>
                /// The type of the field. Valid values:
                /// 
                /// *   string: string type
                /// *   date: a date type that contains only the year, month, and day parts
                /// *   datetime: a common date type
                /// *   time: a date type that contains only hours, minutes, and seconds.
                /// *   number: numeric
                /// *   boolean: Boolean type
                /// *   geographical: geographical location
                /// *   url: string type
                /// *   imageUrl: the type of the image link.
                /// *   multivalue: a multi-value column
                /// </summary>
                [NameInMap("IsMeasure")]
                [Validation(Required=false)]
                public bool? IsMeasure { get; set; }

                /// <summary>
                /// The unique ID of the field.
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// A list of query parameter reference columns.
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        /// <summary>
        /// The response.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
