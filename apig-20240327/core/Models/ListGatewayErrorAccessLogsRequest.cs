// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.APIG20240327.Models
{
    public class ListGatewayErrorAccessLogsRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>api.example.com</para>
        /// </summary>
        [NameInMap("authority")]
        [Validation(Required=false)]
        public string Authority { get; set; }

        /// <summary>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1756348800</para>
        /// </summary>
        [NameInMap("endTime")]
        [Validation(Required=false)]
        public long? EndTime { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>E5D4xxxx</para>
        /// </summary>
        [NameInMap("gatewayRequestId")]
        [Validation(Required=false)]
        public string GatewayRequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>/api/v1/pets</para>
        /// </summary>
        [NameInMap("path")]
        [Validation(Required=false)]
        public string Path { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>502</para>
        /// </summary>
        [NameInMap("responseCode")]
        [Validation(Required=false)]
        public string ResponseCode { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>my-route</para>
        /// </summary>
        [NameInMap("routeName")]
        [Validation(Required=false)]
        public string RouteName { get; set; }

        /// <summary>
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
