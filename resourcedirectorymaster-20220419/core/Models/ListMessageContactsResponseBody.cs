// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListMessageContactsResponseBody : TeaModel {
        /// <summary>
        /// <para>The time when the contact was bound to the objects.</para>
        /// </summary>
        [NameInMap("Contacts")]
        [Validation(Required=false)]
        public List<ListMessageContactsResponseBodyContacts> Contacts { get; set; }
        public class ListMessageContactsResponseBodyContacts : TeaModel {
            /// <summary>
            /// <para>The time when the contact was bound to the objects.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-27 17:19:21</para>
            /// </summary>
            [NameInMap("AssociatedDate")]
            [Validation(Required=false)]
            public string AssociatedDate { get; set; }

            /// <summary>
            /// <para>The ID of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>c-qL4HqKONzOM7****</para>
            /// </summary>
            [NameInMap("ContactId")]
            [Validation(Required=false)]
            public string ContactId { get; set; }

            /// <summary>
            /// <para>The time when the contact was added.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2023-03-27 17:19:21</para>
            /// </summary>
            [NameInMap("CreateDate")]
            [Validation(Required=false)]
            public string CreateDate { get; set; }

            /// <summary>
            /// <para>The email address of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>someone***@example.com</para>
            /// </summary>
            [NameInMap("EmailAddress")]
            [Validation(Required=false)]
            public string EmailAddress { get; set; }

            /// <summary>
            /// <para>The IDs of objects to which the contact is bound.</para>
            /// </summary>
            [NameInMap("Members")]
            [Validation(Required=false)]
            public List<string> Members { get; set; }

            /// <summary>
            /// <para>The types of messages received by the contact.</para>
            /// </summary>
            [NameInMap("MessageTypes")]
            [Validation(Required=false)]
            public List<string> MessageTypes { get; set; }

            /// <summary>
            /// <para>The name of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>tom</para>
            /// </summary>
            [NameInMap("Name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The mobile phone number of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>86-139****1234</para>
            /// </summary>
            [NameInMap("PhoneNumber")]
            [Validation(Required=false)]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// <para>The status of the contact. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Verifying</description></item>
            /// <item><description>Active</description></item>
            /// <item><description>Deleting</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>Active</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

            /// <summary>
            /// <para>The job title of the contact.</para>
            /// 
            /// <b>Example:</b>
            /// <para>TechnicalDirector</para>
            /// </summary>
            [NameInMap("Title")]
            [Validation(Required=false)]
            public string Title { get; set; }

        }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>95060F1D-6990-4645-8920-A81D1BBFE992</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>20</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
