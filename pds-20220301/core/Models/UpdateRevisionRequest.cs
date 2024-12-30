// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class UpdateRevisionRequest : TeaModel {
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
        /// <para>Specifies whether to permanently retain a version.</para>
        /// <para>By default, this parameter is not specified, which indicates that you do not modify the permanent retention configuration of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("keep_forever")]
        [Validation(Required=false)]
        public bool? KeepForever { get; set; }

        /// <summary>
        /// <para>The description of the version. The description can be up to 1,024 characters in length.</para>
        /// <para>By default, this parameter is not specified, which indicates that you do not modify the description of the version.</para>
        /// 
        /// <b>Example:</b>
        /// <para>aaa</para>
        /// </summary>
        [NameInMap("revision_description")]
        [Validation(Required=false)]
        public string RevisionDescription { get; set; }

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

    }

}
