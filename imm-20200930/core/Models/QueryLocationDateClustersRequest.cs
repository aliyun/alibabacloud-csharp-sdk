// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QueryLocationDateClustersRequest : TeaModel {
        /// <summary>
        /// <para>The address information.</para>
        /// </summary>
        [NameInMap("Address")]
        [Validation(Required=false)]
        public Address Address { get; set; }

        /// <summary>
        /// <para>The time range during which the spatiotemporal clusters were generated.</para>
        /// </summary>
        [NameInMap("CreateTimeRange")]
        [Validation(Required=false)]
        public TimeRange CreateTimeRange { get; set; }

        /// <summary>
        /// <para>The custom labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key=value</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset. For information about how to create a dataset, see <a href="https://help.aliyun.com/document_detail/478160.html">CreateDataset</a>.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The time range during which the latest photo in a cluster was taken.</para>
        /// </summary>
        [NameInMap("LocationDateClusterEndTimeRange")]
        [Validation(Required=false)]
        public TimeRange LocationDateClusterEndTimeRange { get; set; }

        /// <summary>
        /// <para>The container for the administrative division level of the spatiotemporal clusters to be queried.</para>
        /// </summary>
        [NameInMap("LocationDateClusterLevels")]
        [Validation(Required=false)]
        public List<string> LocationDateClusterLevels { get; set; }

        /// <summary>
        /// <para>The time range during which the earliest photo in a cluster was taken.</para>
        /// </summary>
        [NameInMap("LocationDateClusterStartTimeRange")]
        [Validation(Required=false)]
        public TimeRange LocationDateClusterStartTimeRange { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: [1,100]. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token.</para>
        /// 
        /// <b>Example:</b>
        /// <para>MzQNjmY2MzYxNhNjk2ZNjEu****</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The ID of the cluster that you want to query. Specify this parameter if you want to query a specific spatiotemporal cluster. Otherwise, leave this parameter empty to query spatiotemporal clusters that meet the specified conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>location-date-cluster-71dd4f32-9597-4085-a2ab-3a7b0fd0aff9</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The order that you use to sort the query results.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: ascending order. This is the default value.</description></item>
        /// <item><description>desc: descending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>asc</para>
        /// </summary>
        [NameInMap("Order")]
        [Validation(Required=false)]
        public string Order { get; set; }

        /// <summary>
        /// <para>The name of the project. You can obtain the name of the project from the response of the <a href="https://help.aliyun.com/document_detail/478153.html">CreateProject</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-project</para>
        /// </summary>
        [NameInMap("ProjectName")]
        [Validation(Required=false)]
        public string ProjectName { get; set; }

        /// <summary>
        /// <para>The field that you use to sort the query results.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>LocationDateClusterEndTime: by the time at which the latest photo in a cluster was taken.</description></item>
        /// <item><description>CreateTime: by the creation time of a spatiotemporal cluster.</description></item>
        /// <item><description>UpdateTime: by the update time of a spatiotemporal cluster.</description></item>
        /// <item><description>LocationDateClusterStartTime: by the time at which the earliest photo in a cluster was taken. This is the default value.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>LocationDateClusterStartTime</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The characters that are included in the titles of spatiotemporal clusters to be queried. Matches are found by using fuzzy matching.</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The time range during which the spatiotemporal clusters were updated.</para>
        /// </summary>
        [NameInMap("UpdateTimeRange")]
        [Validation(Required=false)]
        public TimeRange UpdateTimeRange { get; set; }

    }

}
