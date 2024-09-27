// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.CS20151215.Models
{
    public class DescribeEdgeMachinesRequest : TeaModel {
        /// <summary>
        /// <para>The <c>hostname</c> of the cloud-native box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ack-v-b010-ssdfw****</para>
        /// </summary>
        [NameInMap("hostname")]
        [Validation(Required=false)]
        public string Hostname { get; set; }

        /// <summary>
        /// <para>The lifecycle status.</para>
        /// 
        /// <b>Example:</b>
        /// <para>activated/waitOnline/deleting</para>
        /// </summary>
        [NameInMap("life_state")]
        [Validation(Required=false)]
        public string LifeState { get; set; }

        /// <summary>
        /// <para>The type of cloud-native box.</para>
        /// 
        /// <b>Example:</b>
        /// <para>ACK-V-B010</para>
        /// </summary>
        [NameInMap("model")]
        [Validation(Required=false)]
        public string Model { get; set; }

        /// <summary>
        /// <para>The status of the cloud-native box. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><c>offline</c></description></item>
        /// <item><description><c>online</c></description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>offline/online</para>
        /// </summary>
        [NameInMap("online_state")]
        [Validation(Required=false)]
        public string OnlineState { get; set; }

        /// <summary>
        /// <para>The page number.</para>
        /// 
        /// <b>Example:</b>
        /// <para>1</para>
        /// </summary>
        [NameInMap("page_number")]
        [Validation(Required=false)]
        public long? PageNumber { get; set; }

        /// <summary>
        /// <para>The number of entries per page.</para>
        /// 
        /// <b>Example:</b>
        /// <para>10</para>
        /// </summary>
        [NameInMap("page_size")]
        [Validation(Required=false)]
        public long? PageSize { get; set; }

    }

}
