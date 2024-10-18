// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aliding20230426.Models
{
    public class ListDriveSpacesResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>fekaf</para>
        /// </summary>
        [NameInMap("nextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>0FAAEC9C-C6C8-5C87-AF8E-1195889BBXXX</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        [NameInMap("spaces")]
        [Validation(Required=false)]
        public List<ListDriveSpacesResponseBodySpaces> Spaces { get; set; }
        public class ListDriveSpacesResponseBodySpaces : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>2016-02-28T10:47:08Z</para>
            /// </summary>
            [NameInMap("CreateTime")]
            [Validation(Required=false)]
            public string CreateTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2016-02-28T10:47:08Z</para>
            /// </summary>
            [NameInMap("ModifyTime")]
            [Validation(Required=false)]
            public string ModifyTime { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>acl</para>
            /// </summary>
            [NameInMap("PermissionMode")]
            [Validation(Required=false)]
            public string PermissionMode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>2147483648</para>
            /// </summary>
            [NameInMap("Quota")]
            [Validation(Required=false)]
            public long? Quota { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>123456789</para>
            /// </summary>
            [NameInMap("SpaceId")]
            [Validation(Required=false)]
            public string SpaceId { get; set; }

            [NameInMap("SpaceName")]
            [Validation(Required=false)]
            public string SpaceName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>org</para>
            /// </summary>
            [NameInMap("SpaceType")]
            [Validation(Required=false)]
            public string SpaceType { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>640445953</para>
            /// </summary>
            [NameInMap("UsedQuota")]
            [Validation(Required=false)]
            public long? UsedQuota { get; set; }

        }

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
