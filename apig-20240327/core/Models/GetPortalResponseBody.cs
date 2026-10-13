// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class GetPortalResponseBody : TeaModel {
        /// <summary>
        /// <para>The response status code.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Ok</para>
        /// </summary>
        [NameInMap("code")]
        [Validation(Required=false)]
        public string Code { get; set; }

        /// <summary>
        /// <para>The response data.</para>
        /// </summary>
        [NameInMap("data")]
        [Validation(Required=false)]
        public GetPortalResponseBodyData Data { get; set; }
        public class GetPortalResponseBodyData : TeaModel {
            /// <summary>
            /// <para>The creation time in ISO 8601 (RFC 3339) format in the UTC time zone, such as 2026-05-15T10:00:00Z.</para>
            /// 
            /// <b>Example:</b>
            /// <para>2026-05-15T10:00:00Z</para>
            /// </summary>
            [NameInMap("createdAt")]
            [Validation(Required=false)]
            public string CreatedAt { get; set; }

            /// <summary>
            /// <para>The portal description, which is the Description property of the portal resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>HiMarket portal for internal developers</para>
            /// </summary>
            [NameInMap("description")]
            [Validation(Required=false)]
            public string Description { get; set; }

            /// <summary>
            /// <para>The portal name, which is the Name property of the portal resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>developer-portal</para>
            /// </summary>
            [NameInMap("name")]
            [Validation(Required=false)]
            public string Name { get; set; }

            /// <summary>
            /// <para>The list of portal domain name configurations. The list element is named domainConfig.</para>
            /// </summary>
            [NameInMap("portalDomainConfig")]
            [Validation(Required=false)]
            public List<HiMarketPortalDomainConfig> PortalDomainConfig { get; set; }

            /// <summary>
            /// <para>The portal ID, which is the primary ID of the portal resource and points to the same portal as the portalId request parameter.</para>
            /// 
            /// <b>Example:</b>
            /// <para>portal-xxxxxxxx</para>
            /// </summary>
            [NameInMap("portalId")]
            [Validation(Required=false)]
            public string PortalId { get; set; }

            /// <summary>
            /// <para>The portal settings, including whether to enable username and password authentication, whether to automatically approve developer registrations, and whether to automatically approve subscription requests.</para>
            /// </summary>
            [NameInMap("portalSettingConfig")]
            [Validation(Required=false)]
            public HiMarketPortalSettingConfig PortalSettingConfig { get; set; }

            /// <summary>
            /// <para>The region ID, which is the RegionId property of the portal resource.</para>
            /// 
            /// <b>Example:</b>
            /// <para>cn-hangzhou</para>
            /// </summary>
            [NameInMap("regionId")]
            [Validation(Required=false)]
            public string RegionId { get; set; }

        }

        /// <summary>
        /// <para>The response message.</para>
        /// 
        /// <b>Example:</b>
        /// <para>success</para>
        /// </summary>
        [NameInMap("message")]
        [Validation(Required=false)]
        public string Message { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>393E2630-DBE7-5221-AB35-9E740675491A</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

    }

}
