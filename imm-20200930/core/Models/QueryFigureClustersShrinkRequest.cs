// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class QueryFigureClustersShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The time range within which the face group was created.</para>
        /// </summary>
        [NameInMap("CreateTimeRange")]
        [Validation(Required=false)]
        public string CreateTimeRangeShrink { get; set; }

        /// <summary>
        /// <para>The custom labels, which can be used as query conditions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>key=value</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public string CustomLabels { get; set; }

        /// <summary>
        /// <para>The name of the dataset. You can obtain the name of the dataset from the response of the <a href="https://help.aliyun.com/document_detail/478160.html">CreateDataset</a> operation.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test-dataset</para>
        /// </summary>
        [NameInMap("DatasetName")]
        [Validation(Required=false)]
        public string DatasetName { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return. Valid values: 0 to 100. Default value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public long? MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results. You do not need to specify this parameter for the first request. You must specify the token that is obtained from the previous query as the value of NextToken.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The sort order. Default value: asc.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>asc: ascending order.</description></item>
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
        /// <para>The sort field. If you leave this parameter empty, the group ID is used as the sort field.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>ImageCount: the number of images.</description></item>
        /// <item><description>VideoCount: the number of videos.</description></item>
        /// <item><description>ProjectName: the name of the project.</description></item>
        /// <item><description>DatasetName: the name of the dataset.</description></item>
        /// <item><description>CreateTime: the point in time when the group is created.</description></item>
        /// <item><description>UpdateTime: the most recent point in time when the group is updated.</description></item>
        /// <item><description>Gender: the gender.</description></item>
        /// <item><description>FaceCount: the number of faces.</description></item>
        /// <item><description>GroupName: the name of the group.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>ImageCount</para>
        /// </summary>
        [NameInMap("Sort")]
        [Validation(Required=false)]
        public string Sort { get; set; }

        /// <summary>
        /// <para>The time range within which the face group was last updated.</para>
        /// </summary>
        [NameInMap("UpdateTimeRange")]
        [Validation(Required=false)]
        public string UpdateTimeRangeShrink { get; set; }

        /// <summary>
        /// <para>Specifies whether to return the total number of face groups that match the current query conditions. Default value: false.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("WithTotalCount")]
        [Validation(Required=false)]
        public bool? WithTotalCount { get; set; }

    }

}
