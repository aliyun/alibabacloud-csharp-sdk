// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateFileRequest : TeaModel {
        /// <summary>
        /// <para>The processing method that is used if the file that you want to modify has the same name as an existing file on the cloud. Valid values:</para>
        /// <para>ignore: allows you to modify the file by using the same name as an existing file on the cloud.</para>
        /// <para>auto_rename: automatically renames the file that has the same name on the cloud. By default, the current point in time is added to the end of the file name. Example: xxx_20060102_150405.</para>
        /// <para>refuse: does not modify the file that you want to modify but returns the information about the file that has the same name on the cloud.</para>
        /// <para>Default value: ignore.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ignore</para>
        /// </summary>
        [NameInMap("check_name_mode")]
        [Validation(Required=false)]
        public string CheckNameMode { get; set; }

        /// <summary>
        /// <para>The description of the file. The description can be up to 1,024 characters in length.</para>
        /// </summary>
        [NameInMap("description")]
        [Validation(Required=false)]
        public string Description { get; set; }

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
        /// <para>Specifies whether to hide the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("hidden")]
        [Validation(Required=false)]
        public bool? Hidden { get; set; }

        /// <summary>
        /// <para>The tags of the file. You can specify up to 100 tags.</para>
        /// </summary>
        [NameInMap("labels")]
        [Validation(Required=false)]
        public List<string> Labels { get; set; }

        /// <summary>
        /// <para>The local time when the file was modified. The time is in the yyyy-MM-ddTHH:mm:ssZ format based on the UTC+0 time zone.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2019-08-20T06:51:27.292Z</para>
        /// </summary>
        [NameInMap("local_modified_at")]
        [Validation(Required=false)]
        public string LocalModifiedAt { get; set; }

        /// <summary>
        /// <para>The name of the file. The name can be up to 1,024 bytes in length based on the UTF-8 encoding rule.</para>
        /// 
        /// <b>Example:</b>
        /// <para>a.jpg</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>Specifies whether to add the file to favorites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("starred")]
        [Validation(Required=false)]
        public bool? Starred { get; set; }

    }

}
