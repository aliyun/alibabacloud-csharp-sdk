// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.AliGeniessp_1_0.Models
{
    public class ListSubAlbumRequest : TeaModel {
        [NameInMap("DeviceInfo")]
        [Validation(Required=false)]
        public ListSubAlbumRequestDeviceInfo DeviceInfo { get; set; }
        public class ListSubAlbumRequestDeviceInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

        /// <summary>
        /// <para>request</para>
        /// </summary>
        [NameInMap("QuerySubscriptionAlbumRequest")]
        [Validation(Required=false)]
        public ListSubAlbumRequestQuerySubscriptionAlbumRequest QuerySubscriptionAlbumRequest { get; set; }
        public class ListSubAlbumRequestQuerySubscriptionAlbumRequest : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>4476001</para>
            /// </summary>
            [NameInMap("AlbumId")]
            [Validation(Required=false)]
            public string AlbumId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// 
            /// <b>Example:</b>
            /// <para>80011</para>
            /// </summary>
            [NameInMap("CategoryId")]
            [Validation(Required=false)]
            public int? CategoryId { get; set; }

            /// <summary>
            /// <para>This parameter is required.</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public ListSubAlbumRequestQuerySubscriptionAlbumRequestPage Page { get; set; }
            public class ListSubAlbumRequestQuerySubscriptionAlbumRequestPage : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1</para>
                /// </summary>
                [NameInMap("PageNum")]
                [Validation(Required=false)]
                public int? PageNum { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>10</para>
                /// </summary>
                [NameInMap("PageSize")]
                [Validation(Required=false)]
                public int? PageSize { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>睡前故事</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        [NameInMap("UserInfo")]
        [Validation(Required=false)]
        public ListSubAlbumRequestUserInfo UserInfo { get; set; }
        public class ListSubAlbumRequestUserInfo : TeaModel {
            [NameInMap("EncodeKey")]
            [Validation(Required=false)]
            public string EncodeKey { get; set; }

            [NameInMap("EncodeType")]
            [Validation(Required=false)]
            public string EncodeType { get; set; }

            [NameInMap("Id")]
            [Validation(Required=false)]
            public string Id { get; set; }

            [NameInMap("IdType")]
            [Validation(Required=false)]
            public string IdType { get; set; }

            [NameInMap("OrganizationId")]
            [Validation(Required=false)]
            public string OrganizationId { get; set; }

        }

    }

}
