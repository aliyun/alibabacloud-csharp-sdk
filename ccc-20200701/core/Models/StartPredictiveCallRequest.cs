// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class StartPredictiveCallRequest : TeaModel {
        /// <summary>
        /// <para>The callee number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1312353****</para>
        /// </summary>
        [NameInMap("Callee")]
        [Validation(Required=false)]
        public string Callee { get; set; }

        /// <summary>
        /// <para>The caller number, which must be an active outbound number under the instance.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0109810****</para>
        /// </summary>
        [NameInMap("Caller")]
        [Validation(Required=false)]
        public string Caller { get; set; }

        /// <summary>
        /// <para>The IVR contact flow ID. After the callee answers, the call is automatically transferred into this IVR flow.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>9774c36c-12fe-4e37-adce-89bc77ce****</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// <para>The contact flow variables passed in as a JSON-formatted string of an array. Each array element is a key-value pair, where the key is the variable name and the value is the variable value. To use these variables in the IVR flow, create a Custom Parameter with the same name in the start node of the IVR associated with the specified contact flow ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;王先生&quot;,&quot;time&quot;:&quot;19点20分&quot;,&quot;address&quot;:&quot;某某中心&quot;}</para>
        /// </summary>
        [NameInMap("ContactFlowVariables")]
        [Validation(Required=false)]
        public string ContactFlowVariables { get; set; }

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
        /// <para>The desensitized callee number. If this field is not empty, it indicates that the callee number must be desensitized. The Desensitization Rule is defined by the Customer. Simply enter the desensitized callee number here. Using a desensitized callee number means that in certain scenarios, only the desensitized number is visible, and the real callee number cannot be viewed.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1312353****</para>
        /// </summary>
        [NameInMap("MaskedCallee")]
        [Validation(Required=false)]
        public string MaskedCallee { get; set; }

        /// <summary>
        /// <para>The skill group ID. This parameter is optional. If specified, the outbound number is selected only from the numbers associated with the specified skill group.</para>
        /// 
        /// <b>Example:</b>
        /// <para>skillgroup@ccc-test</para>
        /// </summary>
        [NameInMap("SkillGroupId")]
        [Validation(Required=false)]
        public string SkillGroupId { get; set; }

        /// <summary>
        /// <para>The ingest endpoint data, primarily used for extension purposes. Regular users do not need to concern themselves with this.</para>
        /// 
        /// <b>Example:</b>
        /// <para>无</para>
        /// </summary>
        [NameInMap("Tags")]
        [Validation(Required=false)]
        public string Tags { get; set; }

        /// <summary>
        /// <para>The timeout period, in seconds. If the call is not answered within the specified time, it is automatically disconnected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("TimeoutSeconds")]
        [Validation(Required=false)]
        public int? TimeoutSeconds { get; set; }

    }

}
