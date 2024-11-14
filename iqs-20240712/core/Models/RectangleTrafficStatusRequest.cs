// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.IQS20240712.Models
{
    public class RectangleTrafficStatusRequest : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>39.966309</para>
        /// </summary>
        [NameInMap("lowerLeftLatitude")]
        [Validation(Required=false)]
        public string LowerLeftLatitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>116.351147</para>
        /// </summary>
        [NameInMap("lowerLeftLongitude")]
        [Validation(Required=false)]
        public string LowerLeftLongitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>HIGHWAY</para>
        /// </summary>
        [NameInMap("roadLevel")]
        [Validation(Required=false)]
        public string RoadLevel { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>39.968739</para>
        /// </summary>
        [NameInMap("upperRightLatitude")]
        [Validation(Required=false)]
        public string UpperRightLatitude { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>116.35164</para>
        /// </summary>
        [NameInMap("upperRightLongitude")]
        [Validation(Required=false)]
        public string UpperRightLongitude { get; set; }

    }

}
