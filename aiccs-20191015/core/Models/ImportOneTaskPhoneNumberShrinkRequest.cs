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
        /// <para>The external ID. We recommend that you use a unique ID to ensure idempotency. The value cannot exceed 128 characters.</para>
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
        /// <para>The phone number of the callee.</para>
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
        /// <para>A list of variables in a map.</para>
        /// <remarks>
        /// <para>The format of variables for an engine-based call task is as follows:</para>
        /// <list type="bullet">
        /// <item><description>{&quot;startWordParam.variable_key1&quot;:&quot;variable_value1&quot;,&quot;promptParam.variable_key2&quot;:&quot;variable_value2&quot;,&quot;bizParam.variable_key3&quot;:&quot;variable_value3&quot;}</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;变量key1&quot;:&quot;变量值1&quot;,&quot;变量key2&quot;:&quot;变量值2&quot;}
        /// 引擎呼叫任务示例值请看左侧描述</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public string VariablesShrink { get; set; }

    }

}
