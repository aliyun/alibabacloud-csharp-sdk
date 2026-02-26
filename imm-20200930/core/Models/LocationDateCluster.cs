// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Imm20200930.Models
{
    public class LocationDateCluster : TeaModel {
        /// <summary>
        /// <para>The addresses.</para>
        /// </summary>
        [NameInMap("Addresses")]
        [Validation(Required=false)]
        public List<Address> Addresses { get; set; }

        /// <summary>
        /// <para>The time when the spatiotemporal cluster was created.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-16T13:14:34.882523669+08:00</para>
        /// </summary>
        [NameInMap("CreateTime")]
        [Validation(Required=false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// <para>The custom ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>user-01</para>
        /// </summary>
        [NameInMap("CustomId")]
        [Validation(Required=false)]
        public string CustomId { get; set; }

        /// <summary>
        /// <para>The custom labels.</para>
        /// 
        /// <b>Example:</b>
        /// <para>{
        ///       &quot;User&quot;: &quot;Jane&quot;
        /// }</para>
        /// </summary>
        [NameInMap("CustomLabels")]
        [Validation(Required=false)]
        public Dictionary<string, object> CustomLabels { get; set; }

        /// <summary>
        /// <para>The end time of the spatiotemporal cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-02T23:59:59.999999999+08:00</para>
        /// </summary>
        [NameInMap("LocationDateClusterEndTime")]
        [Validation(Required=false)]
        public string LocationDateClusterEndTime { get; set; }

        /// <summary>
        /// <para>The administrative level of the spatiotemporal cluster.</para>
        /// <para>Enumerated values:</para>
        /// <list type="bullet">
        /// <item><description>country</description></item>
        /// <item><description>province</description></item>
        /// <item><description>city</description></item>
        /// <item><description>district</description></item>
        /// <item><description>township</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>province</para>
        /// </summary>
        [NameInMap("LocationDateClusterLevel")]
        [Validation(Required=false)]
        public string LocationDateClusterLevel { get; set; }

        /// <summary>
        /// <para>The start time of the spatiotemporal cluster.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-05-01T00:00:00+08:00</para>
        /// </summary>
        [NameInMap("LocationDateClusterStartTime")]
        [Validation(Required=false)]
        public string LocationDateClusterStartTime { get; set; }

        /// <summary>
        /// <para>The cluster ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>location-date-cluster-14f48cb3-079d-4595-80c4-5735284b****</para>
        /// </summary>
        [NameInMap("ObjectId")]
        [Validation(Required=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// <para>The custom title.</para>
        /// </summary>
        [NameInMap("Title")]
        [Validation(Required=false)]
        public string Title { get; set; }

        /// <summary>
        /// <para>The time when the spatiotemporal cluster was updated.</para>
        /// 
        /// <b>Example:</b>
        /// <para>2022-11-16T13:15:05.65746784+08:00</para>
        /// </summary>
        [NameInMap("UpdateTime")]
        [Validation(Required=false)]
        public string UpdateTime { get; set; }

    }

}
