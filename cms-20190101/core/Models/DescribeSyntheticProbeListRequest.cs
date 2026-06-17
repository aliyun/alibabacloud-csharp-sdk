// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Cms20190101.Models
{
    public class DescribeSyntheticProbeListRequest : TeaModel {
        /// <summary>
        /// <para>The name or ID of the city where the carrier detection point is located.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Beijing</para>
        /// </summary>
        [NameInMap("City")]
        [Validation(Required=false)]
        public string City { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only detection points in data centers.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("IdcProbe")]
        [Validation(Required=false)]
        public bool? IdcProbe { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only IPv4 detection points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Ipv4")]
        [Validation(Required=false)]
        public bool? Ipv4 { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only IPv6 detection points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("Ipv6")]
        [Validation(Required=false)]
        public bool? Ipv6 { get; set; }

        /// <summary>
        /// <para>The name or ID of the carrier.</para>
        /// 
        /// <b>Example:</b>
        /// <para>China Unicom</para>
        /// </summary>
        [NameInMap("Isp")]
        [Validation(Required=false)]
        public string Isp { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only last-mile detection points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("LmProbe")]
        [Validation(Required=false)]
        public bool? LmProbe { get; set; }

        /// <summary>
        /// <para>Specifies whether to return only mobile detection points.</para>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("MbProbe")]
        [Validation(Required=false)]
        public bool? MbProbe { get; set; }

        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Specifies whether to return all detection points. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>false (default): Returns the detection points that are available to you.</para>
        /// </description></item>
        /// <item><description><para>true: Returns all detection points.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>true</para>
        /// </summary>
        [NameInMap("ViewAll")]
        [Validation(Required=false)]
        public bool? ViewAll { get; set; }

    }

}
