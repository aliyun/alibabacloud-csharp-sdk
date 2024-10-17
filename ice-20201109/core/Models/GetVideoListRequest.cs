// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ICE20201109.Models
{
    public class GetVideoListRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the category.</para>
        /// 
        /// <b>Example:</b>
        /// <para>781111</para>
        /// </summary>
        [NameInMap("CateId")]
        [Validation(Required=false)]
        public long? CateId { get; set; }

        /// <summary>
        /// <para>The end of the time range to query. The end time must be later than the start time. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:59:00Z</para>
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
        public int? PageNo { get; set; }

        /// <summary>
        /// <para>The number of entries per page. Default value: 10. Maximum value: 50.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The sorting method of the results. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>CreationTime:Desc (default): sorts results in reverse chronological order.</description></item>
        /// <item><description>CreationTime:Asc: sorts results in chronological order.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>CreationTime:Asc</para>
        /// </summary>
        [NameInMap("SortBy")]
        [Validation(Required=false)]
        public string SortBy { get; set; }

        /// <summary>
        /// <para>The beginning of the time range to query. Specify the time in the ISO 8601 standard in the yyyy-MM-ddTHH:mm:ssZ format. The time must be in UTC.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2017-01-11T12:00:00Z</para>
        /// </summary>
        [NameInMap("StartTime")]
        [Validation(Required=false)]
        public string StartTime { get; set; }

        /// <summary>
        /// <para>The status of the video. You can specify multiple video statuses and separate them with commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>PrepareFail: The file is abnormal.</description></item>
        /// <item><description>UploadFail: The video failed to be uploaded.</description></item>
        /// <item><description>UploadSucc: The video is uploaded.</description></item>
        /// <item><description>Transcoding: The video is being transcoded.</description></item>
        /// <item><description>TranscodeFail: The video failed to be transcoded.</description></item>
        /// <item><description>ProduceFail: The video failed to be produced.</description></item>
        /// <item><description>Normal: The video is normal.</description></item>
        /// <item><description>Uploading: The video is being uploaded.</description></item>
        /// <item><description>Preparing: The file is being generated.</description></item>
        /// <item><description>Blocked: The video is blocked.</description></item>
        /// <item><description>checking: The video is being reviewed.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Uploading,Normal</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
