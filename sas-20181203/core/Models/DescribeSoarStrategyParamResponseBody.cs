// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeSoarStrategyParamResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameters of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;summary&quot;:[{&quot;name&quot;:&quot;email&quot;,&quot;type&quot;:&quot;String&quot;,&quot;isRequired&quot;:false,&quot;fromProperty&quot;:&quot;notifyConfig.email&quot;}]}</para>
        /// </summary>
        [NameInMap("Params")]
        [Validation(Required=false)]
        public string Params { get; set; }

        /// <summary>
        /// <para>The process information of the policy.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;edges&quot;:[{&quot;level&quot;:0,&quot;removeFlag&quot;:0,&quot;source&quot;:1,&quot;target&quot;:8}]}</para>
        /// </summary>
        [NameInMap("ProcessInfo")]
        [Validation(Required=false)]
        public string ProcessInfo { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>6673D49C-A9AB-40DD-B4A2-B92306701AE7</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
