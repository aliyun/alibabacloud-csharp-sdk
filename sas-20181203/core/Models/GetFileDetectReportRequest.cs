// This file is auto-generated, don't edit it. Thanks.

using System;
using System.Collections.Generic;
using System.IO;

using Tea;

namespace AlibabaCloud.SDK.Sas20181203.Models
{
    public class GetFileDetectReportRequest : TeaModel {
        /// <summary>
        /// <para>The event ID that corresponds to the file to be detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>81****</para>
        /// </summary>
        [NameInMap("EventId")]
        [Validation(Required=false)]
        public long? EventId { get; set; }

        /// <summary>
        /// <para>The field that you want to query. You can enter multiple fields and separate them with commas (,).</para>
        /// <para>Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>ThreatTypes</b>: the type of the threat intelligence event</description></item>
        /// <item><description><b>Intelligences</b>: the threat intelligence event</description></item>
        /// <item><description><b>ThreatLevel</b>: the level of the threat intelligence event</description></item>
        /// <item><description><b>Basic</b>: the basic information about the report (the scan result)</description></item>
        /// <item><description><b>Sandbox</b>: the cloud sandbox check report</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>Basic,,ThreatTypes,Intelligences,Sandbox</para>
        /// </summary>
        [NameInMap("Field")]
        [Validation(Required=false)]
        public string Field { get; set; }

        /// <summary>
        /// <para>The hash value of the file to be detected.</para>
        /// 
        /// <b>Example:</b>
        /// <para>b63917332950e5d219d0737ffe31****</para>
        /// </summary>
        [NameInMap("FileHash")]
        [Validation(Required=false)]
        public string FileHash { get; set; }

        /// <summary>
        /// <para>The language of the content within the request and response. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>zh</b>: Chinese</description></item>
        /// <item><description><b>en</b>: English</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>en</para>
        /// </summary>
        [NameInMap("Lang")]
        [Validation(Required=false)]
        public string Lang { get; set; }

        /// <summary>
        /// <para>The data source type. Valid values:</para>
        /// <list type="bullet">
        /// <item><description><b>machine</b>: host alerts</description></item>
        /// <item><description><b>object_scan</b>: file detection alerts</description></item>
        /// </list>
        /// 
        /// <b>Example:</b>
        /// <para>object_scan</para>
        /// </summary>
        [NameInMap("SourceType")]
        [Validation(Required=false)]
        public string SourceType { get; set; }

    }

}
