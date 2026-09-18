// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ImportOneTaskPhoneNumberShrinkRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>81</para>
        /// </summary>
        [NameInMap("EncryptionType")]
        [Validation(Required=false)]
        public long? EncryptionType { get; set; }

        /// <summary>
        /// <para>The extension number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>示例值示例值示例值</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>The external serial number. We recommend that you use a unique ID. The value cannot exceed 128 characters.</para>
        /// 
        /// <b>Example:</b>
        /// <para>94ba739b-xxxx-ef91-335d-4be006c34899</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The called phone number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>180******</para>
        /// </summary>
        [NameInMap("PhoneNumber")]
        [Validation(Required=false)]
        public string PhoneNumber { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The task ID.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1231231212****</para>
        /// </summary>
        [NameInMap("TaskId")]
        [Validation(Required=false)]
        public long? TaskId { get; set; }

        /// <summary>
        /// <para>The variable list in Map format.</para>
        /// <remarks>
        /// <para>Variable format for engine-based voice call tasks:</para>
        /// <list type="bullet">
        /// <item><description>{&quot;startWordParam.VariableKey1&quot;:&quot;VariableValue1&quot;,&quot;promptParam.VariableKey2&quot;:&quot;VariableValue2&quot;,&quot;bizParam.VariableKey3&quot;:&quot;VariableValue3&quot;}</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;VariableKey1&quot;:&quot;VariableValue1&quot;,&quot;VariableKey2&quot;:&quot;VariableValue2&quot;}
        /// For example values of engine-based voice call tasks, refer to the description on the left</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string VariablesShrink { get; set; }

    }

}
