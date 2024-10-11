// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Airec20201126.Models
{
    public class ListDataDiagnoseReportsResponseBody : TeaModel {
        /// <summary>
        /// <para>Id of the request</para>
        /// 
        /// <b>Example:</b>
        /// <para>8B90B646-1678-41A3-B23F-EAC6587B0E48</para>
        /// </summary>
        [NameInMap("requestId")]
        [Validation(Required=false)]
        public string RequestId { get; set; }

        /// <summary>
        /// <b>Example:</b>
        /// <para>{
        ///     &quot;todayTimeLimit&quot;:8,
        ///     &quot;totalCount&quot;:10,
        ///     &quot;reports&quot;:[
        ///         {
        ///             &quot;diagnoseLevel&quot;:&quot;low | medium | high&quot;,
        ///             &quot;startTime&quot;:1566489600,
        ///             &quot;endTime&quot;:1566489600,
        ///             &quot;taskCreateTime&quot;:1566489600,
        ///             &quot;taskSource&quot;:&quot;manual | cycle | firstRun&quot;,
        ///             &quot;total&quot;:{
        ///                 &quot;itemCount&quot;:100,
        ///                 &quot;userCount&quot;:100,
        ///                 &quot;bhvCount&quot;:100
        ///             },
        ///             &quot;details&quot;:[
        ///                 {
        ///                     &quot;key&quot;:&quot;&quot;,
        ///                     &quot;level&quot;:&quot;error | warn | info&quot;,
        ///                     &quot;errorCount&quot;:10,
        ///                     &quot;errorPercent&quot;:10,
        ///                     &quot;sampleEnabled&quot;:true;
        ///                 }
        ///             ]
        ///         },
        ///         {
        ///             &quot;diagnoseLevel&quot;:&quot;low | medium | high&quot;,
        ///             &quot;startTime&quot;:1566489600,
        ///             &quot;endTime&quot;:1566489600,
        ///             &quot;taskCreateTime&quot;:1566489600,
        ///             &quot;taskSource&quot;:&quot;manual | cycle | firstRun&quot;,
        ///             &quot;total&quot;:{
        ///                 &quot;itemCount&quot;:100,
        ///                 &quot;userCount&quot;:100,
        ///                 &quot;bhvCount&quot;:100
        ///             },
        ///             &quot;details&quot;:[
        ///                 {
        ///                     &quot;key&quot;:&quot;&quot;,
        ///                     &quot;level&quot;:&quot;error | warn | info&quot;,
        ///                     &quot;errorCount&quot;:10,
        ///                     &quot;errorPercent&quot;:10,
        ///                     &quot;sampleEnabled&quot;:true;
        ///                 }
        ///             ]
        ///         }
        ///     ]
        /// }</para>
        /// </summary>
        [NameInMap("result")]
        [Validation(Required=false)]
        public Dictionary<string, object> Result { get; set; }

    }

}
