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
        /// <item><description><b>EDGE</b>: connection information.</description></item>
        /// </list>
        /// <para>This parameter is required. If this parameter is not specified, the service returns error code -101.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EDGE</para>
        /// </summary>
        [NameInMap("CriteriaType")]
        [Validation(Required=false)]
        public string CriteriaType { get; set; }

        /// <summary>
        /// <para>The page number of the page to return in a paginated query. Default value: <b>1</b>, which indicates the first page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("CurrentPage")]
        [Validation(Required=false)]
        public long? CurrentPage { get; set; }

        /// <summary>
        /// <para>The destination node information, which is used to filter destination nodes.</para>
        /// <para>This parameter is required. If this parameter is not specified, the service returns error code -101.</para>
        /// </summary>
        [NameInMap("DstNode")]
        [Validation(Required=false)]
        public string DstNodeShrink { get; set; }

        /// <summary>
        /// <para>The end time of the network connectivity. Specify a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required. If this parameter is not specified, the service returns error code -101.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1649260799999</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The maximum number of entries per page when paging is used. Default value: 20. If this parameter is left empty, 20 entries are returned.</para>
        /// <remarks>
        /// <para>Do not leave PageSize empty.</para>
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
        /// <para>This parameter is required. If this parameter is not specified, the service returns error code -101.</para>
        /// </summary>
        [NameInMap("SrcNode")]
        [Validation(Required=false)]
        public string SrcNodeShrink { get; set; }

        /// <summary>
        /// <para>The start time of the network connectivity. Specify a UNIX timestamp in milliseconds.</para>
        /// <para>This parameter is required. If this parameter is not specified, the service returns error code -101.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1666886400000</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
