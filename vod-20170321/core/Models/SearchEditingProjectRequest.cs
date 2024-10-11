// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class SearchEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The end of the time range to query. The query is performed based on the time range during which the required online editing projects were created. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T13:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        [NameInMap("OwnerAccount")]
        [Validation(Required=false)]
        public string OwnerAccount { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public string OwnerId { get; set; }

        /// <summary>
        /// <para>The number of the page to return. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries to return on each page. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The sorting rule of results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b>: sorts the results based on the creation time in descending order. This is the default value.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: sorts the results based on the creation time in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The query is performed based on the time range during which the required online editing projects were created. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the online editing project. Separate multiple states with commas (,). By default, all online editing projects are queried. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Normal</b>: indicates that the online editing project is in draft.</description></item>
        /// <item><description><b>Producing</b>: indicates that the video is being produced.</description></item>
        /// <item><description><b>Produced</b>: indicates that the video was produced.</description></item>
        /// <item><description><b>ProduceFailed</b>: indicates that the video failed to be produced.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The title of the online editing project.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

    }

}
