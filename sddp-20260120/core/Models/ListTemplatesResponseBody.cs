// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sddp20260120.Models
{
    public class ListTemplatesResponseBody : TeaModel {
        /// <summary>
        /// <para>The page number of the returned data.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public int? CurrentPage { get; set; }

        /// <summary>
        /// <para>The list of records returned for the current query.</para>
        /// </summary>
        [NameInMap("Items")]
        [Validation(Required=false)]
        public List<ListTemplatesResponseBodyItems> Items { get; set; }
        public class ListTemplatesResponseBodyItems : TeaModel {
            /// <summary>
            /// <para>The current sensitivity level of the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("CurrentRiskLevel")]
            [Validation(Required=false)]
            public int? CurrentRiskLevel { get; set; }

            /// <summary>
            /// <para>The description of the classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Used to detect common sensitive data</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The creation time of the template. The value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788566400000</para>
            /// </summary>
            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public long? GmtCreate { get; set; }

            /// <summary>
            /// <para>The last modification time of the template. The value is a UNIX timestamp in milliseconds since 1970-01-01 00:00:00 UTC.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1788566400000</para>
            /// </summary>
            [NameInMap("GmtModified")]
            [Validation(Required=false)]
            public long? GmtModified { get; set; }

            /// <summary>
            /// <para>The identifier of the classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Id")]
            [Validation(Required=false)]
            public long? Id { get; set; }

            /// <summary>
            /// <para>The maximum classification level supported by the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>3</para>
            /// </summary>
            [NameInMap("MaxCategoryLevel")]
            [Validation(Required=false)]
            public int? MaxCategoryLevel { get; set; }

            /// <summary>
            /// <para>The highest sensitivity level supported by the template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("MaxRiskLevel")]
            [Validation(Required=false)]
            public int? MaxRiskLevel { get; set; }

            /// <summary>
            /// <para>The name of the classification and grading template.</para>
            /// 
            /// <b>Example:</b>
            /// <para>General classification and grading template</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the template. Valid values: 0: Disabled. 1: Enabled primary template. 2: Active template. 3: General detection model.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>Specifies whether the template can be edited. Valid values: 0: Not supported. 1: Supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("SupportEdit")]
            [Validation(Required=false)]
            public int? SupportEdit { get; set; }

            /// <summary>
            /// <para>The category of the template. Valid values: 1: Alibaba Cloud template. 2: Finance template. 3: Energy template. 4: Personal information security template. 5: Travel template. 65: General template. 66: Custom template. 67: Template from other cloud services.</para>
            /// 
            /// <b>Example:</b>
            /// <para>65</para>
            /// </summary>
            [NameInMap("Type")]
            [Validation(Required=false)]
            public int? Type { get; set; }

        }

        /// <summary>
        /// <para>The number of records per page for the current query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID, which can be used to trace the current API call.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7C6D8E9F-1234-5678-ABCD-0123456789AB</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of records that match the current query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
