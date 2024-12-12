// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class SearchEditingProjectRequest : TeaModel {
        /// <summary>
        /// <para>The source of the project.</para>
        /// <para>\-OpenAPI</para>
        /// <para>\-AliyunConsole</para>
        /// <para>\-WebSDK</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>AliyunConsole: The project is created in the Alibaba Cloud console.</description></item>
        /// <item><description>WebSDK: The project is created by using the SDK for Web.</description></item>
        /// <item><description>OpenAPI: The project is created by calling API operations.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>WebSDK</para>
        /// </summary>
        [NameInMap("CreateSource")]
        [Validation(Required=false)]
        public string CreateSource { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The page number. Default value: 1.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Valid values: 1 to 100.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The type of the editing project. Default value: EditingProject. Valid values:</para>
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
        /// <para>The sorting rule of results. Valid values:</para>
        /// <para>\- CreationTime:Desc (default): The results are sorted in reverse chronological order based on the creation time.</para>
        /// <para>\- CreationTime:Asc: The results are sorted in chronological order based on the creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. The time follows the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time is displayed in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the online editing project. Separate multiple values with commas (,). By default, all online editing projects are queried.</para>
        /// <para>Valid values:</para>
        /// <para>\-Draft</para>
        /// <para>\-Producing</para>
        /// <para>\-Produced</para>
        /// <para>\-ProduceFailed</para>
        /// 
        /// <b>Example:</b>
        /// <para>Producing</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The template type. Valid values:</para>
        /// <para>\-Timeline</para>
        /// <para>\-VETemplate</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Timeline: regular template.</description></item>
        /// <item><description>VETemplate: advanced template.</description></item>
        /// <item><description>None: No template is used.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Timeline</para>
        /// </summary>
        [NameInMap("TemplateType")]
        [Validation(Required=false)]
        public string TemplateType { get; set; }

    }

}
