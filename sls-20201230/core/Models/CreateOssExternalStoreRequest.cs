// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sls20201230.Models
{
    public class CreateOssExternalStoreRequest : TeaModel {
        /// <summary>
        /// The name of the external store.
        /// </summary>
        [NameInMap("externalStoreName")]
        [Validation(Required=false)]
        public string ExternalStoreName { get; set; }

        /// <summary>
        /// The parameters that are configured for the external store.
        /// </summary>
        [NameInMap("parameter")]
        [Validation(Required=false)]
        public CreateOssExternalStoreRequestParameter Parameter { get; set; }
        public class CreateOssExternalStoreRequestParameter : TeaModel {
            /// <summary>
            /// The AccessKey ID of your account.
            /// </summary>
            [NameInMap("accessid")]
            [Validation(Required=false)]
            public string Accessid { get; set; }

            /// <summary>
            /// The AccessKey secret of your account.
            /// </summary>
            [NameInMap("accesskey")]
            [Validation(Required=false)]
            public string Accesskey { get; set; }

            /// <summary>
            /// The name of the OSS bucket.
            /// </summary>
            [NameInMap("bucket")]
            [Validation(Required=false)]
            public string Bucket { get; set; }

            /// <summary>
            /// The associated fields.
            /// </summary>
            [NameInMap("columns")]
            [Validation(Required=false)]
            public List<CreateOssExternalStoreRequestParameterColumns> Columns { get; set; }
            public class CreateOssExternalStoreRequestParameterColumns : TeaModel {
                /// <summary>
                /// The name of the field.
                /// </summary>
                [NameInMap("name")]
                [Validation(Required=false)]
                public string Name { get; set; }

                /// <summary>
                /// The type of the field.
                /// </summary>
                [NameInMap("type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            /// <summary>
            /// The OSS endpoint.
            /// </summary>
            [NameInMap("endpoint")]
            [Validation(Required=false)]
            public string Endpoint { get; set; }

            /// <summary>
            /// The associated objects.
            /// </summary>
            [NameInMap("objects")]
            [Validation(Required=false)]
            public List<string> Objects { get; set; }

        }

        /// <summary>
        /// The type of the external store. Set the value to oss.
        /// </summary>
        [NameInMap("storeType")]
        [Validation(Required=false)]
        public string StoreType { get; set; }

    }

}
