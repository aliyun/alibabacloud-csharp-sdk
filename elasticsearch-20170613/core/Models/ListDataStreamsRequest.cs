// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Elasticsearch20170613.Models
{
    public class ListDataStreamsRequest : TeaModel {
        /// <summary>
        /// <para>Specifies whether to display only managed indexes. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><para>true: displays only managed indexes.</para>
        /// </description></item>
        /// <item><description><para>false (default): displays all indexes.</para>
        /// </description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>false</para>
        /// </summary>
        [NameInMap("isManaged")]
        [Validation(Required=false)]
        public bool? IsManaged { get; set; }

        /// <summary>
        /// <para>The data stream name.</para>
        /// 
        /// <b>Example:</b>
        /// <para>Log1</para>
        /// </summary>
        [NameInMap("name")]
        [Validation(Required=false)]
        public string Name { get; set; }

    }

}
