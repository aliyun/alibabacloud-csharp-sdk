// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class GrantSagInstanceToVbrResponseBody : TeaModel {
        /// <summary>
        /// <para>The ID of the authorization.</para>
        /// 
        /// <b>Example:</b>
        /// <para>sgv-3x8djyem7vqh70****</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>49CEBB2B-9E5C-4789-8A29-3255A56A67B1</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
