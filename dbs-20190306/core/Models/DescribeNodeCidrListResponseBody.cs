// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dbs20190306.Models
{
    public class DescribeNodeCidrListResponseBody : TeaModel {
        /// <summary>
        /// <para>The error code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Param.NotFound</para>
        /// </summary>
        [NameInMap("ErrCode")]
        [Validation(Required=false)]
        public string ErrCode { get; set; }

        /// <summary>
        /// <para>The error message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>The specified parameter %s value is not valid.</para>
        /// </summary>
        [NameInMap("ErrMessage")]
        [Validation(Required=false)]
        public string ErrMessage { get; set; }

        /// <summary>
        /// <para>The HTTP status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>200</para>
        /// </summary>
        [NameInMap("HttpStatusCode")]
        [Validation(Required=false)]
        public int? HttpStatusCode { get; set; }

        /// <summary>
        /// <para>The public CIDR blocks.</para>
        /// </summary>
        [NameInMap("InternetIPs")]
        [Validation(Required=false)]
        public DescribeNodeCidrListResponseBodyInternetIPs InternetIPs { get; set; }
        public class DescribeNodeCidrListResponseBodyInternetIPs : TeaModel {
            [NameInMap("InternetIP")]
            [Validation(Required=false)]
            public List<string> InternetIP { get; set; }

        }

        /// <summary>
        /// <para>The internal CIDR blocks.</para>
        /// </summary>
        [NameInMap("IntranetIPs")]
        [Validation(Required=false)]
        public DescribeNodeCidrListResponseBodyIntranetIPs IntranetIPs { get; set; }
        public class DescribeNodeCidrListResponseBodyIntranetIPs : TeaModel {
            [NameInMap("IntranetIP")]
            [Validation(Required=false)]
            public List<string> IntranetIP { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5B352E69-E7B1-4EA7-BB8E-29FFE969C791</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Indicates whether the request is successful.</para>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("Success")]
        [Validation(Required=false)]
        public bool? Success { get; set; }

    }

}
