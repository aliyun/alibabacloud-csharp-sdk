// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class GetRevisionRequest : TeaModel {
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
        /// <para>Specifies the returned fields.</para>
        /// <para>By default, this parameter is left empty. If you set this parameter to \*, all fields are returned. If you leave this parameter empty, the creator of the file is not returned.</para>
        /// 
        /// <b>Example:</b>
        /// <list type="bullet">
        /// <item><description></description></item>
        /// </list>
        /// </summary>
        [NameInMap("fields")]
        [Validation(Required=false)]
        public string Fields { get; set; }

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
        /// <para>The version ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40CB7794C929</para>
        /// </summary>
        [NameInMap("revision_id")]
        [Validation(Required=false)]
        public string RevisionId { get; set; }

        /// <summary>
        /// <para>The validity period of the file download or preview. Valid values: 10 to 86400.</para>
        /// <para>Default value: 900. Unit: seconds.</para>
        /// 
        /// <b>Example:</b>
        /// <para>900</para>
        /// </summary>
        [NameInMap("url_expire_sec")]
        [Validation(Required=false)]
        public long? UrlExpireSec { get; set; }

    }

}
