// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetDomainInfoForPartnerResponseBody : TeaModel {
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetDomainInfoForPartnerResponseBodyData Data { get; set; }
        public class GetDomainInfoForPartnerResponseBodyData : TeaModel {
            /// <summary>
            /// <b>Example:</b>
            /// <para>playnew-alilive.daotantan.com</para>
            /// </summary>
            [NameInMap("DomainName")]
            [Validation(Required=false)]
            public string DomainName { get; set; }

            /// <summary>
            /// <b>Example:</b>
            /// <para>NS3.ALIYUN.COM,NS4.ALIYUN.COM</para>
            /// </summary>
            [NameInMap("NameServers")]
            [Validation(Required=false)]
            public string NameServers { get; set; }

            [NameInMap("Ownership")]
            [Validation(Required=false)]
            public GetDomainInfoForPartnerResponseBodyDataOwnership Ownership { get; set; }
            public class GetDomainInfoForPartnerResponseBodyDataOwnership : TeaModel {
                /// <summary>
                /// <b>Example:</b>
                /// <para>1189245564569485</para>
                /// </summary>
                [NameInMap("Account")]
                [Validation(Required=false)]
                public string Account { get; set; }

                /// <summary>
                /// <b>Example:</b>
                /// <para>pai</para>
                /// </summary>
                [NameInMap("Provider")]
                [Validation(Required=false)]
                public string Provider { get; set; }

            }

            /// <summary>
            /// <b>Example:</b>
            /// <para>aliyun</para>
            /// </summary>
            [NameInMap("Registrar")]
            [Validation(Required=false)]
            public string Registrar { get; set; }

        }

        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>6C6B99AC-39EC-5350-874C-204128C905E6</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
