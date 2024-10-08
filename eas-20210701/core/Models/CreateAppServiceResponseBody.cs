// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Eas20210701.Models
{
    public class CreateAppServiceResponseBody : TeaModel {
        /// <summary>
        /// <para>The public endpoint of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://pai-eas.cn-shanghai">http://pai-eas.cn-shanghai</a>.****</para>
        /// </summary>
        [NameInMap("InternetEndpoint")]
        [Validation(Required=false)]
        public string InternetEndpoint { get; set; }

        /// <summary>
        /// <para>The internal endpoint of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para><a href="http://pai-eas-vpc.cn-shanghai">http://pai-eas-vpc.cn-shanghai</a>.****</para>
        /// </summary>
        [NameInMap("IntranetEndpoint")]
        [Validation(Required=false)]
        public string IntranetEndpoint { get; set; }

        /// <summary>
        /// <para>The region ID of the service.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-shanghai</para>
        /// </summary>
        [NameInMap("Region")]
        [Validation(Required=false)]
        public string Region { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>40325405-579C-4D82****</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The service ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>eas-m-aaxxxddf</para>
        /// </summary>
        [NameInMap("ServiceId")]
        [Validation(Required=false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// <para>The service name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>foo</para>
        /// </summary>
        [NameInMap("ServiceName")]
        [Validation(Required=false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// <para>The service state.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Creating</para>
        /// </summary>
        [NameInMap("Status")]
        [Validation(Required=false)]
        public string Status { get; set; }

    }

}
