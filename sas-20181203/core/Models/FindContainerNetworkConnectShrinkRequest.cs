// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class FindContainerNetworkConnectShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The query type of the element to query. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>NODE</b>: node information.</description></item>
        /// <item><description><b>EDGE</b>: connection information.</description></item>
        /// </list>
        /// <remarks>
        /// <para>This parameter is required. If this parameter is not provided, the API returns HTTP 400 with the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>EDGE</para>
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The destination node information, which is used to filter destination nodes.</para>
        /// <remarks>
        /// <para>Both <b>SrcNode</b> and <b>DstNode</b> are required. If either parameter is not provided, the API returns HTTP 400 with the error code -101.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("DstNode")]
        [Validation(Required=false)]
        public string DstNodeShrink { get; set; }

        /// <summary>
        /// <para>The end time of the network connectivity. The value is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>Both <b>StartTime</b> and <b>EndTime</b> are required, and <b>StartTime</b> must be earlier than <b>EndTime</b>. The interval between the two cannot exceed 7 days. If either parameter is not provided or the requirements are not met, the API returns HTTP 400 with the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1649260799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries to return on each page in a paged query. Default value: 20. If this parameter is left empty, 20 entries are returned by default.</para>
        /// <remarks>
        /// <para>Do not leave this parameter empty.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The source node information, which is used to filter source nodes.</para>
        /// <remarks>
        /// <para>Both <b>SrcNode</b> and <b>DstNode</b> are required. If either parameter is not provided, the API returns HTTP 400 with the error code -101.</para>
        /// </remarks>
        /// </summary>
        [NameInMap("SrcNode")]
        [Validation(Required=false)]
        public string SrcNodeShrink { get; set; }

        /// <summary>
        /// <para>The start time of the network connectivity. The value is a UNIX timestamp in milliseconds.</para>
        /// <remarks>
        /// <para>Both <b>StartTime</b> and <b>EndTime</b> are required, and <b>StartTime</b> must be earlier than <b>EndTime</b>. The interval between the two cannot exceed 7 days. If either parameter is not provided or the requirements are not met, the API returns HTTP 400 with the error code -101.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>1666886400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
