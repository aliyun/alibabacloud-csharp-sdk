// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetDownloadUrlRequest : TeaModel {
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
        /// <para>The validity period of the download URL. Maximum value: 115200. Default value: 900. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("expire_sec")]
        [Validation(Required=false)]
        public int? ExpireSec { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9520943DC264</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>The name of the file. The name can be up to 1,024 characters in length.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.txt</para>
        /// </summary>
        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>video/mp4</para>
        /// </summary>
        [NameInMap("response_content_type")]
        [Validation(Required=false)]
        public string ResponseContentType { get; set; }

        /// <summary>
        /// <para>The share ID. If you want to manage a file by using a sharing link, carry the <c>x-share-token</c> header in the request and specify share_id. In this case, <c>drive_id</c> is invalid. Otherwise, use an <c>AccessKey pair</c> or <c>access token</c> for authentication and specify <c>drive_id</c>. You must specify at least either <c>share_id</c> or <c>drive_id</c>.</para>
        /// 
        /// <b>Example:</b>
        /// <para>7JQX1FswpQ8</para>
        /// </summary>
        [NameInMap("share_id")]
        [Validation(Required=false)]
        public string ShareId { get; set; }

    }

}
