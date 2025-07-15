// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListEdgeTranscodeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the data center.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3b-4d18-395c-8106-ff21a6</b></b></b></para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The keyword of the query.</para>
        /// <list type="bullet">
        /// <item><description>You can specify a template ID for an exact match.</description></item>
        /// <item><description>You can also specify a template name for a fuzzy match.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>baseline</para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Valid values: 1 to 100. Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sorting order of the templates by creation time. Default value: desc. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>desc: descending order.</description></item>
        /// <item><description>asc: ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The type of edge transcoding. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: standard transcoding and Narrowband HD™ 1.0 transcoding.</description></item>
        /// <item><description><b>nbhd-2</b>: Narrowband HD™ 2.0 transcoding.</description></item>
        /// <item><description><b>ultra-hd</b>: ultra-high definition transcoding.</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the query result is filtered based on the type of edge transcoding on which you are granted permissions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>nbhd-2</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

        /// <summary>
        /// <para>The video encoding format. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>H.264</description></item>
        /// <item><description>H.265</description></item>
        /// </list>
        /// <remarks>
        /// <para> If you do not specify this parameter, the query result is filtered based on the video encoding format on which you are granted permissions.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>H.264</para>
        /// </summary>
        [NameInMap("VideoCodec")]
        [Validation(Required=false)]
        public string VideoCodec { get; set; }

    }

}
