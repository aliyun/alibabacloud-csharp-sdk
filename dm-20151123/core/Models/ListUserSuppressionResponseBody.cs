// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dm20151123.Models
{
    public class ListUserSuppressionResponseBody : TeaModel {
        /// <summary>
        /// <para>Returned results.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public ListUserSuppressionResponseBodyData Data { get; set; }
        public class ListUserSuppressionResponseBodyData : TeaModel {
            [NameInMap("UserSuppressions")]
            [Validation(Required=false)]
            public List<ListUserSuppressionResponseBodyDataUserSuppressions> UserSuppressions { get; set; }
            public class ListUserSuppressionResponseBodyDataUserSuppressions : TeaModel {
                /// <summary>
                /// <para>Email address or domain name</para>
                /// 
                /// <b>Example:</b>
                /// <para><a href="mailto:test@example.net">test@example.net</a></para>
                /// </summary>
                [NameInMap("Address")]
                [Validation(Required=false)]
                public string Address { get; set; }

                /// <summary>
                /// <para>Creation time, timestamp, accurate to the second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715667435</para>
                /// </summary>
                [NameInMap("CreateTime")]
                [Validation(Required=false)]
                public int? CreateTime { get; set; }

                /// <summary>
                /// <para>Last bounce hit time, timestamp, accurate to the second.</para>
                /// 
                /// <b>Example:</b>
                /// <para>1715667451</para>
                /// </summary>
                [NameInMap("LastBounceTime")]
                [Validation(Required=false)]
                public int? LastBounceTime { get; set; }

                /// <summary>
                /// <para>Invalid address ID</para>
                /// 
                /// <b>Example:</b>
                /// <para>59511</para>
                /// </summary>
                [NameInMap("SuppressionId")]
                [Validation(Required=false)]
                public int? SuppressionId { get; set; }

                /// <summary>
                /// <para>Source of entry, invalid address type</para>
                /// <list type="bullet">
                /// <item><description>system</description></item>
                /// <item><description>user</description></item>
                /// </list>
                /// 
                /// <b>Example:</b>
                /// <para>user</para>
                /// </summary>
                [NameInMap("Type")]
                [Validation(Required=false)]
                public string Type { get; set; }

            }

        }

        /// <summary>
        /// <para>Page number</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("PageNumber")]
        [Validation(Required=false)]
        public int? PageNumber { get; set; }

        /// <summary>
        /// <para>Page size</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("PageSize")]
        [Validation(Required=false)]
        public int? PageSize { get; set; }

        /// <summary>
        /// <para>Request ID</para>
        /// 
        /// <b>Example:</b>
        /// <para>1A846D66-5EC7-551B-9687-5BF1963DCFC1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Total count</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
