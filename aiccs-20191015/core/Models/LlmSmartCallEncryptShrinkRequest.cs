// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Aiccs20191015.Models
{
    public class LlmSmartCallEncryptShrinkRequest : TeaModel {
        /// <summary>
        /// <para>The code of the large language model application.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>AD******45</para>
        /// </summary>
        [NameInMap("ApplicationCode")]
        [Validation(Required=false)]
        public string ApplicationCode { get; set; }

        /// <summary>
        /// <para>The caller number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>132******65</para>
        /// </summary>
        [NameInMap("CallerNumber")]
        [Validation(Required=false)]
        public string CallerNumber { get; set; }

        /// <summary>
        /// <para>The encrypted called number.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>140*********243</para>
        /// </summary>
        [NameInMap("EncryptCalledNumber")]
        [Validation(Required=false)]
        public string EncryptCalledNumber { get; set; }

        /// <summary>
        /// <para>The custom outId specified by the customer.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dsa*******sad</para>
        /// </summary>
        [NameInMap("OutId")]
        [Validation(Required=false)]
        public string OutId { get; set; }

        [NameInMap("OwnerId")]
        [Validation(Required=false)]
        public long? OwnerId { get; set; }

        /// <summary>
        /// <para>The prompt parameters for the large language model application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;prompt&quot;:&quot;Recommend a movie&quot;}</para>
        /// </summary>
        [NameInMap("PromptParam")]
        [Validation(Required=false)]
        public string PromptParamShrink { get; set; }

        [NameInMap("ResourceOwnerAccount")]
        [Validation(Required=false)]
        public string ResourceOwnerAccount { get; set; }

        [NameInMap("ResourceOwnerId")]
        [Validation(Required=false)]
        public long? ResourceOwnerId { get; set; }

        /// <summary>
        /// <para>The greeting parameters for the large language model application.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;name&quot;:&quot;Xiao Ming&quot;,&quot;address&quot;:&quot;Hangzhou, Zhejiang&quot;}</para>
        /// </summary>
        [NameInMap("StartWordParam")]
        [Validation(Required=false)]
        public string StartWordParamShrink { get; set; }

    }

}
