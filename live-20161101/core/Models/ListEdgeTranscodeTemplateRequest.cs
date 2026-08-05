// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Live20161101.Models
{
    public class ListEdgeTranscodeTemplateRequest : TeaModel {
        /// <summary>
        /// <para>The data center ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>3b-4d18-395c-8106-ff21a6</b></b></b></para>
        /// </summary>
        [NameInMap("ClusterId")]
        [Validation(Required=false)]
        public string ClusterId { get; set; }

        /// <summary>
        /// <para>The search keyword. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Template ID. Exact match is supported.</description></item>
        /// <item><description>Template name. Fuzzy match is supported.</description></item>
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
        /// <para>The number of entries per page. Default value: 10. Maximum value: 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The region ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>The sorting rule. Templates are sorted by creation time (CreateTime). Default value: desc. Valid values:</para>
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
        /// <para>The edge transcoding type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>common</b>: default transcoding (standard + Narrowband HD 1.0).</description></item>
        /// <item><description><b>nbhd-2</b>: Narrowband HD 2.0.</description></item>
        /// <item><description><b>ultra-hd</b>: ultra-high definition.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the system displays transcoding templates for the transcoding types that the user has permissions to access.</para>
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
        /// <item><description>H.264.</description></item>
        /// <item><description>H.265.</description></item>
        /// </list>
        /// <remarks>
        /// <para>If this parameter is not specified, the system displays transcoding templates for the video encoding formats that the user has permissions to access.</para>
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
