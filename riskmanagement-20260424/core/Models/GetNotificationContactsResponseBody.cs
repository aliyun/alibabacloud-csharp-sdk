// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.RiskManagement20260424.Models
{
    public class GetNotificationContactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The status code.</para>
        /// <list type="bullet">
        /// <item><description><b>200</b>: Success.</description></item>
        /// <item><description><b>Other (400, 500)</b>: Failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The query result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public List<GetNotificationContactsResponseBodyData> Data { get; set; }
        public class GetNotificationContactsResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The Alibaba Cloud account ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1355290655619147</para>
            /// </summary>
            [NameInMap("AliUid")]
            [Validation(Required=false)]
            public long? AliUid { get; set; }

            /// <summary>
            /// <para>The message category code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod_edu_content</para>
            /// </summary>
            [NameInMap("CategoryCode")]
            [Validation(Required=false)]
            public string CategoryCode { get; set; }

            /// <summary>
            /// <para>The message category description.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product usage scenarios and technical sharing content.</para>
            /// </summary>
            [NameInMap("CategoryDesc")]
            [Validation(Required=false)]
            public string CategoryDesc { get; set; }

            /// <summary>
            /// <para>The category group code.</para>
            /// 
            /// <b>Example:</b>
            /// <para>prod_msg</para>
            /// </summary>
            [NameInMap("CategoryGroupCode")]
            [Validation(Required=false)]
            public string CategoryGroupCode { get; set; }

            /// <summary>
            /// <para>The category group name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product messages.</para>
            /// </summary>
            [NameInMap("CategoryGroupName")]
            [Validation(Required=false)]
            public string CategoryGroupName { get; set; }

            /// <summary>
            /// <para>The message category name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>Product educational content.</para>
            /// </summary>
            [NameInMap("CategoryName")]
            [Validation(Required=false)]
            public string CategoryName { get; set; }

            /// <summary>
            /// <para>The channel list.</para>
            /// </summary>
            [NameInMap("ChannelConfigs")]
            [Validation(Required=false)]
            public List<GetNotificationContactsResponseBodyDataChannelConfigs> ChannelConfigs { get; set; }
            public class GetNotificationContactsResponseBodyDataChannelConfigs : TeaModel {
                /// <summary>
                /// <para>The channel type.</para>
                /// 
                /// <b>Example:</b>
                /// <para>email</para>
                /// </summary>
                [NameInMap("ChannelType")]
                [Validation(Required=false)]
                public string ChannelType { get; set; }

                /// <summary>
                /// <para>Indicates whether the subscription is configured.</para>
                /// <list type="bullet">
                /// <item><description><b>NO</b></description></item>
                /// <item><description><b>YES</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NO</para>
                /// </summary>
                [NameInMap("CheckedState")]
                [Validation(Required=false)]
                public string CheckedState { get; set; }

                /// <summary>
                /// <para>Indicates whether the channel is selected by default.</para>
                /// <list type="bullet">
                /// <item><description><b>NO</b></description></item>
                /// <item><description><b>YES</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NO</para>
                /// </summary>
                [NameInMap("DefaultChecked")]
                [Validation(Required=false)]
                public string DefaultChecked { get; set; }

                /// <summary>
                /// <para>The fatigue limit.</para>
                /// 
                /// <b>Example:</b>
                /// <para>7</para>
                /// </summary>
                [NameInMap("FatigueDayLimit")]
                [Validation(Required=false)]
                public int? FatigueDayLimit { get; set; }

                /// <summary>
                /// <para>Indicates whether the channel is modifiable.</para>
                /// <list type="bullet">
                /// <item><description><b>NO</b></description></item>
                /// <item><description><b>YES</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>NO</para>
                /// </summary>
                [NameInMap("Optional")]
                [Validation(Required=false)]
                public string Optional { get; set; }

            }

            /// <summary>
            /// <para>Indicates whether all notification methods are selected.</para>
            /// <list type="bullet">
            /// <item><description><b>true</b></description></item>
            /// <item><description><b>false</b></description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>true</para>
            /// </summary>
            [NameInMap("ChooseAllChannel")]
            [Validation(Required=false)]
            public bool? ChooseAllChannel { get; set; }

            /// <summary>
            /// <para>The general contact list.</para>
            /// </summary>
            [NameInMap("ContactInfoList")]
            [Validation(Required=false)]
            public List<GetNotificationContactsResponseBodyDataContactInfoList> ContactInfoList { get; set; }
            public class GetNotificationContactsResponseBodyDataContactInfoList : TeaModel {
                /// <summary>
                /// <para>The Alibaba Cloud account ID.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1492387044070147</para>
                /// </summary>
                [NameInMap("AliUid")]
                [Validation(Required=false)]
                public long? AliUid { get; set; }

                /// <summary>
                /// <para>Indicates whether the contact is bound.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>fasle</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("BindContact")]
                [Validation(Required=false)]
                public bool? BindContact { get; set; }

                /// <summary>
                /// <para>The contact email address.</para>
                /// 
                /// <b>Example:</b>
                /// <para>t*@qq.*</para>
                /// </summary>
                [NameInMap("ContactEmail")]
                [Validation(Required=false)]
                public string ContactEmail { get; set; }

                /// <summary>
                /// <para>The Account Center contact ID. A value of 0 indicates the account contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>0</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public long? ContactId { get; set; }

                /// <summary>
                /// <para>The Account Center contact mobile number (masked).</para>
                /// 
                /// <b>Example:</b>
                /// <para>13580xxx136</para>
                /// </summary>
                [NameInMap("ContactMobile")]
                [Validation(Required=false)]
                public string ContactMobile { get; set; }

                /// <summary>
                /// <para>The Account Center contact name.</para>
                /// 
                /// <b>Example:</b>
                /// <para>shianyu</para>
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>Indicates whether the email address is verified.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("EmailConfirmed")]
                [Validation(Required=false)]
                public bool? EmailConfirmed { get; set; }

                /// <summary>
                /// <para>Indicates whether the Account Center contact mobile number is verified.</para>
                /// <list type="bullet">
                /// <item><description><b>true</b></description></item>
                /// <item><description><b>false</b></description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("MobileConfirmed")]
                [Validation(Required=false)]
                public bool? MobileConfirmed { get; set; }

                /// <summary>
                /// <para>The Account Center contact position.</para>
                /// 
                /// <b>Example:</b>
                /// <para>CEO</para>
                /// </summary>
                [NameInMap("Position")]
                [Validation(Required=false)]
                public string Position { get; set; }

            }

        }

        /// <summary>
        /// <para>The prompt message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>successful</para>
        /// </summary>
        [NameInMap("Message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2FBDD713-00A5-5C98-B661-3FD31A349B6E</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the operation is successful.</para>
        /// <list type="bullet">
        /// <item><description><b>true</b>: Success.</description></item>
        /// <item><description><b>false</b>: Failure.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
