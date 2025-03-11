// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Drds20190123.Models
{
    public class ManagePrivateRdsResponseBody : TeaModel {
        /// <summary>
        /// <para>The parameter result set returned for the operation that is called for the custom ApsaraDB RDS instance.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{&quot;requestId&quot;:&quot;E63C810A-4A13-47B6-BA67-C0E23A******&quot;}</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public string Data { get; set; }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0237BCD2-2C7A-4F86-A766-657AF6******</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
