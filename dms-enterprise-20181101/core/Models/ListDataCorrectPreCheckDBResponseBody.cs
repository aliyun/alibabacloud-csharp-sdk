// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dms_enterprise20181101.Models
{
    public class ListDataCorrectPreCheckDBResponseBody : TeaModel {
        /// <summary>
        /// The ID of the tenant. You can call the [GetUserActiveTenant](~~198073~~) or [ListUserTenants](~~198074~~) operation to query the ID of the tenant.
        /// </summary>
        [NameInMap("ErrorCode")]
        [Validation(Required=false)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// The name of the database.
        /// </summary>
        [NameInMap("ErrorMessage")]
        [Validation(Required=false)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("PreCheckDBList")]
        [Validation(Required=false)]
        public List<ListDataCorrectPreCheckDBResponseBodyPreCheckDBList> PreCheckDBList { get; set; }
        public class ListDataCorrectPreCheckDBResponseBodyPreCheckDBList : TeaModel {
            [NameInMap("DbId")]
            [Validation(Required=false)]
            public long? DbId { get; set; }

            [NameInMap("SearchName")]
            [Validation(Required=false)]
            public string SearchName { get; set; }

            [NameInMap("SqlNum")]
            [Validation(Required=false)]
            public long? SqlNum { get; set; }

        }

        /// <summary>
        /// The ID of the ticket for the data change.
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// The number of SQL statements.
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
