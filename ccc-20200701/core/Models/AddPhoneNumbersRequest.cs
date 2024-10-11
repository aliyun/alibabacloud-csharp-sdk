// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CCC20200701.Models
{
    public class AddPhoneNumbersRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>dDMD_0mif4hv</para>
        /// </summary>
        [NameInMap("ContactFlowId")]
        [Validation(Required=false)]
        public string ContactFlowId { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ccc-test</para>
        /// </summary>
        [NameInMap("InstanceId")]
        [Validation(Required=false)]
        public string InstanceId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>2cb77c29-5f60-4b90-b21e-9d2ba9833f14</para>
        /// </summary>
        [NameInMap("NumberGroupId")]
        [Validation(Required=false)]
        public string NumberGroupId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>[&quot;0101234****&quot;, &quot;0105678****&quot;]</para>
        /// </summary>
        [NameInMap("NumberList")]
        [Validation(Required=false)]
        public string NumberList { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Bidirection</para>
        /// </summary>
        [NameInMap("Usage")]
        [Validation(Required=false)]
        public string Usage { get; set; }

    }

}
