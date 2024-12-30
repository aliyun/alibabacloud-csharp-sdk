// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class CreateShareLinkRequest : TeaModel {
        [NameInMap("creatable")]
        [Validation(Required=false)]
        public bool? Creatable { get; set; }

        [NameInMap("creatable_file_id_list")]
        [Validation(Required=false)]
        public List<string> CreatableFileIdList { get; set; }

        /// <summary>
        /// <para>The description of the share. The description must be 0 to 1,024 characters in length.</para>
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
        /// <para>Specifies whether to disable the dump feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("disable_save")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        /// <summary>
        /// <para>The limit on the number of times that the shared files can be downloaded. The value of this parameter must be equal to or greater than 0. A value of 0 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("download_limit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// <para>The drive ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The time when the share URL expires. The value of this parameter follows the RFC 3339 standard. Example: &quot;2020-06-28T11:33:00.000+08:00&quot;. If expiration is set to &quot;&quot;, the share URL never expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-28T11:33:00.000+08:00</para>
        /// </summary>
        [NameInMap("expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>The IDs of the files to share in the parent path. The number of files in the parent path ranges from 1 to 100. If share_all_files is set to true, this parameter does not take effect. Otherwise, you must specify this parameter.``</para>
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
        /// <para>The limit on the number of times that the shared files can be previewed. The value of this parameter must be equal to or greater than 0. A value of 0 indicates no limit.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("preview_limit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        [NameInMap("require_login")]
        [Validation(Required=false)]
        public bool? RequireLogin { get; set; }

        /// <summary>
        /// <para>The limit on the number of times that the shared files can be dumped. The value of this parameter must be equal to or greater than 0. A value of 0 indicates no limit.</para>
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
        /// <para>The name of the share. If you leave this parameter empty, the file name that corresponds to the first ID in the file ID list is used. The name must be 0 to 128 characters in length.</para>
        /// </summary>
        [NameInMap("share_name")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// <para>The access code. An access code must be 0 to 64 bytes in length. If you do not specify this parameter or leave this parameter empty, the files can be accessed without an access code. In this case, you do not need to specify the share_pwd parameter when you call an operation to query the share URL. The access code can contain only visible ASCII characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>abcF123x</para>
        /// </summary>
        [NameInMap("share_pwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        /// <summary>
        /// <para>The user ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>u123</para>
        /// </summary>
        [NameInMap("user_id")]
        [Validation(Required=false)]
        public string UserId { get; set; }

    }

}
