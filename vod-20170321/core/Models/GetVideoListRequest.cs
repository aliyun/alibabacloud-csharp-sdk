// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Vod20170321.Models
{
    public class GetVideoListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category. You can use one of the following methods to obtain the category ID:</para>
        /// <list type="bullet">
        /// <item><description>Log on to the <a href="https://vod.console.aliyun.com">ApsaraVideo VOD console</a>. In the left-side navigation pane, choose <b>Configuration Management</b> &gt; <b>Media Management</b> &gt; <b>Categories</b> to view the category ID.</description></item>
        /// <item><description>Obtain the value of CateId from the response to the <a href="https://help.aliyun.com/document_detail/56401.html">AddCategory</a> operation.</description></item>
        /// <item><description>Obtain the value of CateId from the response to the <a href="https://help.aliyun.com/document_detail/56406.html">GetCategories</a> operation.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>781111</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:59:00Z</para>
        /// </summary>
        [NameInMap("EndTime")]
        [Validation(Required=false)]
        public string EndTime { get; set; }

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

        /// <summary>
        /// <para>The sorting method of the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>CreationTime:Desc</b> (default): The results are sorted in reverse chronological order based on the creation time.</description></item>
        /// <item><description><b>CreationTime:Asc</b>: The results are sorted in chronological order based on the creation time.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the <em>yyyy-MM-dd</em>T<em>HH:mm:ss</em>Z format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the video. You can specify multiple video statuses and separate them with commas (,). Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>Uploading</b>: The video is being uploaded.</description></item>
        /// <item><description><b>UploadFail</b>: The video failed to be uploaded.</description></item>
        /// <item><description><b>UploadSucc</b>: The video has been uploaded.</description></item>
        /// <item><description><b>Transcoding</b>: The video is being transcoded.</description></item>
        /// <item><description><b>TranscodeFail</b>: The video failed to be transcoded.</description></item>
        /// <item><description><b>checking</b>: The video is being reviewed.</description></item>
        /// <item><description><b>Blocked</b>: The video is blocked.</description></item>
        /// <item><description><b>Normal</b>: The video is normal.</description></item>
        /// <item><description><b>ProduceFail</b>: The video failed to be produced.</description></item>
        /// </list>
        /// <para>For more information about each video status, see the &quot;Status: the status of a video&quot; section of the <a href="~~52839#section-p7c-jgy-070~~">Basic data types</a> topic.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Uploading,Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The storage address of the media file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>out-****.oss-cn-shanghai.aliyuncs.com</para>
        /// </summary>
        [NameInMap("StorageLocation")]
        [Validation(Required=false)]
        public string StorageLocation { get; set; }

    }

}
