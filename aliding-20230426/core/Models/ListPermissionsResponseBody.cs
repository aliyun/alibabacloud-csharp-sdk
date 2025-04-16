// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListPermissionsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>59886</para>
        /// </summary>
        [NameInMap("duration")]
        [Validation(Required=false)]
        public long? Duration { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        [NameInMap("permissions")]
        [Validation(Required=false)]
        public List<ListPermissionsResponseBodyPermissions> Permissions { get; set; }
        public class ListPermissionsResponseBodyPermissions : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>123456</para>
            /// </summary>
            [NameInMap("DentryUuid")]
            [Validation(Required=false)]
            public string DentryUuid { get; set; }

            [NameInMap("Member")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsMember Member { get; set; }
            public class ListPermissionsResponseBodyPermissionsMember : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("CorpId")]
                [Validation(Required=false)]
                public string CorpId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>123456</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>ORG</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

            [NameInMap("Role")]
            [Validation(Required=false)]
            public ListPermissionsResponseBodyPermissionsRole Role { get; set; }
            public class ListPermissionsResponseBodyPermissionsRole : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>OWNER</para>
                /// </summary>
                [NameInMap("Id")]
                [Validation(Required=false)]
                public string Id { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>拥有者</para>
                /// </summary>
                [NameInMap("Name")]
                [Validation(Required=false)]
                public string Name { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("vendorRequestId")]
        [Validation(Required=false)]
        public string VendorRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>dingtalk</para>
        /// </summary>
        [NameInMap("vendorType")]
        [Validation(Required=false)]
        public string VendorType { get; set; }

    }

}
