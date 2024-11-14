// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class CircleTrafficStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>39.98641364</para>
        /// </summary>
        [NameInMap("latitude")]
        [Validation(Required=false)]
        public string Latitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>116.3057764</para>
        /// </summary>
        [NameInMap("longitude")]
        [Validation(Required=false)]
        public string Longitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>1000</para>
        /// </summary>
        [NameInMap("radius")]
        [Validation(Required=false)]
        public string Radius { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HIGHWAY</para>
        /// </summary>
        [NameInMap("roadLevel")]
        [Validation(Required=false)]
        public string RoadLevel { get; set; }

    }

}
