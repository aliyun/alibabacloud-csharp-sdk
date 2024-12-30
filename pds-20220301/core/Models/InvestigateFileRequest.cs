// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class InvestigateFileRequest : TeaModel {
        /// <summary>
        /// <para>This parameter is required.</para>
        /// </summary>
        [NameInMap("drive_file_ids")]
        [Validation(Required=false)]
        public List<InvestigateFileRequestDriveFileIds> DriveFileIds { get; set; }
        public class InvestigateFileRequestDriveFileIds : TeaModel {
            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("drive_id")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>9520943DC264</para>
            /// </summary>
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

        }

    }

}
