// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class RecentActedFile : TeaModel {
        [NameInMap("action_list")]
        [Validation(Required=false)]
        public List<string> ActionList { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>doc</para>
        /// </summary>
        [NameInMap("category")]
        [Validation(Required=false)]
        public string Category { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("deleted")]
        [Validation(Required=false)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50d6f2aaa16525c7d053998e48fac265962f585f</para>
        /// </summary>
        [NameInMap("drive_id")]
        [Validation(Required=false)]
        public string DriveId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("drive_is_handover")]
        [Validation(Required=false)]
        public bool? DriveIsHandover { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>group drive</para>
        /// </summary>
        [NameInMap("drive_name")]
        [Validation(Required=false)]
        public string DriveName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50d6f2aaa16525c7d053998e48fac265962f585f</para>
        /// </summary>
        [NameInMap("drive_owner_id")]
        [Validation(Required=false)]
        public string DriveOwnerId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>group</para>
        /// </summary>
        [NameInMap("drive_owner_type")]
        [Validation(Required=false)]
        public string DriveOwnerType { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>50d6f2aaa16525c7d053998e48fac265962f585f</para>
        /// </summary>
        [NameInMap("file_id")]
        [Validation(Required=false)]
        public string FileId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>a.jpg</para>
        /// </summary>
        [NameInMap("file_name")]
        [Validation(Required=false)]
        public string FileName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>100</para>
        /// </summary>
        [NameInMap("size")]
        [Validation(Required=false)]
        public long? Size { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para><a href="https://xxx.jpg">https://xxx.jpg</a></para>
        /// </summary>
        [NameInMap("thumbnail")]
        [Validation(Required=false)]
        public string Thumbnail { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("trashed")]
        [Validation(Required=false)]
        public bool? Trashed { get; set; }

    }

}
