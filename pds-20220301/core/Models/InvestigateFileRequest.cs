// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Pds20220301.Models
{
    public class InvestigateFileRequest : TeaModel {
        /// <summary>
        /// This parameter is required.
        /// </summary>
        [NameInMap("drive_file_ids")]
        [Validation(Required=false)]
        public List<InvestigateFileRequestDriveFileIds> DriveFileIds { get; set; }
        public class InvestigateFileRequestDriveFileIds : TeaModel {
            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("drive_id")]
            [Validation(Required=false)]
            public string DriveId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("file_id")]
            [Validation(Required=false)]
            public string FileId { get; set; }

        }

        [NameInMap("policy")]
        [Validation(Required=false)]
        public InvestigateFileRequestPolicy Policy { get; set; }
        public class InvestigateFileRequestPolicy : TeaModel {
            [NameInMap("first_product_name")]
            [Validation(Required=false)]
            public string FirstProductName { get; set; }

            [NameInMap("mtee_code")]
            [Validation(Required=false)]
            public string MteeCode { get; set; }

            [NameInMap("provider")]
            [Validation(Required=false)]
            public string Provider { get; set; }

        }

        [NameInMap("recursive")]
        [Validation(Required=false)]
        public bool? Recursive { get; set; }

        [NameInMap("user_data")]
        [Validation(Required=false)]
        public string UserData { get; set; }

    }

}
