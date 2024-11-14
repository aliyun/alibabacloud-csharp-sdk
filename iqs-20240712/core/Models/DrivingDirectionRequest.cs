// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class DrivingDirectionRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>39.896463</para>
        /// </summary>
        [NameInMap("destinationLatitude")]
        [Validation(Required=false)]
        public string DestinationLatitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>116.46424</para>
        /// </summary>
        [NameInMap("destinationLongitude")]
        [Validation(Required=false)]
        public string DestinationLongitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39.995197</para>
        /// </summary>
        [NameInMap("originLatitude")]
        [Validation(Required=false)]
        public string OriginLatitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>116.466485</para>
        /// </summary>
        [NameInMap("originLongitude")]
        [Validation(Required=false)]
        public string OriginLongitude { get; set; }

    }

}
