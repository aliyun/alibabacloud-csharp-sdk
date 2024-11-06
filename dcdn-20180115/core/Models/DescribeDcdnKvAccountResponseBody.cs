// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnKvAccountResponseBody : TeaModel {
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The available capacity of all namespaces.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2GB</para>
        /// </summary>
        [NameInMap("CapacityString")]
        [Validation(Required=false)]
        public string CapacityString { get; set; }

        [NameInMap("CapacityUsed")]
        [Validation(Required=false)]
        public long? CapacityUsed { get; set; }

        /// <summary>
        /// <para>All namespaces have used capacity.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200 MB</para>
        /// </summary>
        [NameInMap("CapacityUsedString")]
        [Validation(Required=false)]
        public string CapacityUsedString { get; set; }

        /// <summary>
        /// <para>Details about the namespaces.</para>
        /// </summary>
        [NameInMap("NamespaceList")]
        [Validation(Required=false)]
        public List<DescribeDcdnKvAccountResponseBodyNamespaceList> NamespaceList { get; set; }
        public class DescribeDcdnKvAccountResponseBodyNamespaceList : TeaModel {
            [NameInMap("Capacity")]
            [Validation(Required=false)]
            public long? Capacity { get; set; }

            /// <summary>
            /// <para>The available capacity of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1 GB</para>
            /// </summary>
            [NameInMap("CapacityString")]
            [Validation(Required=false)]
            public string CapacityString { get; set; }

            [NameInMap("CapacityUsed")]
            [Validation(Required=false)]
            public long? CapacityUsed { get; set; }

            /// <summary>
            /// <para>The namespace has used capacity.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100 MB</para>
            /// </summary>
            [NameInMap("CapacityUsedString")]
            [Validation(Required=false)]
            public string CapacityUsedString { get; set; }

            /// <summary>
            /// <para>The description of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>the first namespace</para>
            /// </summary>
            [NameInMap("Description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The name of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>ns1</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>12423131231****</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The status of the namespace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><b>online</b>: normal</description></item>
            /// <item><description><b>delete</b>: pending delete</description></item>
            /// <item><description><b>deleting</b>: being deleted</description></item>
            /// <item><description><b>deleted</b>: deleted</description></item>
            /// </list>
            /// 
            /// <b>Example:</b>
            /// <para>online</para>
            /// </summary>
            [NameInMap("Status")]
            [Validation(Required=false)]
            public string Status { get; set; }

        }

        /// <summary>
        /// <para>The maximum number of namespaces that you can apply for by using your account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NamespaceQuota")]
        [Validation(Required=false)]
        public int? NamespaceQuota { get; set; }

        /// <summary>
        /// <para>The number of namespaces that you applied for by using your account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NamespaceUsed")]
        [Validation(Required=false)]
        public int? NamespaceUsed { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D61E4801-EAFF-4A63-AAE1-FBF6CE1CFD1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the account.</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: enabled</description></item>
        /// <item><description><b>offline</b>: disabled</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online,offline</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
