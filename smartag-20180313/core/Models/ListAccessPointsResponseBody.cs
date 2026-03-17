// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Smartag20180313.Models
{
    public class ListAccessPointsResponseBody : TeaModel {
        /// <summary>
        /// <para>The information about the access point.</para>
        /// </summary>
        [NameInMap("AccessPoints")]
        [Validation(Required=false)]
        public List<ListAccessPointsResponseBodyAccessPoints> AccessPoints { get; set; }
        public class ListAccessPointsResponseBodyAccessPoints : TeaModel {
            /// <summary>
            /// <para>The ID of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>401</para>
            /// </summary>
            [NameInMap("AccessPointId")]
            [Validation(Required=false)]
            public int? AccessPointId { get; set; }

            /// <summary>
            /// <para>The number of available SAG instances in the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>0</para>
            /// </summary>
            [NameInMap("ActiveSmartAGCount")]
            [Validation(Required=false)]
            public int? ActiveSmartAGCount { get; set; }

            /// <summary>
            /// <para>The number of offline SAG instances in the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>7</para>
            /// </summary>
            [NameInMap("InactiveSmartAGCount")]
            [Validation(Required=false)]
            public int? InactiveSmartAGCount { get; set; }

            /// <summary>
            /// <para>The latitude of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>103.81****</para>
            /// </summary>
            [NameInMap("Latitude")]
            [Validation(Required=false)]
            public string Latitude { get; set; }

            /// <summary>
            /// <para>The longitude of the access point.</para>
            /// 
            /// <b>Example:</b>
            /// <para>1.35****</para>
            /// </summary>
            [NameInMap("Longitude")]
            [Validation(Required=false)]
            public string Longitude { get; set; }

        }

        /// <summary>
        /// <para>The ID of the request.</para>
        /// 
        /// <b>Example:</b>
        /// <para>E26DBAAE-A796-4A48-98B4-B45AFCD1F299</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>The total number of access points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2</para>
        /// </summary>
        [NameInMap("TotalCount")]
        [Validation(Required=false)]
        public int? TotalCount { get; set; }

    }

}
