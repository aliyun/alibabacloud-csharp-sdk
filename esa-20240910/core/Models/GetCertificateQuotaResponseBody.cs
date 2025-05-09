// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.ESA20240910.Models
{
    public class GetCertificateQuotaResponseBody : TeaModel {
        /// <summary>
        /// <para>Free certificate quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("Quota")]
        [Validation(Required=false)]
        public long? Quota { get; set; }

        /// <summary>
        /// <para>Usage of free certificate quota.</para>
        /// 
        /// <b>Example:</b>
        /// <para>5</para>
        /// </summary>
        [NameInMap("QuotaUsage")]
        [Validation(Required=false)]
        public long? QuotaUsage { get; set; }

        /// <summary>
        /// <para>Request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>0AEDAF20-4DDF-4165-8750-47FF9C1929C9</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>Number of sites.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("SiteCount")]
        [Validation(Required=false)]
        public long? SiteCount { get; set; }

        /// <summary>
        /// <para>List of site usage details.</para>
        /// </summary>
        [NameInMap("SiteUsage")]
        [Validation(Required=false)]
        public List<GetCertificateQuotaResponseBodySiteUsage> SiteUsage { get; set; }
        public class GetCertificateQuotaResponseBodySiteUsage : TeaModel {
            /// <summary>
            /// <para>Site ID.</para>
            /// 
            /// <b>Example:</b>
            /// <para>165929521496928</para>
            /// </summary>
            [NameInMap("SiteId")]
            [Validation(Required=false)]
            public string SiteId { get; set; }

            /// <summary>
            /// <para>Site name.</para>
            /// 
            /// <b>Example:</b>
            /// <para>example.com</para>
            /// </summary>
            [NameInMap("SiteName")]
            [Validation(Required=false)]
            public string SiteName { get; set; }

            /// <summary>
            /// <para>Site usage.</para>
            /// 
            /// <b>Example:</b>
            /// <para>5</para>
            /// </summary>
            [NameInMap("SiteUsage")]
            [Validation(Required=false)]
            public long? SiteUsage { get; set; }

        }

        /// <summary>
        /// <para>Certificate Quota type.</para>
        /// 
        /// <b>Example:</b>
        /// <para>free</para>
        /// </summary>
        [NameInMap("Type")]
        [Validation(Required=false)]
        public string Type { get; set; }

    }

}
