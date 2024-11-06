// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dcdn20180115.Models
{
    public class CreateDcdnSLSRealTimeLogDeliveryResponseBody : TeaModel {
        /// <summary>
        /// <para>The configuration results of the domain name.</para>
        /// </summary>
        [NameInMap("Content")]
        [Validation(Required=false)]
        public CreateDcdnSLSRealTimeLogDeliveryResponseBodyContent Content { get; set; }
        public class CreateDcdnSLSRealTimeLogDeliveryResponseBodyContent : TeaModel {
            [NameInMap("Domains")]
            [Validation(Required=false)]
            public List<CreateDcdnSLSRealTimeLogDeliveryResponseBodyContentDomains> Domains { get; set; }
            public class CreateDcdnSLSRealTimeLogDeliveryResponseBodyContentDomains : TeaModel {
                /// <summary>
                /// <para>The description of the returned result.</para>
                /// 
                /// <b>Example:</b>
                /// <para>ok</para>
                /// </summary>
                [NameInMap("Desc")]
                [Validation(Required=false)]
                public string Desc { get; set; }

                /// <summary>
                /// <para>The domain name from which real-time logs were collected.</para>
                /// 
                /// <b>Example:</b>
                /// <para>example.com</para>
                /// </summary>
                [NameInMap("DomainName")]
                [Validation(Required=false)]
                public string DomainName { get; set; }

                /// <summary>
                /// <para>The region to which real-time logs were delivered.</para>
                /// 
                /// <b>Example:</b>
                /// <para>cn</para>
                /// </summary>
                [NameInMap("Region")]
                [Validation(Required=false)]
                public string Region { get; set; }

                /// <summary>
                /// <para>The status of real-time logs.</para>
                /// 
                /// <b>Example:</b>
                /// <para>success</para>
                /// </summary>
                [NameInMap("Status")]
                [Validation(Required=false)]
                public string Status { get; set; }

            }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>F32C57AA-7BF8-49AE-A2CC-9F42390F5A19</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
