// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class DescribeGraph4InvestigationOnlineRequest : TeaModel {
        /// <summary>
        /// <para>The ID of the alert event. You can call <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> to obtain the alert event ID, with the value path being: data.SuspEvents[index].UniqueInfo.</para>
        /// 
        /// <b>Example:</b>
        /// <para>786fc80896b25422b5324cb6e57bxxxx</para>
        /// </summary>
        [NameInMap("AnomalyId")]
        [Validation(Required=false)]
        public string AnomalyId { get; set; }

        /// <summary>
        /// <para>The UUID of the alert event asset. You can call <a href="~~DescribeSuspEvents~~">DescribeSuspEvents</a> to obtain the asset UUID, with the value path being: data.SuspEvents[index].Uuid.</para>
        /// 
        /// <b>Example:</b>
        /// <para>3502e4b0-f362-4059-84a2-f47fa2b5exxx</para>
        /// </summary>
        [NameInMap("AnomalyUuid")]
        [Validation(Required=false)]
        public string AnomalyUuid { get; set; }

        /// <summary>
        /// <para>Sets the language type for the request and response messages. The default is <b>zh</b>. Values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>zh</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The namespace of the graph, which is fixed as: hundun_dc_online.</para>
        /// <para>This parameter is required.</para>
        /// 
        /// <b>Example:</b>
        /// <para>hundun_dc_online</para>
        /// </summary>
        [NameInMap("Namespace")]
        [Validation(Required=false)]
        public string Namespace { get; set; }

        /// <summary>
        /// <para>Vertex ID. This does not need to be proactively provided.</para>
        /// 
        /// <b>Example:</b>
        /// <para>29872354f741b1b044b8a9b4e2ab****</para>
        /// </summary>
        [NameInMap("VertexId")]
        [Validation(Required=false)]
        public string VertexId { get; set; }

    }

}
