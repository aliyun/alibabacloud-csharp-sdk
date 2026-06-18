// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class CreateKvNamespaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the KV namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test namespace.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The name of the KV namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>test_namespace</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>The ID of the KV namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>657717877171818496</para>
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
        /// <para>The status of the KV namespace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para><b>online</b>: The namespace is available.</para>
        /// </description></item>
        /// <item><description><para><b>delete</b>: The namespace is pending deletion.</para>
        /// </description></item>
        /// <item><description><para><b>deleting</b>: The namespace is being deleted.</para>
        /// </description></item>
        /// <item><description><para><b>deleted</b>: The namespace is deleted.</para>
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
