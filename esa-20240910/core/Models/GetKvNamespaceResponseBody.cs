// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetKvNamespaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The available capacity of the namespace. Unit: bytes.</para>
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
        /// <para>The used capacity of the namespace. Unit: bytes.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10048576</para>
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
        /// <para>this is a test namespace.</para>
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
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>EEEBE525-F576-1196-8DAF-2D70CA3F4D2F</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the namespace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: working as expected.</description></item>
        /// <item><description><b>delete</b>: pending deletion.</description></item>
        /// <item><description><b>deleting</b>: being deleted.</description></item>
        /// <item><description><b>deleted</b>: deleted.</description></item>
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
