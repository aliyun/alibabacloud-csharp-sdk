/**
 *
 */
// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Retailadvqa20230417.Models
{
    public class AddMemberBasicInfoRequest : TeaModel {
        [NameInMap("body")]
        [Validation(Required=false)]
        public AddMemberBasicInfoRequestBody Body { get; set; }
        public class AddMemberBasicInfoRequestBody : TeaModel {
            [NameInMap("Area")]
            [Validation(Required=false)]
            public string Area { get; set; }

            [NameInMap("Avatar")]
            [Validation(Required=false)]
            public string Avatar { get; set; }

            [NameInMap("Birthday")]
            [Validation(Required=false)]
            public string Birthday { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("Channels")]
            [Validation(Required=false)]
            public List<AddMemberBasicInfoRequestBodyChannels> Channels { get; set; }
            public class AddMemberBasicInfoRequestBodyChannels : TeaModel {
                [NameInMap("AppId")]
                [Validation(Required=false)]
                public string AppId { get; set; }

                /// <summary>
                /// This parameter is required.
                /// </summary>
                [NameInMap("ChannelCode")]
                [Validation(Required=false)]
                public string ChannelCode { get; set; }

                [NameInMap("ChannelOpenId")]
                [Validation(Required=false)]
                public string ChannelOpenId { get; set; }

                [NameInMap("ChannelUnionId")]
                [Validation(Required=false)]
                public string ChannelUnionId { get; set; }

                [NameInMap("Scene")]
                [Validation(Required=false)]
                public string Scene { get; set; }

            }

            [NameInMap("City")]
            [Validation(Required=false)]
            public string City { get; set; }

            [NameInMap("Country")]
            [Validation(Required=false)]
            public string Country { get; set; }

            [NameInMap("Email")]
            [Validation(Required=false)]
            public string Email { get; set; }

            [NameInMap("Extra")]
            [Validation(Required=false)]
            public string Extra { get; set; }

            [NameInMap("GmtCreate")]
            [Validation(Required=false)]
            public string GmtCreate { get; set; }

            [NameInMap("MemberName")]
            [Validation(Required=false)]
            public string MemberName { get; set; }

            [NameInMap("MemberNickName")]
            [Validation(Required=false)]
            public string MemberNickName { get; set; }

            [NameInMap("MixMobile")]
            [Validation(Required=false)]
            public string MixMobile { get; set; }

            [NameInMap("Mobile")]
            [Validation(Required=false)]
            public string Mobile { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("OpenMerchantId")]
            [Validation(Required=false)]
            public string OpenMerchantId { get; set; }

            /// <summary>
            /// This parameter is required.
            /// </summary>
            [NameInMap("PlatFormType")]
            [Validation(Required=false)]
            public string PlatFormType { get; set; }

            [NameInMap("Province")]
            [Validation(Required=false)]
            public string Province { get; set; }

            [NameInMap("Sex")]
            [Validation(Required=false)]
            public string Sex { get; set; }

        }

    }

}
