// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetKvAccountResponseBody : TeaModel {
        /// <summary>
        /// <para>The total available capacity of all namespaces for the account, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1073741824</para>
        /// </summary>
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The total available capacity of all namespaces for the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1 GB</para>
        /// </summary>
        [NameInMap("CapacityString")]
        [Validation(Required=false)]
        public string CapacityString { get; set; }

        /// <summary>
        /// <para>The total used capacity of all namespaces for the account, in bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10048576</para>
        /// </summary>
        [NameInMap("CapacityUsed")]
        [Validation(Required=false)]
        public long? CapacityUsed { get; set; }

        /// <summary>
        /// <para>The total used capacity of all namespaces for the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>100 MB</para>
        /// </summary>
        [NameInMap("CapacityUsedString")]
        [Validation(Required=false)]
        public string CapacityUsedString { get; set; }

        /// <summary>
        /// <para>The list of namespaces for the account.</para>
        /// </summary>
        [NameInMap("NamespaceList")]
        [Validation(Required=false)]
        public List<GetKvAccountResponseBodyNamespaceList> NamespaceList { get; set; }
        public class GetKvAccountResponseBodyNamespaceList : TeaModel {
            /// <summary>
            /// <para>The available capacity of the namespace, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1073741824</para>
            /// </summary>
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

            /// <summary>
            /// <para>The used capacity of the namespace, in bytes.</para>
            /// 
            /// <b>Example:</b>
            /// <para>100048576</para>
            /// </summary>
            [NameInMap("CapacityUsed")]
            [Validation(Required=false)]
            public long? CapacityUsed { get; set; }

            /// <summary>
            /// <para>The used capacity of the namespace.</para>
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
            /// <para>test_namespace</para>
            /// </summary>
            [NameInMap("Namespace")]
            [Validation(Required=false)]
            public string Namespace { get; set; }

            /// <summary>
            /// <para>The ID of the namespace.</para>
            /// 
            /// <b>Example:</b>
            /// <para>643355322374688768</para>
            /// </summary>
            [NameInMap("NamespaceId")]
            [Validation(Required=false)]
            public string NamespaceId { get; set; }

            /// <summary>
            /// <para>The status of the namespace. Valid values:</para>
            /// <list type="bullet">
            /// <item><description><para><b>online</b>: Normal.</para>
            /// </description></item>
            /// <item><description><para><b>delete</b>: Pending deletion.</para>
            /// </description></item>
            /// <item><description><para><b>deleting</b>: Being deleted.</para>
            /// </description></item>
            /// <item><description><para><b>deleted</b>: Deleted.</para>
            /// </description></item>
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
        /// <para>The quota on the number of KV storage spaces that you can request for the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("NamespaceQuota")]
        [Validation(Required=false)]
        public int? NamespaceQuota { get; set; }

        /// <summary>
        /// <para>The number of namespaces created for the account.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("NamespaceUsed")]
        [Validation(Required=false)]
        public int? NamespaceUsed { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the account.</para>
        /// <list type="bullet">
        /// <item><description><para><b>online</b>: The account is active.</para>
        /// </description></item>
        /// <item><description><para><b>offline</b>: The account is shut down.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>online</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
