// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Mse20190531.Models
{
    public class AddAuthResourceRequest : TeaModel {
        /// <summary>
        /// The language of the response. Valid values:
        /// 
        /// *   zh: Chinese
        /// *   en: English
        /// </summary>
        [NameInMap("AcceptLanguage")]
        [Validation(Required=false)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// The ID of the authorization record.
        /// </summary>
        [NameInMap("AuthId")]
        [Validation(Required=false)]
        public long? AuthId { get; set; }

        /// <summary>
        /// The authentication resource headers.
        /// </summary>
        [NameInMap("AuthResourceHeaderList")]
        [Validation(Required=false)]
        public List<AddAuthResourceRequestAuthResourceHeaderList> AuthResourceHeaderList { get; set; }
        public class AddAuthResourceRequestAuthResourceHeaderList : TeaModel {
            /// <summary>
            /// The parameter of the HTTP header.
            /// </summary>
            [NameInMap("HeaderKey")]
            [Validation(Required=false)]
            public string HeaderKey { get; set; }

            /// <summary>
            /// The header matching mode.
            /// 
            /// Valid values:
            /// 
            /// *   SUFFIX
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   EXIST
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   PREFIX
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   EQUAL
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   EXCLUDE
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NOT_EQUAL
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   NOT_EXIST
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   REGREX
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            /// *   INCLUDE
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// 
            ///     <!-- -->
            /// </summary>
            [NameInMap("HeaderMethod")]
            [Validation(Required=false)]
            public string HeaderMethod { get; set; }

            /// <summary>
            /// The parameter value of the HTTP header.
            /// </summary>
            [NameInMap("HeaderValue")]
            [Validation(Required=false)]
            public string HeaderValue { get; set; }

        }

        /// <summary>
        /// The domain ID.
        /// </summary>
        [NameInMap("DomainId")]
        [Validation(Required=false)]
        public long? DomainId { get; set; }

        /// <summary>
        /// The unique ID of the gateway.
        /// </summary>
        [NameInMap("GatewayUniqueId")]
        [Validation(Required=false)]
        public string GatewayUniqueId { get; set; }

        /// <summary>
        /// Specifies whether the matching is not case-sensitive. Default value: true.
        /// </summary>
        [NameInMap("IgnoreCase")]
        [Validation(Required=false)]
        public bool? IgnoreCase { get; set; }

        /// <summary>
        /// The matching type. Valid values:
        /// 
        /// *   EQUAL
        /// *   PRE
        /// *   ERGULAR
        /// </summary>
        [NameInMap("MatchType")]
        [Validation(Required=false)]
        public string MatchType { get; set; }

        /// <summary>
        /// The path.
        /// </summary>
        [NameInMap("Path")]
        [Validation(Required=false)]
        public string Path { get; set; }

    }

}
