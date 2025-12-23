// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.OpenSearch20171225.Models
{
    public class ListDataCollectionsResponseBody : TeaModel {
        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>959D8782-B130-95EB-86CC-1F6ED447981F</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The details of the data collection task.</para>
        /// <para>For more information, see <a href="https://help.aliyun.com/document_detail/173605.html">DataCollection</a>.</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public List<ListDataCollectionsResponseBodyResult> Result { get; set; }
        public class ListDataCollectionsResponseBodyResult : TeaModel {
            /// <summary>
            /// <para>The time when the task was created.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1581065837</para>
            /// </summary>
            [NameInMap("created")]
            [Validation(Required=false)]
            public int? Created { get; set; }

            /// <summary>
            /// <para>The type of data collected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>behavior: behavioral data.</description></item>
            /// <item><description>item_info: project information.</description></item>
            /// <item><description>industry_specific: industry-specific data.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BEHAVIOR</para>
            /// </summary>
            [NameInMap("dataCollectionType")]
            [Validation(Required=false)]
            public string DataCollectionType { get; set; }

            /// <summary>
            /// <para>The data collection ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>286</para>
            /// </summary>
            [NameInMap("id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            /// <summary>
            /// <para>The industry name. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>general</description></item>
            /// <item><description>ecommerce</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>GENERAL</para>
            /// </summary>
            [NameInMap("industryName")]
            [Validation(Required=false)]
            public string IndustryName { get; set; }

            /// <summary>
            /// <para>The name of the data collection task.</para>
            /// 
            /// <b>Example:</b>
            /// <para>os_function_test_v1</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The status of the data collection feature. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>0: The feature is disabled.</description></item>
            /// <item><description>1: The feature is being enabled.</description></item>
            /// <item><description>2: The feature is enabled.</description></item>
            /// <item><description>3: The feature failed to be enabled.</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>2</para>
            /// </summary>
            [NameInMap("status")]
            [Validation(Required=false)]
            public int? Status { get; set; }

            /// <summary>
            /// <para>The sundial ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1755</para>
            /// </summary>
            [NameInMap("sundialId")]
            [Validation(Required=false)]
            public string SundialId { get; set; }

            /// <summary>
            /// <para>The type of the source from which data was collected. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>server</description></item>
            /// <item><description>web</description></item>
            /// <item><description>app</description></item>
            /// </list>
            /// <para>Only server is supported.</para>
            /// 
            /// <b>Example:</b>
            /// <para>server</para>
            /// </summary>
            [NameInMap("type")]
            [Validation(Required=false)]
            public string Type { get; set; }

            /// <summary>
            /// <para>The time when the data collection task was updated.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1581065904</para>
            /// </summary>
            [NameInMap("updated")]
            [Validation(Required=false)]
            public int? Updated { get; set; }

        }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("totalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
