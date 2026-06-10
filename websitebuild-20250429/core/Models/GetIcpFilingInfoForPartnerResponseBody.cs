// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.WebsiteBuild20250429.Models
{
    public class GetIcpFilingInfoForPartnerResponseBody : TeaModel {
        /// <summary>
        /// <para>Request result.</para>
        /// </summary>
        [NameInMap("Data")]
        [Validation(Required=false)]
        public GetIcpFilingInfoForPartnerResponseBodyData Data { get; set; }
        public class GetIcpFilingInfoForPartnerResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The ICP filing number associated with the domain name. Supports entity ICP filing numbers and website ICP filing numbers.</para>
            /// 
            /// <b>Example:</b>
            /// <para>京ICP备15023563号-3</para>
            /// </summary>
            [NameInMap("IcpNumber")]
            [Validation(Required=false)]
            public string IcpNumber { get; set; }

            /// <summary>
            /// <para>Whether the domain is filed for ICP</para>
            /// </summary>
            [NameInMap("Recorded")]
            [Validation(Required=false)]
            public bool? Recorded { get; set; }

            /// <summary>
            /// <para>The website ICP filing number corresponding to the domain name</para>
            /// 
            /// <b>Example:</b>
            /// <para>湘ICP备14011526号-3A</para>
            /// </summary>
            [NameInMap("SiteRecordNumber")]
            [Validation(Required=false)]
            public string SiteRecordNumber { get; set; }

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
