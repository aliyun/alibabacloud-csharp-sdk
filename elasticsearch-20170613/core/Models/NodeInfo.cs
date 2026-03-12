// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class NodeInfo : TeaModel {
        /// <summary>
        /// <b>Example:</b>
        /// <para>172.16.xx.xx</para>
        /// </summary>
        [NameInMap("host")]
        [Validation(Required=false)]
        public string Host { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>es-cn-tl32vdghe0005cd99-data-b-2</para>
        /// </summary>
        [NameInMap("hostName")]
        [Validation(Required=false)]
        public string HostName { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>9200</para>
        /// </summary>
        [NameInMap("port")]
        [Validation(Required=false)]
        public long? Port { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>cn-hangzhou-b</para>
        /// </summary>
        [NameInMap("zoneId")]
        [Validation(Required=false)]
        public string ZoneId { get; set; }

    }

}
