// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class ListTemplatesRequest : TeaModel {
        /// <summary>
        /// <para>The source from which the template was created.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>AliyunConsole</para>
        /// </description></item>
        /// <item><description><para>WebSDK</para>
        /// </description></item>
        /// <item><description><para>OpenAPI</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>OpenAPI</para>
        /// </summary>
        [NameInMap("CreateSource")]
        [Validation(Required=false)]
        public string CreateSource { get; set; }

        /// <summary>
        /// <para>The search keyword. You can use the template ID or title as the keyword to search for templates.</para>
        /// 
        /// <b>Example:</b>
        /// <para><b><b>20b48fb04483915d4f2cd8ac</b></b></para>
        /// </summary>
        [NameInMap("Keyword")]
        [Validation(Required=false)]
        public string Keyword { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public long? PageNo { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting parameter. By default, the query results are sorted by creation time in descending order.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>CreationTime:Asc: sorted by creation time in ascending order.</para>
        /// </description></item>
        /// <item><description><para>CreationTime:Desc: sorted by creation time in descending order.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Desc</para>
        /// </summary>
        [NameInMap("SortType")]
        [Validation(Required=false)]
        public string SortType { get; set; }

        /// <summary>
        /// <para>The template state.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>UploadFailed: Failed to upload the video.</para>
        /// </description></item>
        /// <item><description><para>ProcessFailed: Failed to process the advanced template.</para>
        /// </description></item>
        /// <item><description><para>Available: The template is available.</para>
        /// </description></item>
        /// <item><description><para>Uploading: The video is being uploaded.</para>
        /// </description></item>
        /// <item><description><para>Created: The template is created but not ready for use.</para>
        /// </description></item>
        /// <item><description><para>Processing: The advanced template is being processed.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Available</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The template type.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>Timeline</para>
        /// </description></item>
        /// <item><description><para>VETemplate</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Timeline</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
