// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ARMS20190808.Models
{
    public class DescribeContactGroupsResponseBody : TeaModel {
        /// <summary>
        /// <para>The objects that were returned.</para>
        /// </summary>
        [NameInMap("PageBean")]
        [Validation(Required=false)]
        public DescribeContactGroupsResponseBodyPageBean PageBean { get; set; }
        public class DescribeContactGroupsResponseBodyPageBean : TeaModel {
            /// <summary>
            /// <para>The name of the alert contact group.</para>
            /// </summary>
            [NameInMap("AlertContactGroups")]
            [Validation(Required=false)]
            public List<DescribeContactGroupsResponseBodyPageBeanAlertContactGroups> AlertContactGroups { get; set; }
            public class DescribeContactGroupsResponseBodyPageBeanAlertContactGroups : TeaModel {
                /// <summary>
                /// <para>The ID of the alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>83261</para>
                /// </summary>
                [NameInMap("ArmsContactGroupId")]
                [Validation(Required=false)]
                public long? ArmsContactGroupId { get; set; }

                /// <summary>
                /// <para>The ID of the alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>123</para>
                /// </summary>
                [NameInMap("ContactGroupId")]
                [Validation(Required=false)]
                public float? ContactGroupId { get; set; }

                /// <summary>
                /// <para>The name of the alert contact group.</para>
                /// 
                /// <b>Example:</b>
                /// <para>TestGroup</para>
                /// </summary>
                [NameInMap("ContactGroupName")]
                [Validation(Required=false)]
                public string ContactGroupName { get; set; }

                /// <summary>
                /// <para>The contact information. If the <b>IsDetail</b> parameter is set to <c>false</c>, no <b>contact</b> information is displayed.</para>
                /// </summary>
                [NameInMap("Contacts")]
                [Validation(Required=false)]
                public List<DescribeContactGroupsResponseBodyPageBeanAlertContactGroupsContacts> Contacts { get; set; }
                public class DescribeContactGroupsResponseBodyPageBeanAlertContactGroupsContacts : TeaModel {
                    /// <summary>
                    /// <para>The ID of the alert contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>100117</para>
                    /// </summary>
                    [NameInMap("ArmsContactId")]
                    [Validation(Required=false)]
                    public long? ArmsContactId { get; set; }

                    /// <summary>
                    /// <para>The ID of the alert contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>456</para>
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
                    /// <para>The mobile number of the alert contact.</para>
                    /// 
                    /// <b>Example:</b>
                    /// <para>1381111****</para>
                    /// </summary>
                    [NameInMap("Phone")]
                    [Validation(Required=false)]
                    public string Phone { get; set; }

                }

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
            /// <para>The number of alert contact groups displayed on each page.</para>
            /// 
            /// <b>Example:</b>
            /// <para>20</para>
            /// </summary>
            [NameInMap("Size")]
            [Validation(Required=false)]
            public long? Size { get; set; }

            /// <summary>
            /// <para>The total number of alert contact groups.</para>
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
        /// <para>4D6C358A-A58B-4F4B-94CE-F5AAF023****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
