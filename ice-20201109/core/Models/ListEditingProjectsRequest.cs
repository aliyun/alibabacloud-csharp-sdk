// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListEditingProjectsRequest : TeaModel {
        /// <summary>
        /// <para>The method for creating the online editing project. Valid values:</para>
        /// <para>\- OpenAPI</para>
        /// <para>\- AliyunConsole</para>
        /// <para>\- WebSDK</para>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("CreateSource")]
        [Validation(Required=false)]
        public string CreateSource { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-02-02T23:59:59Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The search keyword. You can search by job ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b><b>6f36bc45d09a9d5cde49</b></b></b></para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <para>The number of entries per page. A maximum of 100 entries can be returned on each page.</para>
        /// <para>Default value: 10.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("MaxResults")]
        [Validation(Required=false)]
        public string MaxResults { get; set; }

        /// <summary>
        /// <para>The pagination token that is used in the next request to retrieve a new page of results.</para>
        /// 
        /// <b>Example:</b>
        /// <para>8EqYpQbZ6Eh7+Zz8DxVYoQ==</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <para>The type of the editing project. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>EditingProject: a regular editing project.</description></item>
        /// <item><description>LiveEditingProject: a live stream editing project.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>EditingProject</para>
        /// </summary>
        [NameInMap("ProjectType")]
        [Validation(Required=false)]
        public string ProjectType { get; set; }

        /// <summary>
        /// <para>The order of sorting of the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreationTime:Desc (default): sorts the results in reverse chronological order.</description></item>
        /// <item><description>CreationTime:Asc: sorts the results in chronological order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-12-21T08:00:01Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the online editing project. By default, online editing projects in all states are queried.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Produced</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The template type. This parameter is required if you create a template-based online editing project. Default value: Timeline.</para>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// <item><description></description></item>
        /// </list>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Timeline: a regular template.</description></item>
        /// <item><description>VETemplate: an advanced template.</description></item>
        /// <item><description>None: general editing.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>None</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
