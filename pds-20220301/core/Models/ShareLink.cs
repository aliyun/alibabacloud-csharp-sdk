// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class ShareLink : TeaModel {
        /// <summary>
        /// <para>The number of times that the shared files are visited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4</para>
        /// </summary>
        [NameInMap("access_count")]
        [Validation(Required=false)]
        public long? AccessCount { get; set; }

        /// <summary>
        /// <para>The time when the share was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The user who created the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9b7a5aa04d14ae3867fdc886fa01da4</para>
        /// </summary>
        [NameInMap("creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The description of the share.</para>
        /// 
        /// <b>Example:</b>
        /// <para>videos</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the download feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_download")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the preview feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_preview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        /// <summary>
        /// <para>Specifies whether to disable the save feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_save")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("download_count")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// <para>The limit on the number of times that the shared files can be downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The time when the share URL expires. The value of this parameter follows the RFC 3339 standard. Example: &quot;2020-06-28T11:33:00.000+08:00&quot;. If you set the value to &quot;&quot;, the share URL never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-28T11:33:00.000+08:00</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>Specifies whether the share is expired.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>The IDs of the files to share in the parent path.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;520b217f13adf4fc24f2191991b1664ce045b393&quot;]</para>
        /// </summary>
        [NameInMap("file_id_list")]
        [Validation(Required=false)]
        public List<string> FileIdList { get; set; }

        [NameInMap("office_editable")]
        [Validation(Required=false)]
        public bool? OfficeEditable { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are previewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("preview_count")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        /// <summary>
        /// <para>The limit on the number of times that the shared files can be previewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("preview_limit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are reported.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("report_count")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("save_count")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        [NameInMap("save_download_limit")]
        [Validation(Required=false)]
        public long? SaveDownloadLimit { get; set; }

        /// <summary>
        /// <para>The limit on the number of times that the shared files can be saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        /// <summary>
        /// <para>Specifies whether to share all files in the drive.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("share_all_files")]
        [Validation(Required=false)]
        public bool? ShareAllFiles { get; set; }

        /// <summary>
        /// <para>The share ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The name of the share. By default, the file name that corresponds to the first ID in the file ID list is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>video-1.MP4</para>
        /// </summary>
        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// <para>The access code. An access code can be up to 64 characters in length. If you do not specify a value, files can be accessed without an access code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcF123x</para>
        /// </summary>
        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        /// <summary>
        /// <para>The status of the share. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: The share is canceled.</description></item>
        /// <item><description>enabled: The share is effective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The time when the share was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The number of times that the shared audio and video files are played.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("video_preview_count")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}
