// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class ImportOneTaskPhoneNumberRequest : TeaModel {
        /// <summary>
        /// <para>The encryption method. Valid values:</para>
        /// <list type="bullet">
        /// <item><description>0: no encryption</description></item>
        /// <item><description>1: MD5</description></item>
        /// <item><description>2: SHA256</description></item>
        /// <item><description>3: SM3</description></item>
        /// </list>
        /// 
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
        /// <para>SampleValueSampleValueSampleValue</para>
        /// </summary>
        [NameInMap("Extension")]
        [Validation(Required=false)]
        public string Extension { get; set; }

        /// <summary>
        /// <para>The external serial number. Use a unique ID. The value cannot exceed 128 characters in length.</para>
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
        /// <para>The list of variables in map format.</para>
        /// <remarks>
        /// <para>Variable format for engine call tasks</para>
        /// <list type="bullet">
        /// <item><description>{&quot;startWordParam.variableKey1&quot;:&quot;variableValue1&quot;,&quot;promptParam.variableKey2&quot;:&quot;variableValue2&quot;,&quot;bizParam.variableKey3&quot;:&quot;variableValue3&quot;}</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;variableKey1&quot;:&quot;variableValue1&quot;,&quot;variableKey2&quot;:&quot;variableValue2&quot;}</para>
        /// </summary>
        [NameInMap("Variables")]
        [Validation(Required=false)]
        public Dictionary<string, object> Variables { get; set; }

    }

}
