// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class ModifyCustomCallTaggingRequest : TeaModel {
        /// <summary>
        /// <para>A list of number tag names. You must provide the complete list of number tags to be modified, and ensure that these number tags have already been created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>[&quot;TagA&quot;,&quot;TagB&quot;]</para>
        /// </summary>
        [NameInMap("CallTagNameList")]
        [Validation(Required=false)]
        public string CallTagNameList { get; set; }

        /// <summary>
        /// <para>The new description for the inbound number mark. This parameter is optional. The default value is empty, which indicates that the description will not be modified.</para>
        /// 
        /// <b>Example:</b>
        /// <para>王先生</para>
        /// </summary>
        [NameInMap("Description")]
        [Validation(Required=false)]
        public string Description { get; set; }

        /// <summary>
        /// <para>The instance ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The number associated with the inbound number mark. The system matches the inbound number mark to be modified based on this number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1312121****</para>
        /// </summary>
        [NameInMap("Number")]
        [Validation(Required=false)]
        public string Number { get; set; }

    }

}
