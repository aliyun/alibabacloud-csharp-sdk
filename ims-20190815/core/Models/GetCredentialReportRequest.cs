// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Ims20190815.Models
{
    public class GetCredentialReportRequest : TeaModel {
        /// <summary>
        /// <para>The number of entries per page. If a response is truncated because it reaches the value of <c>MaxItems</c>, the value of <c>IsTruncated</c> will be true.</para>
        /// <para>Valid values: 1 to 3501. Default value: 3501.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("MaxItems")]
        [Validation(Required=false)]
        public string MaxItems { get; set; }

        /// <summary>
        /// <para>The token that is used to initiate the next request if the response of the current request is truncated. You can use the token to initiate another request and obtain the remaining records.``</para>
        /// 
        /// <b>Example:</b>
        /// <para>EXAMPLE</para>
        /// </summary>
        [NameInMap("NextToken")]
        [Validation(Required=false)]
        public string NextToken { get; set; }

    }

}
