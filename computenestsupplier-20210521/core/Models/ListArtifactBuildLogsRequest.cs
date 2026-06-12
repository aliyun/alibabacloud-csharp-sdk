// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ComputeNestSupplier20210521.Models
{
    public class ListArtifactBuildLogsRequest : TeaModel {
        /// <summary>
        /// <para>The artifact ID.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> operation to obtain the artifact ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>artifact-fbad2ca276194d019714</para>
        /// </summary>
        [NameInMap("ArtifactId")]
        [Validation(Required=false)]
        public string ArtifactId { get; set; }

        /// <summary>
        /// <para>The artifact version.</para>
        /// <para>You can call the <a href="https://help.aliyun.com/document_detail/469993.html">ListArtifacts</a> operation to obtain the artifact version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>draft</para>
        /// </summary>
        [NameInMap("ArtifactVersion")]
        [Validation(Required=false)]
        public string ArtifactVersion { get; set; }

        /// <summary>
        /// <para>The filter.</para>
        /// </summary>
        [NameInMap("Filter")]
        [Validation(Required=false)]
        public List<ListArtifactBuildLogsRequestFilter> Filter { get; set; }
        public class ListArtifactBuildLogsRequestFilter : TeaModel {
            /// <summary>
            /// <para>The name of the filter.</para>
            /// <para>Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para>StartTime</para>
            /// </description></item>
            /// <item><description><para>EndTime</para>
            /// </description></item>
            /// <item><description><para>ApplicationGroupName</para>
            /// </description></item>
            /// <item><description><para>ResouceName</para>
            /// </description></item>
            /// <item><description><para>EventName</para>
            /// </description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>BuildStartTime</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The filter values.</para>
            /// </summary>
            [NameInMap("Value")]
            [Validation(Required=false)]
            public List<string> Value { get; set; }

        }

        /// <summary>
        /// <para>The number of entries to return on each page. Maximum value: 100. Default value: 20.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// <para>The token to start the next paged query.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AAAAAbL3H6CZmy6oocwGDqzQ+Gc=</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sort order. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>Ascending</b>: sorts the results in ascending order.</para>
        /// </description></item>
        /// <item><description><para><b>Descending</b> (default): sorts the results in descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Ascending</para>
        /// </summary>
        [NameInMap("SortOrder")]
        [Validation(Required=false)]
        public string SortOrder { get; set; }

    }

}
