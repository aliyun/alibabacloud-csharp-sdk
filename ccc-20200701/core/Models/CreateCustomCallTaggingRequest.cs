// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class CreateCustomCallTaggingRequest : TeaModel {
        /// <summary>
        /// <para>A list of inbound control tags, formatted as a JSON array string. The number of array elements must be between 1 and 10,000. Each element in the array is an object with the following properties: number (must be a numeric string of 4 to 32 characters), description, and callTagNameList. The callTagNameList is an array whose elements are number labels (ensure that these number labels have already been created).</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[{&quot;number&quot;:&quot;1312121****&quot;,&quot;description&quot;:&quot;王先生&quot;,&quot;callTagNameList&quot;:[&quot;TagA&quot;]},{&quot;number&quot;:&quot;1388888****&quot;,&quot;description&quot;:&quot;张先生&quot;,&quot;callTagNameList&quot;:[&quot;TagB&quot;]}]</para>
        /// </summary>
        [NameInMap("CustomNumberList")]
        [Validation(Required=false)]
        public string CustomNumberList { get; set; }

        /// <summary>
        /// <para>Instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

    }

}
