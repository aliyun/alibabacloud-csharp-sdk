// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class QueryWorksBloodRelationshipResponseBody : TeaModel {
        /// <summary>
        /// <para>Indicates whether the request is successful. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful.</description></item>
        /// <item><description>false: The request failed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>D787E1A3-A93C-424A-B626-C2B05DF8D885</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<QueryWorksBloodRelationshipResponseBodyResult> Result { get; set; }
        public class QueryWorksBloodRelationshipResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>List of work blood information.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0696083a-ca72-4d89-8e7a-c017910e0***</para>
            /// </summary>
            [NameInMap("ComponentId")]
            [Validation(Required=false)]
            public string ComponentId { get; set; }

            /// <summary>
            /// <para>The ID of the component that you want to modify.</para>
            /// 
            /// <b>Example:</b>
            /// <para>The name of the component.</para>
            /// </summary>
            [NameInMap("ComponentName")]
            [Validation(Required=false)]
            public string ComponentName { get; set; }

            /// <summary>
            /// <para>Line</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("ComponentType")]
            [Validation(Required=false)]
            public int? ComponentType { get; set; }

            [NameInMap("ComponentTypeCnName")]
            [Validation(Required=false)]
            public string ComponentTypeCnName { get; set; }

            /// <summary>
            /// <para>The type of the image component.</para>
            /// 
            /// <b>Example:</b>
            /// <para>LINE</para>
            /// </summary>
            [NameInMap("ComponentTypeName")]
            [Validation(Required=false)]
            public string ComponentTypeName { get; set; }

            /// <summary>
            /// <para>Column (Measure)</para>
            /// 
            /// <b>Example:</b>
            /// <para>dc78a4ed-880d-452e-b017-90cfc10c83e5_company_sales_record</para>
            /// </summary>
            [NameInMap("DatasetId")]
            [Validation(Required=false)]
            public string DatasetId { get; set; }

            /// <summary>
            /// <para>The name of the component type.</para>
            /// </summary>
            [NameInMap("QueryParams")]
            [Validation(Required=false)]
            public List<QueryWorksBloodRelationshipResponseBodyResultQueryParams> QueryParams { get; set; }
            public class QueryWorksBloodRelationshipResponseBodyResultQueryParams : TeaModel {
                /// <summary>
                /// <para>Indices whether the metric. Valid values:</para>
                /// <para>true false</para>
                /// 
                /// <b>Example:</b>
                /// <para>area_column</para>
                /// </summary>
                [NameInMap("AreaId")]
                [Validation(Required=false)]
                public string AreaId { get; set; }

                /// <summary>
                /// <para>The ID of the owning location.</para>
                /// 
                /// <b>Example:</b>
                /// <para>The name of the owning location.</para>
                /// </summary>
                [NameInMap("AreaName")]
                [Validation(Required=false)]
                public string AreaName { get; set; }

                /// <summary>
                /// <para>The globally unique PathId.</para>
                /// 
                /// <b>Example:</b>
                /// <para>order_number</para>
                /// </summary>
                [NameInMap("Caption")]
                [Validation(Required=false)]
                public string Caption { get; set; }

                /// <summary>
                /// <para>The display name of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>number</para>
                /// </summary>
                [NameInMap("DataType")]
                [Validation(Required=false)]
                public string DataType { get; set; }

                [NameInMap("Expression")]
                [Validation(Required=false)]
                public string Expression { get; set; }

                /// <summary>
                /// <para>The type of the field. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>string: string type</description></item>
                /// <item><description>date: a date type that contains only the year, month, and day parts</description></item>
                /// <item><description>datetime: a common date type</description></item>
                /// <item><description>time: a date type that contains only hours, minutes, and seconds.</description></item>
                /// <item><description>number: numeric</description></item>
                /// <item><description>boolean: Boolean type</description></item>
                /// <item><description>geographical: geographical location</description></item>
                /// <item><description>url: string type</description></item>
                /// <item><description>imageUrl: the type of the image link.</description></item>
                /// <item><description>multivalue: a multi-value column</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsMeasure")]
                [Validation(Required=false)]
                public bool? IsMeasure { get; set; }

                /// <summary>
                /// <para>The unique ID of the field.</para>
                /// 
                /// <b>Example:</b>
                /// <para>schema7d1944eb-443e-48c6-8123-bf45a99e7e74.dc78a4ed-880d-452e-b017-90cfc10c83e5_company_sales_record.[Ndc78a4_order_level].[Ndc78a4_order_level].[Ndc78a4_order_level]</para>
                /// </summary>
                [NameInMap("PathId")]
                [Validation(Required=false)]
                public string PathId { get; set; }

                /// <summary>
                /// <para>A list of query parameter reference columns.</para>
                /// 
                /// <b>Example:</b>
                /// <para>Ndc78a4_order_number</para>
                /// </summary>
                [NameInMap("Uid")]
                [Validation(Required=false)]
                public string Uid { get; set; }

            }

        }

        /// <summary>
        /// <para>The response.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
