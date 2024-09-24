// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class GetClusterDiagnosisCheckItemsResponseBody : TeaModel {
        /// <summary>
        /// The check item.
        /// </summary>
        [NameInMap("check_items")]
        [Validation(Required=false)]
        public List<GetClusterDiagnosisCheckItemsResponseBodyCheckItems> CheckItems { get; set; }
        public class GetClusterDiagnosisCheckItemsResponseBodyCheckItems : TeaModel {
            /// <summary>
            /// The description.
            /// </summary>
            [NameInMap("desc")]
            [Validation(Required=false)]
            public string Desc { get; set; }

            /// <summary>
            /// The display name.
            /// </summary>
            [NameInMap("display")]
            [Validation(Required=false)]
            public string Display { get; set; }

            /// <summary>
            /// The name of the group to which the check item belongs.
            /// </summary>
            [NameInMap("group")]
            [Validation(Required=false)]
            public string Group { get; set; }

            /// <summary>
            /// The severity level of the check result.
            /// 
            /// Valid values:
            /// 
            /// *   normal
            /// *   warning
            /// *   error
            /// </summary>
            [NameInMap("level")]
            [Validation(Required=false)]
            public string Level { get; set; }

            /// <summary>
            /// The check result.
            /// </summary>
            [NameInMap("message")]
            [Validation(Required=false)]
            public string Message { get; set; }

            /// <summary>
            /// The name of the check item.
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// The reference value.
            /// </summary>
            [NameInMap("refer")]
            [Validation(Required=false)]
            public string Refer { get; set; }

            /// <summary>
            /// The value of the check item.
            /// </summary>
            [NameInMap("value")]
            [Validation(Required=false)]
            public string Value { get; set; }

        }

        /// <summary>
        /// The status code.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// Indicates whether the check is successful.
        /// </summary>
        [NameInMap("is_success")]
        [Validation(Required=false)]
        public bool? IsSuccess { get; set; }

        /// <summary>
        /// The request ID.
        /// </summary>
        [NameInMap("request_id")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
