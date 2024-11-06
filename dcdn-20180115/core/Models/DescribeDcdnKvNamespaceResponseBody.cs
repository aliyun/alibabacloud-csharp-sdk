// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class DescribeDcdnKvNamespaceResponseBody : TeaModel {
        [NameInMap("Capacity")]
        [Validation(Required=false)]
        public long? Capacity { get; set; }

        /// <summary>
        /// <para>The available capacity of all namespaces in your account.</para>
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
        /// <para>The used capacity of all namespaces in your account.</para>
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
        /// <para>The system behavior when a key-value pair fails to be obtained at the edge. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>Normal (default): If a key-value pair fails to be obtained at the edge, DCDN attempts to query the key-value pair from the origin server to ensure global data consistency.</description></item>
        /// <item><description>Rapid: If a key-value pair fails to be obtained at the edge, an error message indicating that the key does not exist is returned. This feature enhances key-value query performance but may decrease the hit rate of queries. To enable this feature, submit a ticket.</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Normal</para>
        /// </summary>
        [NameInMap("Mode")]
        [Validation(Required=false)]
        public string Mode { get; set; }

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
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>D61E4801-EAFF-4A63-AAE1-FBF6CE1CFD1C</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

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

}
