// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UncompressedFileInfo : TeaModel {
        /// <summary>
        /// <para>The drive ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5060</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <para>The file ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>66972349b2b12fa309a143fb9db29647b2ddabfd</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <para>Whether it is a folder.</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description>true</description></item>
        /// <item><description>false</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("is_folder")]
        [Validation(Required=false)]
        public bool? IsFolder { get; set; }

        /// <summary>
        /// <para>Subfiles</para>
        /// </summary>
        [NameInMap("items")]
        [Validation(Required=false)]
        public List<UncompressedFileInfo> Items { get; set; }

        /// <summary>
        /// <para>The name of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1.mov</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

        /// <summary>
        /// <para>The size of the file.</para>
        /// 
        /// <b>Example:</b>
        /// <para>218052</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <para>Update time.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1721368014000</para>
        /// </summary>
        [NameInMap("updated_at")]
        [Validation(Required=false)]
        public long? UpdatedAt { get; set; }

    }

}
