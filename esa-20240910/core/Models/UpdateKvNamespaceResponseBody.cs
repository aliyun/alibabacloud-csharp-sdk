// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class UpdateKvNamespaceResponseBody : TeaModel {
        /// <summary>
        /// <para>The description of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>this is a test ns.</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The updated name of the namespace.</para>
        /// 
        /// <b>Example:</b>
        /// <para>new_ns1</para>
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
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The status of the namespace. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>online</b>: normal.</description></item>
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
