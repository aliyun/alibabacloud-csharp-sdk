// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class Revision : TeaModel {
        /// <summary>
        /// <para>The hash value of the content.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EA4942AA8761213890A5C386F88E6464D2C31CA3</para>
        /// </summary>
        [NameInMap("content_hash")]
        [Validation(Required=false)]
        public string ContentHash { get; set; }

        /// <summary>
        /// <para>The name of the hash algorithm.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sha1</para>
        /// </summary>
        [NameInMap("content_hash_name")]
        [Validation(Required=false)]
        public string ContentHashName { get; set; }

        /// <summary>
        /// <para>The CRC64 value of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3574582125365864471</para>
        /// </summary>
        [NameInMap("crc64_hash")]
        [Validation(Required=false)]
        public string Crc64Hash { get; set; }

        /// <summary>
        /// <para>The time when the version was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("created_at")]
        [Validation(Required=false)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// <para>The ID of the user who created the version.</para>
        /// </summary>
        [NameInMap("creator_id")]
        [Validation(Required=false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// <para>The name of the user who created the version.</para>
        /// </summary>
        [NameInMap("creator_name")]
        [Validation(Required=false)]
        public string CreatorName { get; set; }

        /// <summary>
        /// <para>The domain ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>bj1</para>
        /// </summary>
        [NameInMap("domain_id")]
        [Validation(Required=false)]
        public string DomainId { get; set; }

        /// <summary>
        /// <para>The download URL. The ListRevision operation does not return this value. The GetRevision, UpdateRevision, and RestoreRevision operations return this value.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("download_url")]
        [Validation(Required=false)]
        public string DownloadUrl { get; set; }

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
        /// <para>The file extension.</para>
        /// 
        /// <b>Example:</b>
        /// <para>mov</para>
        /// </summary>
        [NameInMap("file_extension")]
        [Validation(Required=false)]
        public string FileExtension { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9520943DC264</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>Indicates whether it is the latest version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("is_latest_version")]
        [Validation(Required=false)]
        public bool? IsLatestVersion { get; set; }

        /// <summary>
        /// <para>Indicates whether the version is permanently retained.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("keep_forever")]
        [Validation(Required=false)]
        public bool? KeepForever { get; set; }

        /// <summary>
        /// <para>The description of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa</para>
        /// </summary>
        [NameInMap("revision_description")]
        [Validation(Required=false)]
        public string RevisionDescription { get; set; }

        /// <summary>
        /// <para>The version ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40CB7794C929</para>
        /// </summary>
        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        /// <summary>
        /// <para>The version name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.mov</para>
        /// </summary>
        [NameInMap("revision_name")]
        [Validation(Required=false)]
        public string RevisionName { get; set; }

        /// <summary>
        /// <para>The version number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("revision_version")]
        [Validation(Required=false)]
        public long? RevisionVersion { get; set; }

        /// <summary>
        /// <para>The version size.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1024</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>The URL of the thumbnail.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// <para>The time when the version was modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public string UpdatedAt { get; set; }

        /// <summary>
        /// <para>The preview URL.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&OSSAccessKeyId=xxx&Signature=xxx">https://data.aliyunpds.com/hz22%2F5d5b986facbec311ef844c25954f96821497b383%2F5d5b986f955410dd991646bb87c6b4e899eff525?Expires=xxx&amp;OSSAccessKeyId=xxx&amp;Signature=xxx</a></para>
        /// </summary>
        [NameInMap("url")]
        [Validation(Required=false)]
        public string Url { get; set; }

    }

}
