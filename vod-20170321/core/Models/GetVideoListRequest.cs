// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoListRequest : TeaModel {
        /// <summary>
        /// <para>The category ID. You can obtain the category ID by using one of the following methods:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a> and choose <b>Configuration Management</b> &gt; <b>Media Asset Configuration</b> &gt; <b>Category Management</b> to view the category ID.</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/56401.html">Create a category</a> operation to create a category. The category ID is the value of the CateId response parameter.</description></item>
        /// <item><description>Call the <a href="https://help.aliyun.com/document_detail/56406.html">Get categories and subcategories</a> operation to query categories. The category ID is the value of the CateId response parameter.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>781111</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The end time of the creation time, which must be later than the start time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

        /// <summary>
        /// <para>The current page number. Default value: <b>1</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNo")]
        [Validation(Required=false)]
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: <b>10</b>. Maximum value: <b>100</b>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The list of custom IDs. You can specify one or more custom IDs separated by commas (,). You can specify up to 20 custom IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>123-123,1234-1234</para>
        /// </summary>
        [NameInMap("ReferenceIds")]
        [Validation(Required=false)]
        public string ReferenceIds { get; set; }

        /// <summary>
        /// <para>The sorting method of the query results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b> (default): Sort by creation time in descending order.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: Sort by creation time in ascending order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The start time of the creation time. Specify the time in the <i>yyyy-MM-dd</i>T<i>HH:mm:ss</i>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The video status. You can specify multiple statuses separated by commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Uploading</b>: The video is being uploaded.</description></item>
        /// <item><description><b>UploadFail</b>: The video failed to be uploaded.</description></item>
        /// <item><description><b>UploadSucc</b>: The video is uploaded.</description></item>
        /// <item><description><b>Transcoding</b>: The video is being transcoded.</description></item>
        /// <item><description><b>TranscodeFail</b>: The video failed to be transcoded.</description></item>
        /// <item><description><b>Checking</b>: The video is being reviewed.</description></item>
        /// <item><description><b>Blocked</b>: The video is blocked.</description></item>
        /// <item><description><b>Normal</b>: The video is normal.</description></item>
        /// <item><description><b>ProduceFail</b>: The video failed to be produced.</description></item>
        /// </list>
        /// <para>For more information about the definitions and limits of video statuses, refer to <a href="~~52839#section-p7c-jgy-070~~">Status: video status</a>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Uploading,Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage address of the audio or video file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
