// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetShareLinkByAnonymousResponseBody : TeaModel {
        /// <summary>
        /// <para>The number of times that the shared files are visited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("access_count")]
        [Validation(Required=false)]
        public long? AccessCount { get; set; }

        /// <summary>
        /// <para>The profile picture of the user who created the share link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://aliyunpds.com/a.jpg">https://aliyunpds.com/a.jpg</a></para>
        /// </summary>
        [NameInMap("avatar")]
        [Validation(Required=false)]
        public string Avatar { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the share link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>c9b7a5aa04d14ae3867fdc886fa01da4</para>
        /// </summary>
        [NameInMap("creator_id")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The name of the user who created the share link. The value is masked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AB***CD</para>
        /// </summary>
        [NameInMap("creator_name")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The mobile number of the user who created the share link. The value is masked.</para>
        /// 
        /// <b>Example:</b>
        /// <para>136****00</para>
        /// </summary>
        [NameInMap("creator_phone")]
        [Validation(Required=false)]
        public string CreatorPhone { get; set; }

        /// <summary>
        /// <para>Indicates whether the downloads of the shared files are prohibited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_download")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        /// <summary>
        /// <para>Indicates whether the previews of the shared files are prohibited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_preview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        /// <summary>
        /// <para>Indicates whether the saves of the shared files are prohibited.</para>
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
        /// <para>50</para>
        /// </summary>
        [NameInMap("download_count")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared files can be downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// <para>The time when the share link expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>Indicates whether a password is specified for the share link.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("has_pwd")]
        [Validation(Required=false)]
        public bool? HasPwd { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are previewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>80</para>
        /// </summary>
        [NameInMap("preview_count")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared files can be previewed.</para>
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

        /// <summary>
        /// <para>The maximum number of times that the shared files can be saved and downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("save_download_limit")]
        [Validation(Required=false)]
        public long? SaveDownloadLimit { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared files can be saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        /// <summary>
        /// <para>The name of the share link.</para>
        /// </summary>
        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// <para>The time when the share link was last modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The number of times that the videos are previewed in the shared files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("video_preview_count")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}
