// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Safconsole20250521.Models
{
    public class CreateCustomerModuleMetaInfoResponseBody : TeaModel {
        /// <summary>
        /// <para>Status code. A return value of 200 indicates success.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("Code")]
        [Validation(Required=false)]
        public long? Code { get; set; }

        /// <summary>
        /// <para>HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public long? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>4A91D2D1-AEC9-1658-ABCE-5A39DE66A5C2</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The result indicating if the creation was successful:</para>
        /// <list type="bullet">
        /// <item><description>true: Success</description></item>
        /// <item><description>false: Failure</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ResultObject")]
        [Validation(Required=false)]
        public bool? ResultObject { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful, with values as follows:</para>
        /// <list type="bullet">
        /// <item><description>true, request succeeded</description></item>
        /// <item><description>false, request failed</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
