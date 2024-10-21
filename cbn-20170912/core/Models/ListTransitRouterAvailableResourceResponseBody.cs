// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cbn20170912.Models
{
    public class ListTransitRouterAvailableResourceResponseBody : TeaModel {
        /// <summary>
        /// <para>A list of zone IDs.</para>
        /// </summary>
        [NameInMap("AvailableZones")]
        [Validation(Required=false)]
        public List<string> AvailableZones { get; set; }

        /// <summary>
        /// <para>A list of primary zones.</para>
        /// </summary>
        [NameInMap("MasterZones")]
        [Validation(Required=false)]
        public List<string> MasterZones { get; set; }

        /// <summary>
        /// <para>The request ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>B4F480E0-4E76-5E43-9966-8322C28A158A</para>
        /// </summary>
        [NameInMap("RequestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <para>A list of secondary zone IDs.</para>
        /// </summary>
        [NameInMap("SlaveZones")]
        [Validation(Required=false)]
        public List<string> SlaveZones { get; set; }

        /// <summary>
        /// <para>Indicates whether the zone supports the multicast feature.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("SupportMulticast")]
        [Validation(Required=false)]
        public bool? SupportMulticast { get; set; }

    }

}
