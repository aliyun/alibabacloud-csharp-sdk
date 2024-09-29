// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ResourceDirectoryMaster20220419.Models
{
    public class ListMessageContactVerificationsResponseBody : TeaModel {
        /// <summary>
        /// <para>The record for the contact to be verified.</para>
        /// </summary>
        [NameInMap("ContactVerifications")]
        [Validation(Required=false)]
        public List<ListMessageContactVerificationsResponseBodyContactVerifications> ContactVerifications { get; set; }
        public class ListMessageContactVerificationsResponseBodyContactVerifications : TeaModel {
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
            /// <para>The object that is used for verification. Valid values:</para>
            /// <list type="bullet">
            /// <item><description>Mobile phone number</description></item>
            /// <item><description>Email address</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>someone***@example.com</para>
            /// </summary>
            [NameInMap("Target")]
            [Validation(Required=false)]
            public string Target { get; set; }

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
        /// <para>CD76D376-2517-4924-92C5-DBC52262F93A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of entries returned.</para>
        /// 
        /// <b>Example:</b>
        /// <para>48</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
