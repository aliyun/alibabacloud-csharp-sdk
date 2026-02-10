// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ecd20200930.Models
{
    public class CdsFileShareLinkModel : TeaModel {
        /// <summary>
        /// <para>The number of times to access the shared file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10000</para>
        /// </summary>
        [NameInMap("AccessCount")]
        [Validation(Required=false)]
        public long? AccessCount { get; set; }

        /// <summary>
        /// <para>The creation time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-04T03:30:36Z</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The user that creates the file sharing task.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user01</para>
        /// </summary>
        [NameInMap("Creator")]
        [Validation(Required=false)]
        public string Creator { get; set; }

        /// <summary>
        /// <para>The description.</para>
        /// 
        /// <b>Example:</b>
        /// <para>newDescription</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The shared file is forbidden from being downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableDownload")]
        [Validation(Required=false)]
        public bool? DisableDownload { get; set; }

        /// <summary>
        /// <para>The shared file is forbidden from being previewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisablePreview")]
        [Validation(Required=false)]
        public bool? DisablePreview { get; set; }

        /// <summary>
        /// <para>The shared file is forbidden from being dumped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("DisableSave")]
        [Validation(Required=false)]
        public bool? DisableSave { get; set; }

        /// <summary>
        /// <para>The number of times that the shared file can be downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DownloadCount")]
        [Validation(Required=false)]
        public long? DownloadCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared file can be downloaded.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("DownloadLimit")]
        [Validation(Required=false)]
        public long? DownloadLimit { get; set; }

        /// <summary>
        /// <para>The team space ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dri-g0877jp3hu1ox****</para>
        /// </summary>
        [NameInMap("DriveId")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The time when the file sharing link expires.</para>
        /// <remarks>
        /// <para> The value must be in the FC3339 format. Example: 2020-06-28T11:33:00.000+08:00. If the parameter is left empty, the file sharing link is permanently valid.</para>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>2020-06-28T11:33:00.000+08:00</para>
        /// </summary>
        [NameInMap("Expiration")]
        [Validation(Required=false)]
        public string Expiration { get; set; }

        /// <summary>
        /// <para>Specifies whether the file sharing link expires.</para>
        /// 
        /// <b>Example:</b>
        /// <para>False</para>
        /// </summary>
        [NameInMap("Expired")]
        [Validation(Required=false)]
        public bool? Expired { get; set; }

        /// <summary>
        /// <para>The file sharing task IDs.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[\&quot;63886f1fe2014d9a5a3348768dcc27dfc57ee103\&quot;]</para>
        /// </summary>
        [NameInMap("FileIds")]
        [Validation(Required=false)]
        public string FileIds { get; set; }

        /// <summary>
        /// <para>The modification time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2021-09-04T04:30:36Z</para>
        /// </summary>
        [NameInMap("ModifiyTime")]
        [Validation(Required=false)]
        public string ModifiyTime { get; set; }

        /// <summary>
        /// <para>The number of times that the shared file is previewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("PreviewCount")]
        [Validation(Required=false)]
        public long? PreviewCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared file can be previewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("PreviewLimit")]
        [Validation(Required=false)]
        public long? PreviewLimit { get; set; }

        /// <summary>
        /// <para>The number of times that the shared file is reported due to content violation.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("ReportCount")]
        [Validation(Required=false)]
        public long? ReportCount { get; set; }

        /// <summary>
        /// <para>The number of times that the shared files can be dumped.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SaveCount")]
        [Validation(Required=false)]
        public long? SaveCount { get; set; }

        /// <summary>
        /// <para>The maximum number of times that the shared file can be saved.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("SaveLimit")]
        [Validation(Required=false)]
        public long? SaveLimit { get; set; }

        /// <summary>
        /// <para>The file sharing task ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1Fs****</para>
        /// </summary>
        [NameInMap("ShareId")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

        /// <summary>
        /// <para>The file sharing link.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://stg109960.apps.aliyunpds.com/disk/s/7uLJanz">https://stg109960.apps.aliyunpds.com/disk/s/7uLJanz</a>****</para>
        /// </summary>
        [NameInMap("ShareLink")]
        [Validation(Required=false)]
        public string ShareLink { get; set; }

        /// <summary>
        /// <para>The shared file name. By default, the name of the first shared file is used.</para>
        /// 
        /// <b>Example:</b>
        /// <para>view.txt</para>
        /// </summary>
        [NameInMap("ShareName")]
        [Validation(Required=false)]
        public string ShareName { get; set; }

        /// <summary>
        /// <para>The access code. It must contain up to 64 characters in length. 0 characters indicates that there is no access code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>12345678</para>
        /// </summary>
        [NameInMap("SharePwd")]
        [Validation(Required=false)]
        public string SharePwd { get; set; }

        /// <summary>
        /// <para>The status of the file sharing link.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>forbidden_disabled</para>
        /// <!-- -->
        /// 
        /// <para>: The file sharing link is canceled</para>
        /// <!-- -->
        /// 
        /// <para>after it</para>
        /// <!-- -->
        /// 
        /// <para>is not allowed.</para>
        /// </description></item>
        /// <item><description><para>forbidden</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>The file sharing link is not allowed</para>
        /// <!-- -->
        /// 
        /// <para>.</para>
        /// </description></item>
        /// <item><description><para>disabled</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>The file sharing link is canceled.</para>
        /// <!-- -->
        /// </description></item>
        /// <item><description><para>enabled</para>
        /// <!-- -->
        /// 
        /// <para>:</para>
        /// <!-- -->
        /// 
        /// <para>The file sharing link is valid.</para>
        /// <!-- --></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>disabled</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

        /// <summary>
        /// <para>The number of times that the audio and video file is played.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0</para>
        /// </summary>
        [NameInMap("VideoPreviewCount")]
        [Validation(Required=false)]
        public long? VideoPreviewCount { get; set; }

    }

}
