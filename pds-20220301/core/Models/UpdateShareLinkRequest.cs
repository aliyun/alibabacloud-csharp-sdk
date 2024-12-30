// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateShareLinkRequest : TeaModel {
        /// <summary>
        /// <para>The description of the share link. The description can be up to 1,024 characters in length.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>Specifies whether to prohibit the downloads of the shared files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_download")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        /// <summary>
        /// <para>Specifies whether to prohibit the previews of the shared files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_preview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        /// <summary>
        /// <para>Specifies whether to prohibit the saves of the shared files.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_save")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are downloaded. The value must be greater than or equal to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>30</para>
        /// </summary>
        [NameInMap("download_count")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared files can be downloaded. The value must be greater than or equal to 0. A value of 0 specifies that the number is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// <para>The time when the share link expires. The time follows the RFC 3339 standard. Example: 2020-06-28T11:33:00.000+08:00. If you leave this parameter empty, the share link never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-28T11:33:00.000+08:00</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        [NameInMap("office_editable")]
        [Validation(Required=false)]
        public bool? OfficeEditable { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are previewed. The value must be greater than or equal to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3</para>
        /// </summary>
        [NameInMap("preview_count")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared files can be previewed. The value must be greater than or equal to 0. A value of 0 specifies that the number is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("preview_limit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are reported. The value must be greater than or equal to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("report_count")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files are saved. The value must be greater than or equal to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("save_count")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared files can be saved. The value must be greater than or equal to 0. A value of 0 specifies that the number is unlimited.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("save_limit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        /// <summary>
        /// <para>The share ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The name of the share link. By default, the name of the first file is used. The name can be up to 128 characters in length.</para>
        /// </summary>
        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// <para>The access code. The access code can be up to 64 characters in length. A value of 0 specifies an empty string.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcF123x</para>
        /// </summary>
        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        /// <summary>
        /// <para>The state of the share link. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>disabled: The share link is canceled.</description></item>
        /// <item><description>enabled: The share link is effective.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>enabled</para>
        /// </summary>
        [NameInMap("status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of times that the videos are previewed in the shared files. The value must be greater than or equal to 0.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("video_preview_count")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}
