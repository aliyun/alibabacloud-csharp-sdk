// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Dts20200101.Models
{
    public class SwitchPhysicalDtsJobToCloudRequest : TeaModel {
        /// <summary>
        /// <para>Migration, synchronization, or subscription instance ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>dtsl3m1213ye7l****</para>
        /// </summary>
        [NameInMap("DtsInstanceId")]
        [Validation(Required=false)]
        public string DtsInstanceId { get; set; }

        /// <summary>
        /// <para>Data migration or synchronization instance ID, which can be queried by calling the <b>describedtsjobs</b> interface.</para>
        /// 
        /// <b>Example:</b>
        /// <para>l5512es7w15****</para>
        /// </summary>
        [NameInMap("DtsJobId")]
        [Validation(Required=false)]
        public string DtsJobId { get; set; }

        /// <summary>
        /// <para>Region ID. Pass this parameter to specify the region where the instance is located. For more details, see the list of supported regions.</para>
        /// 
        /// <b>Example:</b>
        /// <para>cn-hangzhou</para>
        /// </summary>
        [NameInMap("RegionId")]
        [Validation(Required=false)]
        public string RegionId { get; set; }

        /// <summary>
        /// <para>Resource group ID.</para>
        /// 
        /// <b>Example:</b>
        /// <para>rg-aekz4us4iruleja</para>
        /// </summary>
        [NameInMap("ResourceGroupId")]
        [Validation(Required=false)]
        public string ResourceGroupId { get; set; }

        /// <summary>
        /// <para>Synchronization direction, values: - <b>Forward</b>: Forward. - <b>Reverse</b>: Reverse.</para>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>The default value is <b>Forward</b>. - <b>Reverse</b> can only be passed when the topology of the data synchronization instance is bidirectional, to release the reverse synchronization link.</description></item>
        /// </list>
        /// </remarks>
        /// 
        /// <b>Example:</b>
        /// <para>Forward</para>
        /// </summary>
        [NameInMap("SynchronizationDirection")]
        [Validation(Required=false)]
        public string SynchronizationDirection { get; set; }

    }

}
