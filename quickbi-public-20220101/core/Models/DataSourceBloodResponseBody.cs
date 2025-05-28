// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Quickbi_public20220101.Models
{
    public class DataSourceBloodResponseBody : TeaModel {
        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>46e537a5****,3dadsu****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Array of dataset IDs.</para>
        /// </summary>
        [NameInMap("Result")]
        [Validation(Required=false)]
        public List<string> Result { get; set; }

        /// <summary>
        /// <para>Indicates whether the request was successful. Possible values:</para>
        /// <list type="bullet">
        /// <item><description>true: The request was successful</description></item>
        /// <item><description>false: The request failed</description></item>
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
