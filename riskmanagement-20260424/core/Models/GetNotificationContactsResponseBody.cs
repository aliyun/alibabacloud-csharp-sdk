// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetNotificationContactsResponseBody : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetNotificationContactsResponseBodyData> Data { get; set; }
        public class GetNotificationContactsResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>1355290655619147</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod_edu_content</para>
            /// </summary>
            [NameInMap("CategoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>产品的使用场景、技术分享的相关内容</para>
            /// </summary>
            [NameInMap("CategoryDesc")]
            [Validation(Required=false)]
            public string CategoryDesc { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>prod_msg</para>
            /// </summary>
            [NameInMap("CategoryGroupCode")]
            [Validation(Required=false)]
            public string CategoryGroupCode { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>产品消息</para>
            /// </summary>
            [NameInMap("CategoryGroupName")]
            [Validation(Required=false)]
            public string CategoryGroupName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>产品教育内容</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            [NameInMap("ChannelConfigs")]
            [Validation(Required=false)]
            public List<GetNotificationContactsResponseBodyDataChannelConfigs> ChannelConfigs { get; set; }
            public class GetNotificationContactsResponseBodyDataChannelConfigs : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>email</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NO</para>
                /// </summary>
                [NameInMap("CheckedState")]
                [Validation(Required=false)]
                public string CheckedState { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NO</para>
                /// </summary>
                [NameInMap("DefaultChecked")]
                [Validation(Required=false)]
                public string DefaultChecked { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("FatigueDayLimit")]
                [Validation(Required=false)]
                public int? FatigueDayLimit { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>NO</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public string Optional { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChooseAllChannel")]
            [Validation(Required=false)]
            public bool? ChooseAllChannel { get; set; }

            [NameInMap("ContactInfoList")]
            [Validation(Required=false)]
            public List<GetNotificationContactsResponseBodyDataContactInfoList> ContactInfoList { get; set; }
            public class GetNotificationContactsResponseBodyDataContactInfoList : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1492387044070147</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BindContact")]
                [Validation(Required=false)]
                public bool? BindContact { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>t*@qq.*</para>
                /// </summary>
                [NameInMap("ContactEmail")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public long? ContactId { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>13580xxx136</para>
                /// </summary>
                [NameInMap("ContactMobile")]
                [Validation(Required=false)]
                public string ContactMobile { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>shianyu</para>
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EmailConfirmed")]
                [Validation(Required=false)]
                public bool? EmailConfirmed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MobileConfirmed")]
                [Validation(Required=false)]
                public bool? MobileConfirmed { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>CEO</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

            }

        }

        /// <summary>
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2FBDD713-00A5-5C98-B661-3FD31A349B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
