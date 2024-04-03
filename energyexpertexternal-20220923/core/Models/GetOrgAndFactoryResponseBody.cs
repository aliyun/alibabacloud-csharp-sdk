// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.EnergyExpertExternal20220923.Models
{
    public class GetOrgAndFactoryResponseBody : TeaModel {
        /// <summary>
        /// The code returned for the request.
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// data
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public List<GetOrgAndFactoryResponseBodyData> Data { get; set; }
        public class GetOrgAndFactoryResponseBodyData : TeaModel {
            /// <summary>
            /// The ID of the Alibaba Cloud account.
            /// </summary>
            [NameInMap("aliyunPk")]
            [Validation(Required=false)]
            public string AliyunPk { get; set; }

            /// <summary>
            /// The sites.
            /// </summary>
            [NameInMap("factoryList")]
            [Validation(Required=false)]
            public List<GetOrgAndFactoryResponseBodyDataFactoryList> FactoryList { get; set; }
            public class GetOrgAndFactoryResponseBodyDataFactoryList : TeaModel {
                /// <summary>
                /// The ID of the site.
                /// </summary>
                [NameInMap("factoryId")]
                [Validation(Required=false)]
                public string FactoryId { get; set; }

                /// <summary>
                /// The name of the site.
                /// </summary>
                [NameInMap("factoryName")]
                [Validation(Required=false)]
                public string FactoryName { get; set; }

            }

            /// <summary>
            /// The ID of the organization.
            /// </summary>
            [NameInMap("organizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

            /// <summary>
            /// The name of the organization.
            /// </summary>
            [NameInMap("organizationName")]
            [Validation(Required=false)]
            public string OrganizationName { get; set; }

        }

        /// <summary>
        /// The HTTP status code.
        /// </summary>
        [NameInMap("httpCode")]
        [Validation(Required=false)]
        public int? HttpCode { get; set; }

        /// <summary>
        /// The ID of the request.
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// Indicates whether the request was successful.
        /// </summary>
        [NameInMap("success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
