// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayErrorAccessLogsRequest : TeaModel {
        /// <summary>
        /// <para>The domain name filter. This parameter performs an exact match against the authority field in Simple Log Service (SLS).</para>
        /// 
        /// <b>Example:</b>
        /// <para>api.example.com</para>
        /// </summary>
        [NameInMap("authority")]
        [Validation(Required=false)]
        public string Authority { get; set; }

        /// <summary>
        /// <para>The end of the query window, in UNIX seconds. The value cannot be later than the current time, and the time span cannot exceed 24 hours.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1756348800</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <para>The gateway request ID (x-acs-request-id) for exact match filtering.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E5D4xxxx</para>
        /// </summary>
        [NameInMap("gatewayRequestId")]
        [Validation(Required=false)]
        public string GatewayRequestId { get; set; }

        /// <summary>
        /// <para>The request path filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>/api/v1/pets</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <para>The HTTP error code. Only three-digit numbers in the 400–599 range are accepted. This parameter is required. If you do not specify this parameter, the API returns InvalidParameter.WithDetail (400).</para>
        /// 
        /// <b>Example:</b>
        /// <para>502</para>
        /// </summary>
        [NameInMap("responseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// <para>The route name filter.</para>
        /// 
        /// <b>Example:</b>
        /// <para>my-route</para>
        /// </summary>
        [NameInMap("routeName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
        /// <para>The start of the query window, in UNIX seconds. The value must be no earlier than 24 hours before the current time.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1756262400</para>
        /// </summary>
        [NameInMap("startTime")]
        [Validation(Required=false)]
        public long? StartTime { get; set; }

    }

}
