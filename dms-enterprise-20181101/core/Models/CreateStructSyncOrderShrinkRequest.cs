// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class CreateStructSyncOrderShrinkRequest : TeaModel {
        [NameInMap("AttachmentKey")]
        [Validation(Required=false)]
        public string AttachmentKey { get; set; }

        /// <summary>
        /// Specifies whether to skip an error that occurs in executing an SQL statement. Valid values:
        /// 
        /// *   **true**: continues to execute subsequent SQL statements if an error occurs in executing an SQL statement.
        /// *   **false**: stops executing subsequent SQL statements if an error occurs in executing an SQL statement.
        /// </summary>
        [NameInMap("Comment")]
        [Validation(Required=false)]
        public string Comment { get; set; }

        /// <summary>
        /// The name of the source table.
        /// </summary>
        [NameInMap("Param")]
        [Validation(Required=false)]
        public string ParamShrink { get; set; }

        /// <summary>
        /// The information about the table of which you want to synchronize the schema.
        /// </summary>
        [NameInMap("RelatedUserList")]
        [Validation(Required=false)]
        public string RelatedUserListShrink { get; set; }

        [NameInMap("Tid")]
        [Validation(Required=false)]
        public long? Tid { get; set; }

    }

}
