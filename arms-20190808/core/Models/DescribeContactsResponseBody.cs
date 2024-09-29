// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeContactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The objects that were returned.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeContactsResponseBodyPageBean PageBean { get; set; }
        public class DescribeContactsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The alert contacts.</para>
            /// </summary>
            [NameInMap("AlertContacts")]
            [Validation(Required=false)]
            public List<DescribeContactsResponseBodyPageBeanAlertContacts> AlertContacts { get; set; }
            public class DescribeContactsResponseBodyPageBeanAlertContacts : TeaModel {
                /// <summary>
                /// <para>The ID of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>100147</para>
                /// </summary>
                [NameInMap("ArmsContactId")]
                [Validation(Required=false)]
                public long? ArmsContactId { get; set; }

                /// <summary>
                /// <para>The ID of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ContactId")]
                [Validation(Required=false)]
                public float? ContactId { get; set; }

                /// <summary>
                /// <para>The name of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>John Doe</para>
                /// </summary>
                [NameInMap("ContactName")]
                [Validation(Required=false)]
                public string ContactName { get; set; }

                /// <summary>
                /// <para>The email address of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:someone@example.com">someone@example.com</a></para>
                /// </summary>
                [NameInMap("Email")]
                [Validation(Required=false)]
                public string Email { get; set; }

                /// <summary>
                /// <para>Indicates whether the email address was verified.</para>
                /// 
                /// <b>Example:</b>
                /// <para>true</para>
                /// </summary>
                [NameInMap("IsEmailVerify")]
                [Validation(Required=false)]
                public bool? IsEmailVerify { get; set; }

                /// <summary>
                /// <para>Indicates whether the mobile number was verified. Valid values:</para>
                /// <list type="bullet">
                /// <item><description><c>false</c>: no</description></item>
                /// <item><description><c>true</c>: yes</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>false</para>
                /// </summary>
                [NameInMap("IsVerify")]
                [Validation(Required=false)]
                public bool? IsVerify { get; set; }

                /// <summary>
                /// <para>The mobile number of the alert contact.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1381111****</para>
                /// </summary>
                [NameInMap("Phone")]
                [Validation(Required=false)]
                public string Phone { get; set; }

                /// <summary>
                /// <para>The operation that you want to perform if phone calls fail to be answered. Valid values:</para>
                /// <list type="bullet">
                /// <item><description>0: No operation is performed.</description></item>
                /// <item><description>1: A phone call is made again.</description></item>
                /// <item><description>2: A text message is sent.</description></item>
                /// <item><description>3 (default value): The global default value is used.</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>3</para>
                /// </summary>
                [NameInMap("ReissueSendNotice")]
                [Validation(Required=false)]
                public long? ReissueSendNotice { get; set; }

            }

            /// <summary>
            /// <para>The page number of the returned page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Page")]
            [Validation(Required=false)]
            public long? Page { get; set; }

            /// <summary>
            /// <para>The number of alert contacts returned per page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of alert contacts.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1</para>
            /// </summary>
            [NameInMap("Total")]
            [Validation(Required=false)]
            public long? Total { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>21E85B16-75A6-429A-9F65-8AAC9A54****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
